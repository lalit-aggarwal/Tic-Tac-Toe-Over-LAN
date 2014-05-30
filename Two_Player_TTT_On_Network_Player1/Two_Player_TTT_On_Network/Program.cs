using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Two_Player_TTT_On_Network
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Player1());
        }
    }
}
