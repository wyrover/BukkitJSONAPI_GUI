﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BukkitJSONAPI_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( string[] _Args )
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(_Args));
        }
    }
}
