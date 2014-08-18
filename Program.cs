using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TierTypeTallier.Properties;
using TierTypeTallier.Views;

namespace TierTypeTallier
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += delegate { Settings.Default.Save(); };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
