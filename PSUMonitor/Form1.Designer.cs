namespace PSUMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtSerialMonitor = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpLogOutput = new System.Windows.Forms.GroupBox();
            this.txtLogOutput = new System.Windows.Forms.TextBox();
            this.grpSerialPortSettings = new System.Windows.Forms.GroupBox();
            this.lblLastDataRcvd = new System.Windows.Forms.Label();
            this.lblLastDataRcvdLbl = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStopBitsLbl = new System.Windows.Forms.Label();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.lblParitylbl = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.lblDataBitsLbl = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.lblBaudRateLbl = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.lblPortNameLbl = new System.Windows.Forms.Label();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartCurrentValues = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpParams = new System.Windows.Forms.GroupBox();
            this.lblCh1PowerDivider = new System.Windows.Forms.Label();
            this.lblCh1CurrentDivider = new System.Windows.Forms.Label();
            this.lblCh1PowerDividerLabel = new System.Windows.Forms.Label();
            this.lblCh1CurrentDividerLabel = new System.Windows.Forms.Label();
            this.lblCh1VoltageDivider = new System.Windows.Forms.Label();
            this.lblCh1VoltageDividerLabel = new System.Windows.Forms.Label();
            this.grpDashChannel2 = new System.Windows.Forms.GroupBox();
            this.lblCh2PowerLabel = new System.Windows.Forms.Label();
            this.lblCh2Power = new System.Windows.Forms.Label();
            this.lblCh2CurrentLabel = new System.Windows.Forms.Label();
            this.lblCh2Current = new System.Windows.Forms.Label();
            this.lblCh2VoltageLabel = new System.Windows.Forms.Label();
            this.lblCh2Voltage = new System.Windows.Forms.Label();
            this.grpDashChannel1 = new System.Windows.Forms.GroupBox();
            this.lblCh1PowerLabel = new System.Windows.Forms.Label();
            this.lblCh1Power = new System.Windows.Forms.Label();
            this.lblCh1CurrentLabel = new System.Windows.Forms.Label();
            this.lblCh1Current = new System.Windows.Forms.Label();
            this.lblCh1VoltageLabel = new System.Windows.Forms.Label();
            this.lblCh1Voltage = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStartSerialComm = new System.Windows.Forms.ToolStripButton();
            this.lblCh2PowerDivider = new System.Windows.Forms.Label();
            this.lblCh2CurrentDivider = new System.Windows.Forms.Label();
            this.lblCh2PowerDividerLabel = new System.Windows.Forms.Label();
            this.lblCh2CurrentDividerLabel = new System.Windows.Forms.Label();
            this.lblCh2VoltageDivider = new System.Windows.Forms.Label();
            this.lblCh2VoltageDividerLabel = new System.Windows.Forms.Label();
            this.chkCh1Voltage = new System.Windows.Forms.CheckBox();
            this.chkCh1Current = new System.Windows.Forms.CheckBox();
            this.chkCh2Voltage = new System.Windows.Forms.CheckBox();
            this.chkCh2Current = new System.Windows.Forms.CheckBox();
            this.btnChartReset = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpLogOutput.SuspendLayout();
            this.grpSerialPortSettings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrentValues)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.grpParams.SuspendLayout();
            this.grpDashChannel2.SuspendLayout();
            this.grpDashChannel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtSerialMonitor);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(682, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Serial Monitor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtSerialMonitor
            // 
            this.txtSerialMonitor.Enabled = false;
            this.txtSerialMonitor.Location = new System.Drawing.Point(6, 6);
            this.txtSerialMonitor.Multiline = true;
            this.txtSerialMonitor.Name = "txtSerialMonitor";
            this.txtSerialMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSerialMonitor.Size = new System.Drawing.Size(670, 267);
            this.txtSerialMonitor.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpLogOutput);
            this.tabPage3.Controls.Add(this.grpSerialPortSettings);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(682, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpLogOutput
            // 
            this.grpLogOutput.Controls.Add(this.txtLogOutput);
            this.grpLogOutput.Location = new System.Drawing.Point(261, 7);
            this.grpLogOutput.Name = "grpLogOutput";
            this.grpLogOutput.Size = new System.Drawing.Size(415, 266);
            this.grpLogOutput.TabIndex = 2;
            this.grpLogOutput.TabStop = false;
            this.grpLogOutput.Text = "Log Output";
            // 
            // txtLogOutput
            // 
            this.txtLogOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogOutput.Location = new System.Drawing.Point(6, 19);
            this.txtLogOutput.Multiline = true;
            this.txtLogOutput.Name = "txtLogOutput";
            this.txtLogOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogOutput.Size = new System.Drawing.Size(403, 241);
            this.txtLogOutput.TabIndex = 1;
            // 
            // grpSerialPortSettings
            // 
            this.grpSerialPortSettings.Controls.Add(this.lblLastDataRcvd);
            this.grpSerialPortSettings.Controls.Add(this.lblLastDataRcvdLbl);
            this.grpSerialPortSettings.Controls.Add(this.btnDisconnect);
            this.grpSerialPortSettings.Controls.Add(this.btnConnect);
            this.grpSerialPortSettings.Controls.Add(this.lblStopBitsLbl);
            this.grpSerialPortSettings.Controls.Add(this.cmbStopBits);
            this.grpSerialPortSettings.Controls.Add(this.lblParitylbl);
            this.grpSerialPortSettings.Controls.Add(this.cmbParity);
            this.grpSerialPortSettings.Controls.Add(this.lblDataBitsLbl);
            this.grpSerialPortSettings.Controls.Add(this.cmbDataBits);
            this.grpSerialPortSettings.Controls.Add(this.lblBaudRateLbl);
            this.grpSerialPortSettings.Controls.Add(this.cmbBaudRate);
            this.grpSerialPortSettings.Controls.Add(this.lblPortNameLbl);
            this.grpSerialPortSettings.Controls.Add(this.cmbPortName);
            this.grpSerialPortSettings.Location = new System.Drawing.Point(6, 6);
            this.grpSerialPortSettings.Name = "grpSerialPortSettings";
            this.grpSerialPortSettings.Size = new System.Drawing.Size(248, 267);
            this.grpSerialPortSettings.TabIndex = 0;
            this.grpSerialPortSettings.TabStop = false;
            this.grpSerialPortSettings.Text = "Serial Port Settings";
            // 
            // lblLastDataRcvd
            // 
            this.lblLastDataRcvd.AutoSize = true;
            this.lblLastDataRcvd.Location = new System.Drawing.Point(8, 193);
            this.lblLastDataRcvd.Name = "lblLastDataRcvd";
            this.lblLastDataRcvd.Size = new System.Drawing.Size(63, 13);
            this.lblLastDataRcvd.TabIndex = 15;
            this.lblLastDataRcvd.Text = "<unknown>";
            // 
            // lblLastDataRcvdLbl
            // 
            this.lblLastDataRcvdLbl.AutoSize = true;
            this.lblLastDataRcvdLbl.Location = new System.Drawing.Point(8, 168);
            this.lblLastDataRcvdLbl.Name = "lblLastDataRcvdLbl";
            this.lblLastDataRcvdLbl.Size = new System.Drawing.Size(131, 13);
            this.lblLastDataRcvdLbl.TabIndex = 14;
            this.lblLastDataRcvdLbl.Text = "Last DataWord Received:";
            this.lblLastDataRcvdLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(155, 229);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(11, 229);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStopBitsLbl
            // 
            this.lblStopBitsLbl.AutoSize = true;
            this.lblStopBitsLbl.Location = new System.Drawing.Point(7, 138);
            this.lblStopBitsLbl.Name = "lblStopBitsLbl";
            this.lblStopBitsLbl.Size = new System.Drawing.Size(49, 13);
            this.lblStopBitsLbl.TabIndex = 9;
            this.lblStopBitsLbl.Text = "Stop Bits";
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbStopBits.Location = new System.Drawing.Point(100, 135);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cmbStopBits.TabIndex = 8;
            this.cmbStopBits.Text = "1";
            this.cmbStopBits.SelectedIndexChanged += new System.EventHandler(this.cmbStopBits_SelectedIndexChanged);
            // 
            // lblParitylbl
            // 
            this.lblParitylbl.AutoSize = true;
            this.lblParitylbl.Location = new System.Drawing.Point(7, 110);
            this.lblParitylbl.Name = "lblParitylbl";
            this.lblParitylbl.Size = new System.Drawing.Size(33, 13);
            this.lblParitylbl.TabIndex = 7;
            this.lblParitylbl.Text = "Parity";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(100, 107);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 21);
            this.cmbParity.TabIndex = 6;
            this.cmbParity.Text = "N";
            // 
            // lblDataBitsLbl
            // 
            this.lblDataBitsLbl.AutoSize = true;
            this.lblDataBitsLbl.Location = new System.Drawing.Point(7, 82);
            this.lblDataBitsLbl.Name = "lblDataBitsLbl";
            this.lblDataBitsLbl.Size = new System.Drawing.Size(50, 13);
            this.lblDataBitsLbl.TabIndex = 5;
            this.lblDataBitsLbl.Text = "Data Bits";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(100, 79);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cmbDataBits.TabIndex = 4;
            this.cmbDataBits.Text = "8";
            // 
            // lblBaudRateLbl
            // 
            this.lblBaudRateLbl.AutoSize = true;
            this.lblBaudRateLbl.Location = new System.Drawing.Point(7, 54);
            this.lblBaudRateLbl.Name = "lblBaudRateLbl";
            this.lblBaudRateLbl.Size = new System.Drawing.Size(58, 13);
            this.lblBaudRateLbl.TabIndex = 3;
            this.lblBaudRateLbl.Text = "Baud Rate";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(100, 51);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cmbBaudRate.TabIndex = 2;
            this.cmbBaudRate.Text = "57600";
            // 
            // lblPortNameLbl
            // 
            this.lblPortNameLbl.AutoSize = true;
            this.lblPortNameLbl.Location = new System.Drawing.Point(7, 26);
            this.lblPortNameLbl.Name = "lblPortNameLbl";
            this.lblPortNameLbl.Size = new System.Drawing.Size(57, 13);
            this.lblPortNameLbl.TabIndex = 1;
            this.lblPortNameLbl.Text = "Port Name";
            // 
            // cmbPortName
            // 
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(100, 23);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(121, 21);
            this.cmbPortName.TabIndex = 0;
            this.cmbPortName.Text = "COM3";
            this.cmbPortName.SelectedIndexChanged += new System.EventHandler(this.cmbPortName_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChartReset);
            this.tabPage2.Controls.Add(this.chkCh2Current);
            this.tabPage2.Controls.Add(this.chkCh2Voltage);
            this.tabPage2.Controls.Add(this.chkCh1Current);
            this.tabPage2.Controls.Add(this.chkCh1Voltage);
            this.tabPage2.Controls.Add(this.chartCurrentValues);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartCurrentValues
            // 
            chartArea3.Name = "ChartArea1";
            this.chartCurrentValues.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartCurrentValues.Legends.Add(legend3);
            this.chartCurrentValues.Location = new System.Drawing.Point(7, 35);
            this.chartCurrentValues.Name = "chartCurrentValues";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Ch1_Voltage";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Ch1_Current";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Ch2_Voltage";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Ch2_Current";
            this.chartCurrentValues.Series.Add(series9);
            this.chartCurrentValues.Series.Add(series10);
            this.chartCurrentValues.Series.Add(series11);
            this.chartCurrentValues.Series.Add(series12);
            this.chartCurrentValues.Size = new System.Drawing.Size(669, 238);
            this.chartCurrentValues.TabIndex = 0;
            this.chartCurrentValues.Text = "chart1";
            this.chartCurrentValues.Click += new System.EventHandler(this.chartCurrentValues_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpParams);
            this.tabPage1.Controls.Add(this.grpDashChannel2);
            this.tabPage1.Controls.Add(this.grpDashChannel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpParams
            // 
            this.grpParams.Controls.Add(this.lblCh2PowerDivider);
            this.grpParams.Controls.Add(this.lblCh2CurrentDivider);
            this.grpParams.Controls.Add(this.lblCh2PowerDividerLabel);
            this.grpParams.Controls.Add(this.lblCh2CurrentDividerLabel);
            this.grpParams.Controls.Add(this.lblCh2VoltageDivider);
            this.grpParams.Controls.Add(this.lblCh2VoltageDividerLabel);
            this.grpParams.Controls.Add(this.lblCh1PowerDivider);
            this.grpParams.Controls.Add(this.lblCh1CurrentDivider);
            this.grpParams.Controls.Add(this.lblCh1PowerDividerLabel);
            this.grpParams.Controls.Add(this.lblCh1CurrentDividerLabel);
            this.grpParams.Controls.Add(this.lblCh1VoltageDivider);
            this.grpParams.Controls.Add(this.lblCh1VoltageDividerLabel);
            this.grpParams.Location = new System.Drawing.Point(504, 7);
            this.grpParams.Name = "grpParams";
            this.grpParams.Size = new System.Drawing.Size(172, 266);
            this.grpParams.TabIndex = 2;
            this.grpParams.TabStop = false;
            this.grpParams.Text = "Parameters";
            // 
            // lblCh1PowerDivider
            // 
            this.lblCh1PowerDivider.AutoSize = true;
            this.lblCh1PowerDivider.Location = new System.Drawing.Point(101, 61);
            this.lblCh1PowerDivider.Name = "lblCh1PowerDivider";
            this.lblCh1PowerDivider.Size = new System.Drawing.Size(13, 13);
            this.lblCh1PowerDivider.TabIndex = 5;
            this.lblCh1PowerDivider.Text = "1";
            // 
            // lblCh1CurrentDivider
            // 
            this.lblCh1CurrentDivider.AutoSize = true;
            this.lblCh1CurrentDivider.Location = new System.Drawing.Point(101, 40);
            this.lblCh1CurrentDivider.Name = "lblCh1CurrentDivider";
            this.lblCh1CurrentDivider.Size = new System.Drawing.Size(13, 13);
            this.lblCh1CurrentDivider.TabIndex = 4;
            this.lblCh1CurrentDivider.Text = "1";
            // 
            // lblCh1PowerDividerLabel
            // 
            this.lblCh1PowerDividerLabel.AutoSize = true;
            this.lblCh1PowerDividerLabel.Location = new System.Drawing.Point(7, 61);
            this.lblCh1PowerDividerLabel.Name = "lblCh1PowerDividerLabel";
            this.lblCh1PowerDividerLabel.Size = new System.Drawing.Size(60, 13);
            this.lblCh1PowerDividerLabel.TabIndex = 3;
            this.lblCh1PowerDividerLabel.Text = "Ch1PwrDiv";
            // 
            // lblCh1CurrentDividerLabel
            // 
            this.lblCh1CurrentDividerLabel.AutoSize = true;
            this.lblCh1CurrentDividerLabel.Location = new System.Drawing.Point(7, 40);
            this.lblCh1CurrentDividerLabel.Name = "lblCh1CurrentDividerLabel";
            this.lblCh1CurrentDividerLabel.Size = new System.Drawing.Size(61, 13);
            this.lblCh1CurrentDividerLabel.TabIndex = 2;
            this.lblCh1CurrentDividerLabel.Text = "Ch1CurrDiv";
            // 
            // lblCh1VoltageDivider
            // 
            this.lblCh1VoltageDivider.AutoSize = true;
            this.lblCh1VoltageDivider.Location = new System.Drawing.Point(101, 20);
            this.lblCh1VoltageDivider.Name = "lblCh1VoltageDivider";
            this.lblCh1VoltageDivider.Size = new System.Drawing.Size(13, 13);
            this.lblCh1VoltageDivider.TabIndex = 1;
            this.lblCh1VoltageDivider.Text = "1";
            // 
            // lblCh1VoltageDividerLabel
            // 
            this.lblCh1VoltageDividerLabel.AutoSize = true;
            this.lblCh1VoltageDividerLabel.Location = new System.Drawing.Point(7, 20);
            this.lblCh1VoltageDividerLabel.Name = "lblCh1VoltageDividerLabel";
            this.lblCh1VoltageDividerLabel.Size = new System.Drawing.Size(60, 13);
            this.lblCh1VoltageDividerLabel.TabIndex = 0;
            this.lblCh1VoltageDividerLabel.Text = "Ch1VoltDiv";
            // 
            // grpDashChannel2
            // 
            this.grpDashChannel2.Controls.Add(this.lblCh2PowerLabel);
            this.grpDashChannel2.Controls.Add(this.lblCh2Power);
            this.grpDashChannel2.Controls.Add(this.lblCh2CurrentLabel);
            this.grpDashChannel2.Controls.Add(this.lblCh2Current);
            this.grpDashChannel2.Controls.Add(this.lblCh2VoltageLabel);
            this.grpDashChannel2.Controls.Add(this.lblCh2Voltage);
            this.grpDashChannel2.Location = new System.Drawing.Point(255, 7);
            this.grpDashChannel2.Name = "grpDashChannel2";
            this.grpDashChannel2.Size = new System.Drawing.Size(242, 266);
            this.grpDashChannel2.TabIndex = 1;
            this.grpDashChannel2.TabStop = false;
            this.grpDashChannel2.Text = "Channel 2";
            // 
            // lblCh2PowerLabel
            // 
            this.lblCh2PowerLabel.AutoSize = true;
            this.lblCh2PowerLabel.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh2PowerLabel.Location = new System.Drawing.Point(192, 113);
            this.lblCh2PowerLabel.Name = "lblCh2PowerLabel";
            this.lblCh2PowerLabel.Size = new System.Drawing.Size(35, 32);
            this.lblCh2PowerLabel.TabIndex = 11;
            this.lblCh2PowerLabel.Text = "W";
            // 
            // lblCh2Power
            // 
            this.lblCh2Power.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh2Power.Location = new System.Drawing.Point(12, 113);
            this.lblCh2Power.Name = "lblCh2Power";
            this.lblCh2Power.Size = new System.Drawing.Size(175, 33);
            this.lblCh2Power.TabIndex = 10;
            this.lblCh2Power.Text = "N/A";
            this.lblCh2Power.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCh2CurrentLabel
            // 
            this.lblCh2CurrentLabel.AutoSize = true;
            this.lblCh2CurrentLabel.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh2CurrentLabel.Location = new System.Drawing.Point(192, 68);
            this.lblCh2CurrentLabel.Name = "lblCh2CurrentLabel";
            this.lblCh2CurrentLabel.Size = new System.Drawing.Size(35, 32);
            this.lblCh2CurrentLabel.TabIndex = 9;
            this.lblCh2CurrentLabel.Text = "A";
            this.lblCh2CurrentLabel.Click += new System.EventHandler(this.lblCh2CurrentLabel_Click);
            // 
            // lblCh2Current
            // 
            this.lblCh2Current.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh2Current.Location = new System.Drawing.Point(12, 68);
            this.lblCh2Current.Name = "lblCh2Current";
            this.lblCh2Current.Size = new System.Drawing.Size(175, 33);
            this.lblCh2Current.TabIndex = 8;
            this.lblCh2Current.Text = "N/A";
            this.lblCh2Current.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCh2VoltageLabel
            // 
            this.lblCh2VoltageLabel.AutoSize = true;
            this.lblCh2VoltageLabel.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh2VoltageLabel.Location = new System.Drawing.Point(192, 23);
            this.lblCh2VoltageLabel.Name = "lblCh2VoltageLabel";
            this.lblCh2VoltageLabel.Size = new System.Drawing.Size(35, 32);
            this.lblCh2VoltageLabel.TabIndex = 7;
            this.lblCh2VoltageLabel.Text = "V";
            this.lblCh2VoltageLabel.Click += new System.EventHandler(this.lblCh2VoltageLabel_Click);
            // 
            // lblCh2Voltage
            // 
            this.lblCh2Voltage.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh2Voltage.Location = new System.Drawing.Point(12, 24);
            this.lblCh2Voltage.Name = "lblCh2Voltage";
            this.lblCh2Voltage.Size = new System.Drawing.Size(175, 33);
            this.lblCh2Voltage.TabIndex = 6;
            this.lblCh2Voltage.Text = "N/A";
            this.lblCh2Voltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpDashChannel1
            // 
            this.grpDashChannel1.Controls.Add(this.lblCh1PowerLabel);
            this.grpDashChannel1.Controls.Add(this.lblCh1Power);
            this.grpDashChannel1.Controls.Add(this.lblCh1CurrentLabel);
            this.grpDashChannel1.Controls.Add(this.lblCh1Current);
            this.grpDashChannel1.Controls.Add(this.lblCh1VoltageLabel);
            this.grpDashChannel1.Controls.Add(this.lblCh1Voltage);
            this.grpDashChannel1.Location = new System.Drawing.Point(7, 7);
            this.grpDashChannel1.Name = "grpDashChannel1";
            this.grpDashChannel1.Size = new System.Drawing.Size(242, 266);
            this.grpDashChannel1.TabIndex = 0;
            this.grpDashChannel1.TabStop = false;
            this.grpDashChannel1.Text = "Channel 1";
            // 
            // lblCh1PowerLabel
            // 
            this.lblCh1PowerLabel.AutoSize = true;
            this.lblCh1PowerLabel.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh1PowerLabel.Location = new System.Drawing.Point(186, 116);
            this.lblCh1PowerLabel.Name = "lblCh1PowerLabel";
            this.lblCh1PowerLabel.Size = new System.Drawing.Size(35, 32);
            this.lblCh1PowerLabel.TabIndex = 5;
            this.lblCh1PowerLabel.Text = "W";
            // 
            // lblCh1Power
            // 
            this.lblCh1Power.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh1Power.Location = new System.Drawing.Point(6, 116);
            this.lblCh1Power.Name = "lblCh1Power";
            this.lblCh1Power.Size = new System.Drawing.Size(175, 33);
            this.lblCh1Power.TabIndex = 4;
            this.lblCh1Power.Text = "N/A";
            this.lblCh1Power.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCh1Power.Click += new System.EventHandler(this.lblCh1Power_Click);
            // 
            // lblCh1CurrentLabel
            // 
            this.lblCh1CurrentLabel.AutoSize = true;
            this.lblCh1CurrentLabel.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh1CurrentLabel.Location = new System.Drawing.Point(186, 71);
            this.lblCh1CurrentLabel.Name = "lblCh1CurrentLabel";
            this.lblCh1CurrentLabel.Size = new System.Drawing.Size(35, 32);
            this.lblCh1CurrentLabel.TabIndex = 3;
            this.lblCh1CurrentLabel.Text = "A";
            // 
            // lblCh1Current
            // 
            this.lblCh1Current.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh1Current.Location = new System.Drawing.Point(6, 71);
            this.lblCh1Current.Name = "lblCh1Current";
            this.lblCh1Current.Size = new System.Drawing.Size(175, 33);
            this.lblCh1Current.TabIndex = 2;
            this.lblCh1Current.Text = "N/A";
            this.lblCh1Current.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCh1VoltageLabel
            // 
            this.lblCh1VoltageLabel.AutoSize = true;
            this.lblCh1VoltageLabel.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh1VoltageLabel.Location = new System.Drawing.Point(186, 26);
            this.lblCh1VoltageLabel.Name = "lblCh1VoltageLabel";
            this.lblCh1VoltageLabel.Size = new System.Drawing.Size(35, 32);
            this.lblCh1VoltageLabel.TabIndex = 1;
            this.lblCh1VoltageLabel.Text = "V";
            this.lblCh1VoltageLabel.Click += new System.EventHandler(this.lblCh1VoltageLabel_Click);
            // 
            // lblCh1Voltage
            // 
            this.lblCh1Voltage.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCh1Voltage.Location = new System.Drawing.Point(6, 26);
            this.lblCh1Voltage.Name = "lblCh1Voltage";
            this.lblCh1Voltage.Size = new System.Drawing.Size(175, 33);
            this.lblCh1Voltage.TabIndex = 0;
            this.lblCh1Voltage.Text = "N/A";
            this.lblCh1Voltage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(5, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 337);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusText
            // 
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(89, 17);
            this.lblStatusText.Text = "SerialPortStatus";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStartSerialComm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "ToolBar";
            // 
            // btnStartSerialComm
            // 
            this.btnStartSerialComm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartSerialComm.Image = ((System.Drawing.Image)(resources.GetObject("btnStartSerialComm.Image")));
            this.btnStartSerialComm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartSerialComm.Name = "btnStartSerialComm";
            this.btnStartSerialComm.Size = new System.Drawing.Size(23, 22);
            this.btnStartSerialComm.Text = "Serial Connect";
            this.btnStartSerialComm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartSerialComm.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblCh2PowerDivider
            // 
            this.lblCh2PowerDivider.AutoSize = true;
            this.lblCh2PowerDivider.Location = new System.Drawing.Point(101, 123);
            this.lblCh2PowerDivider.Name = "lblCh2PowerDivider";
            this.lblCh2PowerDivider.Size = new System.Drawing.Size(13, 13);
            this.lblCh2PowerDivider.TabIndex = 11;
            this.lblCh2PowerDivider.Text = "1";
            // 
            // lblCh2CurrentDivider
            // 
            this.lblCh2CurrentDivider.AutoSize = true;
            this.lblCh2CurrentDivider.Location = new System.Drawing.Point(101, 102);
            this.lblCh2CurrentDivider.Name = "lblCh2CurrentDivider";
            this.lblCh2CurrentDivider.Size = new System.Drawing.Size(13, 13);
            this.lblCh2CurrentDivider.TabIndex = 10;
            this.lblCh2CurrentDivider.Text = "1";
            // 
            // lblCh2PowerDividerLabel
            // 
            this.lblCh2PowerDividerLabel.AutoSize = true;
            this.lblCh2PowerDividerLabel.Location = new System.Drawing.Point(7, 123);
            this.lblCh2PowerDividerLabel.Name = "lblCh2PowerDividerLabel";
            this.lblCh2PowerDividerLabel.Size = new System.Drawing.Size(60, 13);
            this.lblCh2PowerDividerLabel.TabIndex = 9;
            this.lblCh2PowerDividerLabel.Text = "Ch2PwrDiv";
            // 
            // lblCh2CurrentDividerLabel
            // 
            this.lblCh2CurrentDividerLabel.AutoSize = true;
            this.lblCh2CurrentDividerLabel.Location = new System.Drawing.Point(7, 102);
            this.lblCh2CurrentDividerLabel.Name = "lblCh2CurrentDividerLabel";
            this.lblCh2CurrentDividerLabel.Size = new System.Drawing.Size(61, 13);
            this.lblCh2CurrentDividerLabel.TabIndex = 8;
            this.lblCh2CurrentDividerLabel.Text = "Ch2CurrDiv";
            // 
            // lblCh2VoltageDivider
            // 
            this.lblCh2VoltageDivider.AutoSize = true;
            this.lblCh2VoltageDivider.Location = new System.Drawing.Point(101, 82);
            this.lblCh2VoltageDivider.Name = "lblCh2VoltageDivider";
            this.lblCh2VoltageDivider.Size = new System.Drawing.Size(13, 13);
            this.lblCh2VoltageDivider.TabIndex = 7;
            this.lblCh2VoltageDivider.Text = "1";
            // 
            // lblCh2VoltageDividerLabel
            // 
            this.lblCh2VoltageDividerLabel.AutoSize = true;
            this.lblCh2VoltageDividerLabel.Location = new System.Drawing.Point(7, 82);
            this.lblCh2VoltageDividerLabel.Name = "lblCh2VoltageDividerLabel";
            this.lblCh2VoltageDividerLabel.Size = new System.Drawing.Size(60, 13);
            this.lblCh2VoltageDividerLabel.TabIndex = 6;
            this.lblCh2VoltageDividerLabel.Text = "Ch2VoltDiv";
            // 
            // chkCh1Voltage
            // 
            this.chkCh1Voltage.AutoSize = true;
            this.chkCh1Voltage.Checked = true;
            this.chkCh1Voltage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCh1Voltage.Location = new System.Drawing.Point(77, 12);
            this.chkCh1Voltage.Name = "chkCh1Voltage";
            this.chkCh1Voltage.Size = new System.Drawing.Size(92, 17);
            this.chkCh1Voltage.TabIndex = 1;
            this.chkCh1Voltage.Text = "CH1 - Voltage";
            this.chkCh1Voltage.UseVisualStyleBackColor = true;
            this.chkCh1Voltage.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkCh1Current
            // 
            this.chkCh1Current.AutoSize = true;
            this.chkCh1Current.Checked = true;
            this.chkCh1Current.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCh1Current.Location = new System.Drawing.Point(175, 12);
            this.chkCh1Current.Name = "chkCh1Current";
            this.chkCh1Current.Size = new System.Drawing.Size(90, 17);
            this.chkCh1Current.TabIndex = 2;
            this.chkCh1Current.Text = "CH1 - Current";
            this.chkCh1Current.UseVisualStyleBackColor = true;
            this.chkCh1Current.CheckedChanged += new System.EventHandler(this.chkCh1Current_CheckedChanged);
            // 
            // chkCh2Voltage
            // 
            this.chkCh2Voltage.AutoSize = true;
            this.chkCh2Voltage.Checked = true;
            this.chkCh2Voltage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCh2Voltage.Location = new System.Drawing.Point(271, 12);
            this.chkCh2Voltage.Name = "chkCh2Voltage";
            this.chkCh2Voltage.Size = new System.Drawing.Size(92, 17);
            this.chkCh2Voltage.TabIndex = 3;
            this.chkCh2Voltage.Text = "CH2 - Voltage";
            this.chkCh2Voltage.UseVisualStyleBackColor = true;
            this.chkCh2Voltage.CheckedChanged += new System.EventHandler(this.chkCh2Voltage_CheckedChanged);
            // 
            // chkCh2Current
            // 
            this.chkCh2Current.AutoSize = true;
            this.chkCh2Current.Checked = true;
            this.chkCh2Current.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCh2Current.Location = new System.Drawing.Point(369, 12);
            this.chkCh2Current.Name = "chkCh2Current";
            this.chkCh2Current.Size = new System.Drawing.Size(90, 17);
            this.chkCh2Current.TabIndex = 4;
            this.chkCh2Current.Text = "CH2 - Current";
            this.chkCh2Current.UseVisualStyleBackColor = true;
            this.chkCh2Current.CheckedChanged += new System.EventHandler(this.chkCh2Current_CheckedChanged);
            // 
            // btnChartReset
            // 
            this.btnChartReset.Location = new System.Drawing.Point(559, 8);
            this.btnChartReset.Name = "btnChartReset";
            this.btnChartReset.Size = new System.Drawing.Size(75, 23);
            this.btnChartReset.TabIndex = 5;
            this.btnChartReset.Text = "Reset Chart";
            this.btnChartReset.UseVisualStyleBackColor = true;
            this.btnChartReset.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 359);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PSUMonitor";
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grpLogOutput.ResumeLayout(false);
            this.grpLogOutput.PerformLayout();
            this.grpSerialPortSettings.ResumeLayout(false);
            this.grpSerialPortSettings.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrentValues)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.grpParams.ResumeLayout(false);
            this.grpParams.PerformLayout();
            this.grpDashChannel2.ResumeLayout(false);
            this.grpDashChannel2.PerformLayout();
            this.grpDashChannel1.ResumeLayout(false);
            this.grpDashChannel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpSerialPortSettings;
        private System.Windows.Forms.Label lblDataBitsLbl;
        private System.Windows.Forms.Label lblBaudRateLbl;
        private System.Windows.Forms.Label lblPortNameLbl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpDashChannel2;
        private System.Windows.Forms.GroupBox grpDashChannel1;
        private System.Windows.Forms.Label lblCh1PowerLabel;
        private System.Windows.Forms.Label lblCh1Power;
        private System.Windows.Forms.Label lblCh1CurrentLabel;
        private System.Windows.Forms.Label lblCh1Current;
        private System.Windows.Forms.Label lblCh1VoltageLabel;
        private System.Windows.Forms.Label lblCh1Voltage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStopBitsLbl;
        private System.Windows.Forms.Label lblParitylbl;
        private System.Windows.Forms.TextBox txtLogOutput;
        private System.Windows.Forms.GroupBox grpLogOutput;
        private System.Windows.Forms.GroupBox grpParams;
        private System.Windows.Forms.Label lblCh1PowerDivider;
        private System.Windows.Forms.Label lblCh1CurrentDivider;
        private System.Windows.Forms.Label lblCh1PowerDividerLabel;
        private System.Windows.Forms.Label lblCh1CurrentDividerLabel;
        private System.Windows.Forms.Label lblCh1VoltageDivider;
        private System.Windows.Forms.Label lblCh1VoltageDividerLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurrentValues;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.TextBox txtSerialMonitor;
        public System.Windows.Forms.ToolStripStatusLabel lblStatusText;

        public void AddSerialMonitorRow(string row)
        {
            txtSerialMonitor.Text += row;
            txtSerialMonitor.Text += "\r\n";
        }

        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        public System.Windows.Forms.ComboBox cmbStopBits;
        public System.Windows.Forms.ComboBox cmbParity;
        public System.Windows.Forms.ComboBox cmbDataBits;
        public System.Windows.Forms.ComboBox cmbBaudRate;
        public System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label lblLastDataRcvdLbl;
        public System.Windows.Forms.Label lblLastDataRcvd;
        private System.Windows.Forms.Label lblCh2PowerLabel;
        private System.Windows.Forms.Label lblCh2Power;
        private System.Windows.Forms.Label lblCh2CurrentLabel;
        private System.Windows.Forms.Label lblCh2Current;
        private System.Windows.Forms.Label lblCh2VoltageLabel;
        private System.Windows.Forms.Label lblCh2Voltage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStartSerialComm;
        private System.Windows.Forms.Label lblCh2PowerDivider;
        private System.Windows.Forms.Label lblCh2CurrentDivider;
        private System.Windows.Forms.Label lblCh2PowerDividerLabel;
        private System.Windows.Forms.Label lblCh2CurrentDividerLabel;
        private System.Windows.Forms.Label lblCh2VoltageDivider;
        private System.Windows.Forms.Label lblCh2VoltageDividerLabel;
        private System.Windows.Forms.CheckBox chkCh1Voltage;
        private System.Windows.Forms.CheckBox chkCh2Current;
        private System.Windows.Forms.CheckBox chkCh2Voltage;
        private System.Windows.Forms.CheckBox chkCh1Current;
        private System.Windows.Forms.Button btnChartReset;
    }
}

