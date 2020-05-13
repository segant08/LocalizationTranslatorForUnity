using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LocalizationTranslatorForUnity
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public delegate void SafeCallDelegate( string text);       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
