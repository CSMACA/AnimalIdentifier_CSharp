using System;
using System.Windows.Forms;

namespace AnimalIdentifier_GUI
{
    public static class ProgramGui
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
