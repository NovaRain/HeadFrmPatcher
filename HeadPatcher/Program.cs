using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HeadsPatcher
{
    static class Program
    {
        /// <summary>
        /// Main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HeadsFrmPatcher());
        }
    }
}
