using System;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Threading;
using System.Windows.Forms;
using OpenHardwareMonitor.Collections;
using OpenHardwareMonitor.Hardware;
using CPUInspector.Properties;
using System.Security.Principal;

namespace CPUInspector
{
    public partial class Mainform : Form
    {
        private bool admin = false;
        private string cpuname;
        private string xcores;
        private string logproc;
        private string socket;
        private string l2size;
        private string l3size;  
        private string manu;
        private string clock;
        private string ramsize;
        private bool Ctempfailed;
        private bool Cloadfailed;
        private int cpuTemp;
        private int cpuLoad;
        private Thread infoload;
        private Thread cpuThreadLoad;
        private Thread cpuThreadTemp;
        private double[] cpuArray = new double[30];
        private double[] cpuTempArray = new double[30];

        public Mainform()
        {
            InitializeComponent();
        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            checkAdmin();
            on_Start();
        }

        private void ComponentInfo()
        {
            ManagementObjectCollection moc;
            moc = new ManagementObjectSearcher("select * from Win32_Processor").Get();
            foreach (ManagementObject obj in moc)
            {
                // Text aktualisieren

                try { cpuname = obj["Name"].ToString();                      } catch { lblCpuname.Text = "Error obtaining information"; }
                try { xcores  = obj["NumberOfCores"].ToString();             } catch { xcores  = "Error"; }
                try { logproc = obj["NumberOfLogicalProcessors"].ToString(); } catch { logproc = "Error"; }
                try { socket  = obj["SocketDesignation"].ToString();         } catch { socket  = "Error"; }
                try { l2size  = obj["L2CacheSize"].ToString() + " kb";       } catch { l2size  = "Error"; }
                try { l3size  = obj["L3CacheSize"].ToString() + " kb";       } catch { l3size  = "Error"; }
                try { clock   = Convert.ToString(Math.Round(Convert.ToDouble(obj["MaxClockSpeed"]) / 1000, 1)); } catch { clock = "Error"; }
                try { manu    = obj["Manufacturer"].ToString();              } catch { manu    = "Error"; }


                // Hersteller (Name & Bild)

                if (manu == "AuthenticAMD") manu = "AMD";
                else if (manu == "GenuineIntel") manu = "Intel";
                if (manu == "AMD") PBmanufacturer.Image = Resources.amd;
                else if (manu == "Intel") PBmanufacturer.Image = Resources.intel;
                else PBmanufacturer.Image = Resources.unknown;
            }

            // Ram (überarbeitungsbedarf)
            moc = new ManagementObjectSearcher("select * from Win32_ComputerSystem").Get();
            foreach (ManagementObject obj in moc)
            {
                try{ramsize = Convert.ToString(Math.Round((Convert.ToDouble(obj["TotalPhysicalMemory"]) / 1073741824), 1)) + " GB"; } catch{ramsize = "Error";}
            }
        }

        private void on_Start()
        {
            // Graphen
            chartLoad.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chartLoad.ChartAreas[0].AxisY.Maximum = 101;
            chartLoad.ChartAreas[0].AxisY.Minimum = -1;
            chartLoad.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            chartTemp.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chartTemp.ChartAreas[0].AxisY.Maximum = 101;
            chartTemp.ChartAreas[0].AxisY.Minimum = -1;
            chartTemp.ChartAreas[0].AxisY.LabelStyle.Enabled = false;

            // Graphen initialisieren
            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                chartLoad.Series["Load"].Points.AddY(0);
                chartTemp.Series["Temperature"].Points.AddY(0);
            }

            // Info Load Thread

            infoload = new Thread(new ThreadStart(this.ComponentInfo));
            infoload.IsBackground = true;
            infoload.Start();
            infoload.Join();
            infoload.Abort();

            // Graphen Start
            cpuThreadLoad = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThreadLoad.IsBackground = true;
            cpuThreadLoad.Start();

            if (admin)
            {
                cpuThreadTemp = new Thread(new ThreadStart(this.getTempInfo));
                cpuThreadTemp.IsBackground = true;
                cpuThreadTemp.Start();
                chartTimer.Start();
            }

            // Labels aktualisieren
            try { lblCpuname.Text        = cpuname; } catch { lblCpuname.Text = "Error obtaining information"; }
            try { lblCores.Text          = xcores;  } catch { lblCores.Text = "Error"; }
            try { lblLogProc.Text        = logproc; } catch { lblLogProc.Text = "Error"; }
            try { lblSocket.Text         = socket;  } catch { lblSocket.Text = "Error"; }
            try { lblL2size.Text         = l2size;  } catch { lblL2size.Text = "Error"; }
            try { lblL3size.Text         = l3size;  } catch { lblL3size.Text = "Error"; }
            try { lblBaseclock.Text      = Convert.ToString(clock) + " Ghz"; } catch { lblBaseclock.Text = "Error"; }
            try { lblManu.Text           = manu;    } catch { lblManu.Text = "Error"; }
            try { lblPhysicalMemory.Text = ramsize; } catch { lblPhysicalMemory.Text = "Error"; }

