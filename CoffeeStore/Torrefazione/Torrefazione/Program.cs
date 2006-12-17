using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Torrefazione
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Db.initialize();
            SilosContainer.Init();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Db.Close();
        }
    }
}