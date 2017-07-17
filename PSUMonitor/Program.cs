using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;



namespace PSUMonitor
{
    public class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