            updateCpuChart();
        }

        private void checkAdmin()
        {
            try
            {
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    admin = (new WindowsPrincipal(identity)).IsInRole(WindowsBuiltInRole.Administrator);
                }
            }
            catch
            {
                admin = false;
                lblAdmin.Visible = true;
            }
        }

        private void chartTimer_Tick(object sender, EventArgs e)
        {
            updateCpuChart();
        }

        protected readonly ListSet<ISensor> active = new ListSet<ISensor>();
        public event SensorEventHandler SensorAdded;

        protected virtual void ActivateSensor(ISensor sensor)
        {
            if (active.Add(sensor) && SensorAdded != null)
                SensorAdded(sensor);
        }
        
        // CPU Temperature
        private void getTempInfo()
        {
            var myComputer = new Computer();
            myComputer.CPUEnabled = true;
            myComputer.Open();

            while (true)
            {
                try
                { 
                    foreach (var hardwareItem in myComputer.Hardware)
                    {
                        hardwareItem.Update();
                        hardwareItem.GetReport();
                        foreach (var sensor in hardwareItem.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("CPU Package"))
                            {
                                cpuTemp = (int)Math.Round(sensor.Value.GetValueOrDefault());
                                cpuTempArray[cpuTempArray.Length - 1] = cpuTemp;
                                Array.Copy(cpuTempArray, 1, cpuTempArray, 0, cpuTempArray.Length - 1);
                            }
                        }
                    }
                    Ctempfailed = false;
                }
                catch
                {
                    Ctempfailed = true;
                }
                Thread.Sleep(1000);
            }
        }

        //CPU Auslastung
        private void getPerformanceCounters()
        { 
            var cpuPerfCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            while (true)
            {
                try
                {
                    cpuLoad = (int)Math.Floor(cpuPerfCounter.NextValue());
                    cpuArray[cpuArray.Length - 1] = cpuLoad;
                    Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                    Thread.Sleep(1000);
                    Cloadfailed = false;
                }
                catch
                {
                    Cloadfailed= true;
                }
            }
        }

        // Aktualisieren vom UI (Chart + Labels)
        private void updateCpuChart()
        {
            chartLoad.Series["Load"].Points.Clear();
            
            lblCputemp.ForeColor = getColorForTemperature(cpuTempArray[cpuTempArray.Length - 1]);

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                chartLoad.Series["Load"].Points.AddY(cpuArray[i]);
            }
            lblCputemp.Text = Convert.ToString(cpuTemp) + "°C";
            lblCpuload.Text = Convert.ToString(cpuLoad) + "%";

            if (cpuLoad == 100) this.lblCpuload.Location = new Point(0, 12);
            if (cpuLoad >= 10)  this.lblCpuload.Location = new Point(3, 12);
            else this.lblCpuload.Location = new Point(6, 12);

            chartTemp.Series["Temperature"].Points.Clear();
            for (int i = 0; i < cpuTempArray.Length - 1; ++i)
            {
                chartTemp.Series["Temperature"].Points.AddY(cpuTempArray[i]);
                chartTemp.Series["Temperature"].Points[i].Color = getColorForTemperature(cpuTempArray[i]);
            }
            this.Text = $"CPU Inspector [{cpuLoad}% | {cpuTemp}°C]";

            if(Ctempfailed == true)  lblTemperror.Visible = true;
            else lblTemperror.Visible = false;
            if (Cloadfailed == true) lblLoaderror.Visible = true;
            else lblLoaderror.Visible = false;        
        }

        // Farbe für Chart & Label
        Color getColorForTemperature(double temp)
        {
            if (temp > 50)
            {
                int colorDifference = (int)(255f / 30f * (temp - 50f));
                if (colorDifference > 255) colorDifference = 255;
                return Color.FromArgb(colorDifference, 255 - colorDifference, 0);
            }
            else
            {
                return Color.FromArgb(0, 230, 0);
            }
        }

        // Wenn Programm beendet wird
        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cpuThreadLoad != null && cpuThreadLoad.IsAlive)
            {
                cpuThreadLoad.Abort();
            }

            if (cpuThreadTemp != null && cpuThreadTemp.IsAlive)
            {
                cpuThreadTemp.Abort();
            }
        }

    }
}
