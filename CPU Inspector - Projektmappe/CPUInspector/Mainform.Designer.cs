namespace CPUInspector
{
    partial class Mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.lblCpuname = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblL3c = new System.Windows.Forms.Label();
            this.cores = new System.Windows.Forms.Label();
            this.logProc = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBaseclock = new System.Windows.Forms.Label();
            this.lblLogProc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblManu = new System.Windows.Forms.Label();
            this.Socket = new System.Windows.Forms.Label();
            this.lblSocket = new System.Windows.Forms.Label();
            this.lblL2c = new System.Windows.Forms.Label();
            this.lblL2size = new System.Windows.Forms.Label();
            this.lblL3size = new System.Windows.Forms.Label();
            this.lblPhysicalMemory = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCputemp = new System.Windows.Forms.Label();
            this.chartLoad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCpuload = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PBmanufacturer = new System.Windows.Forms.PictureBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblTemperror = new System.Windows.Forms.Label();
            this.lblLoaderror = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoad)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBmanufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCpuname
            // 
            this.lblCpuname.AutoSize = true;
            this.lblCpuname.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuname.Location = new System.Drawing.Point(12, 21);
            this.lblCpuname.Name = "lblCpuname";
            this.lblCpuname.Size = new System.Drawing.Size(44, 18);
            this.lblCpuname.TabIndex = 1;
            this.lblCpuname.Text = "CPU ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblL3c, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.logProc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCores, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBaseclock, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLogProc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblManu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Socket, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSocket, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblL2c, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblL2size, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblL3size, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblPhysicalMemory, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 237);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 161);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblL3c
            // 
            this.lblL3c.AutoSize = true;
            this.lblL3c.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL3c.Location = new System.Drawing.Point(3, 120);
            this.lblL3c.Name = "lblL3c";
            this.lblL3c.Size = new System.Drawing.Size(63, 14);
            this.lblL3c.TabIndex = 11;
            this.lblL3c.Text = "L3-Cache";
            // 
            // cores
            // 
            this.cores.AutoSize = true;
            this.cores.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cores.Location = new System.Drawing.Point(3, 0);
            this.cores.Name = "cores";
            this.cores.Size = new System.Drawing.Size(42, 14);
            this.cores.TabIndex = 0;
            this.cores.Text = "Cores";
            // 
            // logProc
            // 
            this.logProc.AutoSize = true;
            this.logProc.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logProc.Location = new System.Drawing.Point(3, 20);
            this.logProc.Name = "logProc";
            this.logProc.Size = new System.Drawing.Size(133, 14);
            this.logProc.TabIndex = 1;
            this.logProc.Text = "Logical Processors\r\n";
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Location = new System.Drawing.Point(146, 0);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(34, 13);
            this.lblCores.TabIndex = 2;
            this.lblCores.Text = "Cores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base Clock";
            // 
            // lblBaseclock
            // 
            this.lblBaseclock.AutoSize = true;
            this.lblBaseclock.Location = new System.Drawing.Point(146, 40);
            this.lblBaseclock.Name = "lblBaseclock";
            this.lblBaseclock.Size = new System.Drawing.Size(57, 13);
            this.lblBaseclock.TabIndex = 5;
            this.lblBaseclock.Text = "Baseclock";
            // 
            // lblLogProc
            // 
            this.lblLogProc.AutoSize = true;
            this.lblLogProc.Location = new System.Drawing.Point(146, 20);
            this.lblLogProc.Name = "lblLogProc";
            this.lblLogProc.Size = new System.Drawing.Size(50, 13);
            this.lblLogProc.TabIndex = 3;
            this.lblLogProc.Text = "Log Proc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manufacturer";
            // 
            // lblManu
            // 
            this.lblManu.AutoSize = true;
            this.lblManu.Location = new System.Drawing.Point(146, 60);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(70, 13);
            this.lblManu.TabIndex = 7;
            this.lblManu.Text = "Manufacturer";
            // 
            // Socket
            // 
            this.Socket.AutoSize = true;
            this.Socket.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Socket.Location = new System.Drawing.Point(3, 80);
            this.Socket.Name = "Socket";
            this.Socket.Size = new System.Drawing.Size(49, 14);
            this.Socket.TabIndex = 8;
            this.Socket.Text = "Socket";
            // 
            // lblSocket
            // 
            this.lblSocket.AutoSize = true;
            this.lblSocket.Location = new System.Drawing.Point(146, 80);
            this.lblSocket.Name = "lblSocket";
            this.lblSocket.Size = new System.Drawing.Size(41, 13);
            this.lblSocket.TabIndex = 9;
            this.lblSocket.Text = "Socket";
            // 
            // lblL2c
            // 
            this.lblL2c.AutoSize = true;
            this.lblL2c.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL2c.Location = new System.Drawing.Point(3, 100);
            this.lblL2c.Name = "lblL2c";
            this.lblL2c.Size = new System.Drawing.Size(63, 14);
            this.lblL2c.TabIndex = 10;
            this.lblL2c.Text = "L2-Cache";
            // 
            // lblL2size
            // 
            this.lblL2size.AutoSize = true;
            this.lblL2size.Location = new System.Drawing.Point(146, 100);
            this.lblL2size.Name = "lblL2size";
            this.lblL2size.Size = new System.Drawing.Size(27, 13);
            this.lblL2size.TabIndex = 12;
            this.lblL2size.Text = "x kb";
            // 
            // lblL3size
            // 
            this.lblL3size.AutoSize = true;
            this.lblL3size.Location = new System.Drawing.Point(146, 120);
            this.lblL3size.Name = "lblL3size";
            this.lblL3size.Size = new System.Drawing.Size(27, 13);
            this.lblL3size.TabIndex = 13;
            this.lblL3size.Text = "x kb";
            // 
            // lblPhysicalMemory
            // 
            this.lblPhysicalMemory.AutoSize = true;
            this.lblPhysicalMemory.Location = new System.Drawing.Point(146, 140);
            this.lblPhysicalMemory.Name = "lblPhysicalMemory";
            this.lblPhysicalMemory.Size = new System.Drawing.Size(29, 13);
            this.lblPhysicalMemory.TabIndex = 16;
            this.lblPhysicalMemory.Text = "x Gb";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Physical Memory";
            // 
            // chartTemp
            // 
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            this.chartTemp.Location = new System.Drawing.Point(265, 236);
            this.chartTemp.Name = "chartTemp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Cyan;
            series1.Name = "Temperature";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series1.SmartLabelStyle.Enabled = false;
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Size = new System.Drawing.Size(378, 162);
            this.chartTemp.TabIndex = 6;
            this.chartTemp.Text = "chart1";
            // 
            // chartTimer
            // 
            this.chartTimer.Interval = 1000;
            this.chartTimer.Tick += new System.EventHandler(this.chartTimer_Tick);
            // 
            // lblCputemp
            // 
            this.lblCputemp.AutoSize = true;
            this.lblCputemp.BackColor = System.Drawing.Color.White;
            this.lblCputemp.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCputemp.Location = new System.Drawing.Point(1, 14);
            this.lblCputemp.Name = "lblCputemp";
            this.lblCputemp.Size = new System.Drawing.Size(31, 15);
            this.lblCputemp.TabIndex = 11;
            this.lblCputemp.Text = "0°C";
            // 
            // chartLoad
            // 
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chartLoad.ChartAreas.Add(chartArea2);
            this.chartLoad.Location = new System.Drawing.Point(265, 67);
            this.chartLoad.Name = "chartLoad";
            this.chartLoad.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DarkSlateGray;
            series2.Name = "Load";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series2.SmartLabelStyle.Enabled = false;
            this.chartLoad.Series.Add(series2);
            this.chartLoad.Size = new System.Drawing.Size(378, 162);
            this.chartLoad.TabIndex = 12;
            this.chartLoad.Text = "chart1";
            // 
            // lblCpuload
            // 
            this.lblCpuload.AutoSize = true;
            this.lblCpuload.BackColor = System.Drawing.Color.White;
            this.lblCpuload.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuload.Location = new System.Drawing.Point(3, 12);
            this.lblCpuload.Name = "lblCpuload";
            this.lblCpuload.Size = new System.Drawing.Size(23, 15);
            this.lblCpuload.TabIndex = 13;
            this.lblCpuload.Text = "0%";
            this.lblCpuload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblCputemp);
            this.panel1.Location = new System.Drawing.Point(640, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 162);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblCpuload);
            this.panel2.Location = new System.Drawing.Point(640, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 162);
            this.panel2.TabIndex = 15;
            // 
            // PBmanufacturer
            // 
            this.PBmanufacturer.Location = new System.Drawing.Point(52, 67);
            this.PBmanufacturer.Name = "PBmanufacturer";
            this.PBmanufacturer.Size = new System.Drawing.Size(150, 150);
            this.PBmanufacturer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBmanufacturer.TabIndex = 8;
            this.PBmanufacturer.TabStop = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(340, 270);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(277, 78);
            this.lblAdmin.TabIndex = 16;
            this.lblAdmin.Text = "Admin rights \r\nrequired";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAdmin.Visible = false;
            // 
            // lblTemperror
            // 
            this.lblTemperror.AutoSize = true;
            this.lblTemperror.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperror.Location = new System.Drawing.Point(311, 251);
            this.lblTemperror.Name = "lblTemperror";
            this.lblTemperror.Size = new System.Drawing.Size(119, 30);
            this.lblTemperror.TabIndex = 17;
            this.lblTemperror.Text = "Data could not\r\n be obtained";
            this.lblTemperror.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTemperror.Visible = false;
            // 
            // lblLoaderror
            // 
            this.lblLoaderror.AutoSize = true;
            this.lblLoaderror.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaderror.Location = new System.Drawing.Point(311, 79);
            this.lblLoaderror.Name = "lblLoaderror";
            this.lblLoaderror.Size = new System.Drawing.Size(119, 30);
            this.lblLoaderror.TabIndex = 18;
            this.lblLoaderror.Text = "Data could not\r\n be obtained";
            this.lblLoaderror.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoaderror.Visible = false;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(694, 411);
            this.Controls.Add(this.lblLoaderror);
            this.Controls.Add(this.lblTemperror);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.chartLoad);
            this.Controls.Add(this.PBmanufacturer);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblCpuname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Mainform";
            this.Text = "CPU Inspector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLoad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBmanufacturer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCpuname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLogProc;
        private System.Windows.Forms.Label cores;
        private System.Windows.Forms.Label logProc;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBaseclock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblManu;
        private System.Windows.Forms.Label Socket;
        private System.Windows.Forms.Label lblSocket;
        private System.Windows.Forms.Label lblL3c;
        private System.Windows.Forms.Label lblL2c;
        private System.Windows.Forms.Label lblL2size;
        private System.Windows.Forms.Label lblL3size;
        private System.Windows.Forms.Label lblPhysicalMemory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.PictureBox PBmanufacturer;
        private System.Windows.Forms.Label lblCputemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLoad;
        private System.Windows.Forms.Label lblCpuload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblTemperror;
        private System.Windows.Forms.Label lblLoaderror;
    }
}

