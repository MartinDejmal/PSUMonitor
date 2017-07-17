using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSUMonitor.Serial;



namespace PSUMonitor
{
    public partial class Form1 : Form
    {
        public double Ch1Voltage = 0;
        public double Ch1Current = 0;
        public int Ch1VoltageDivider = 1;
        public int Ch1CurrentDivider = 1;
        public int Ch1PowerDivider = 1;

        public double Ch2Voltage = 0;
        public double Ch2Current = 0;
        public int Ch2VoltageDivider = 1;
        public int Ch2CurrentDivider = 1;
        public int Ch2PowerDivider = 1;

        public int millis = 0;

        public string buffer = "";
        public string dataWord = "";

        SerialPortManager _spManager;

        public Form1()
        {
            InitializeComponent();
            UserInitialization();
        }

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            cmbPortName.DataSource = mySerialSettings.PortNameCollection;
            cmbBaudRate.DataSource = mySerialSettings.BaudRateCollection;
            cmbDataBits.DataSource = mySerialSettings.DataBitsCollection;
            cmbParity.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            cmbStopBits.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            

            //lblCh1Current.Text = Convert.ToString(Ch1Voltage / Ch1VoltageDivider);
            //lblCh1Voltage.Text = Convert.ToString(Ch1Current);

        }

        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {


            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

            buffer += Encoding.ASCII.GetString(e.Data);

            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer.IndexOf("<") > 0) buffer = buffer.Substring(buffer.IndexOf("<"), buffer.Length - buffer.IndexOf("<"));
                if (buffer.IndexOf(">") < buffer.Length && buffer.IndexOf(">") > 0) buffer = buffer.Substring(0, buffer.IndexOf(">") + 1);
                if (buffer.IndexOf("<") == 0 && buffer.IndexOf(">") == buffer.Length - 1)
                {
                    dataWord = buffer;
                    ProcessDataWord(dataWord);
                    buffer = "";
                }

            }


            int maxTextLength = 1000; // maximum text length in text box
            if (txtSerialMonitor.TextLength > maxTextLength)
                txtSerialMonitor.Text = txtSerialMonitor.Text.Remove(0, txtSerialMonitor.TextLength - maxTextLength);

            // This application is connected to a GPS sending ASCCI characters, so data is converted to text
            string str = Encoding.ASCII.GetString(e.Data);

            lblLastDataRcvd.Text = dataWord;

            txtSerialMonitor.AppendText(str);
            txtSerialMonitor.ScrollToCaret();

        }

        private void ProcessDataWord(string DataWord)
        {
            string dw = DataWord.Substring(1, DataWord.Length - 2);
            txtLogOutput.Text = dw + "\r\n" + txtLogOutput.Text;
            dw = dw.Replace(".", ",");
            string[] values = dw.Split(';');
            try
            {
                Ch1Voltage = Convert.ToDouble(values[0]);
                Ch1Current = Convert.ToDouble(values[1]);
                Ch2Voltage = Convert.ToDouble(values[2]);
                Ch2Current = Convert.ToDouble(values[3]);
                millis = Convert.ToInt16(values[4]);

                DisplayCurrentValues();
            }
            catch (Exception)
            {
                txtLogOutput.Text = "Conversion exception!\r\n" + txtLogOutput.Text;
            }
        }

        private void DisplayCurrentValues()
        {
            lblCh1Current.Text = string.Format("{0:f3}", Ch1Current*Ch1CurrentDivider);
            lblCh1Voltage.Text = string.Format("{0:f3}", Ch1Voltage*Ch1VoltageDivider);
            lblCh1Power.Text = string.Format("{0:f3}", Ch1Voltage*Ch1Current*Ch1PowerDivider);

            lblCh2Current.Text = string.Format("{0:f3}", Ch2Current*Ch2CurrentDivider);
            lblCh2Voltage.Text = string.Format("{0:f3}", Ch2Voltage*Ch2VoltageDivider);
            lblCh2Power.Text = string.Format("{0:f3}", Ch2Voltage*Ch2Current*Ch2PowerDivider);

            chartCurrentValues.Series["Ch1_Voltage"].Points.AddXY(millis, Ch1Voltage);
            chartCurrentValues.Series["Ch1_Current"].Points.AddXY(millis, Ch1Current);
            
            chartCurrentValues.Series["Ch2_Voltage"].Points.AddXY(millis, Ch2Voltage);
            chartCurrentValues.Series["Ch2_Current"].Points.AddXY(millis, Ch2Current);

            

        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblStatusText.Text = "Running";
            lblStatusText.ForeColor = System.Drawing.Color.Green;
            txtLogOutput.Text += "Connecting...\r\n";
            //SerialHandler.StartSerial();
            _spManager.StartListening();
            
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            lblStatusText.Text = "Stopped";
            lblStatusText.ForeColor = System.Drawing.Color.Red;
            txtLogOutput.Text += "Disonnecting...\r\n" ;
            _spManager.StopListening();
        }

        private void lblCh1VoltageLabel_Click(object sender, EventArgs e)
        {
            if (lblCh1VoltageLabel.Text == "V")
            {
                lblCh1VoltageLabel.Text = "mV";
                Ch1VoltageDivider = 1000;
                lblCh1VoltageDivider.Text = Convert.ToString(Ch1VoltageDivider);
            }
            else
            {
                lblCh1VoltageLabel.Text = "V";
                Ch1VoltageDivider = 1;
                lblCh1VoltageDivider.Text = Convert.ToString(Ch1VoltageDivider);
            }

        }

        private void lblCh1Power_Click(object sender, EventArgs e)
        {
            lblCh1Voltage.Text = Convert.ToString(Int32.Parse(lblCh1Current.Text) * Int32.Parse(lblCh1Voltage.Text));
        }

        private void cmbPortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._spManager.CurrentSerialSettings.PortName = this.cmbPortName.Text;
        }

        private void Form1_FormClosing (object sender, EventArgs e)
        {

        }

        private void cmbStopBits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            lblStatusText.Text = "Running";
            lblStatusText.ForeColor = System.Drawing.Color.Green;
            _spManager.StartListening();
        }

        private void lblCh2VoltageLabel_Click(object sender, EventArgs e)
        {
            if (lblCh2VoltageLabel.Text == "V")
            {
                lblCh2VoltageLabel.Text = "mV";
                Ch2VoltageDivider = 1000;
                lblCh2VoltageDivider.Text = Convert.ToString(Ch2VoltageDivider);
            }
            else
            {
                lblCh2VoltageLabel.Text = "V";
                Ch2VoltageDivider = 1;
                lblCh2VoltageDivider.Text = Convert.ToString(Ch2VoltageDivider);
            }
        }

        private void lblCh2CurrentLabel_Click(object sender, EventArgs e)
        {
            if (lblCh2CurrentLabel.Text == "A")
            {
                lblCh2CurrentLabel.Text = "mA";
                Ch2CurrentDivider = 1000;
                lblCh2CurrentDivider.Text = Convert.ToString(Ch2CurrentDivider);
            }
            else
            {
                lblCh2CurrentLabel.Text = "A";
                Ch2CurrentDivider = 1;
                lblCh2CurrentDivider.Text = Convert.ToString(Ch2CurrentDivider);
            }
        }

        private void chartCurrentValues_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chartCurrentValues.Series["Ch1_Voltage"].Enabled = chkCh1Voltage.Checked;

        }

        private void chkCh1Current_CheckedChanged(object sender, EventArgs e)
        {
            chartCurrentValues.Series["Ch1_Current"].Enabled = chkCh1Current.Checked;
        }

        private void chkCh2Voltage_CheckedChanged(object sender, EventArgs e)
        {
            chartCurrentValues.Series["Ch2_Voltage"].Enabled = chkCh2Voltage.Checked;
        }

        private void chkCh2Current_CheckedChanged(object sender, EventArgs e)
        {
            chartCurrentValues.Series["Ch2_Current"].Enabled = chkCh2Current.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartCurrentValues.Series["Ch1_Voltage"].Points.Clear();
            chartCurrentValues.Series["Ch1_Current"].Points.Clear();
            chartCurrentValues.Series["Ch2_Voltage"].Points.Clear();
            chartCurrentValues.Series["Ch2_Current"].Points.Clear();
            
        }
    }
}
