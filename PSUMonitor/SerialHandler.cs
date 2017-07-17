using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.ComponentModel;


namespace PSUMonitor
{


    public class SerialHandler {
        public static void StartSerial()
        {

            MessageBox.Show("test!");
                    
        }

        public static void GenerateBuzz()
        {
            var form = Form.ActiveForm as Form1;
            BackgroundWorker bw = new BackgroundWorker();

            bw.WorkerReportsProgress = true;

            // what to do in the background thread
            bw.DoWork += new DoWorkEventHandler(
            delegate (object o, DoWorkEventArgs args)
            {
                BackgroundWorker b = o as BackgroundWorker;

                // do some simple processing for 10 seconds
                for (int i = 1; i <= 10; i++)
                {
                    // report the progress in percent
                    b.ReportProgress(i * 10);
                    Thread.Sleep(1000);
                }

            });

            // what to do when progress changed (update the progress bar for example)
            bw.ProgressChanged += new ProgressChangedEventHandler(
            delegate (object o, ProgressChangedEventArgs args)
            {
                form.lblStatusText.Text = string.Format("{0}% Completed", args.ProgressPercentage);
                form.AddSerialMonitorRow("xxx");
            });

            // what to do when worker completes its task (notify the user)
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(
            delegate (object o, RunWorkerCompletedEventArgs args)
            {
                form.lblStatusText.Text = "Finished!";
            });

            bw.RunWorkerAsync();
        }  
    }
}