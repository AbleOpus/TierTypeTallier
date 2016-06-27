using System;
using System.Windows.Forms;
using TierTypeTallier.Forms;
using TierTypeTallier.Properties;

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
