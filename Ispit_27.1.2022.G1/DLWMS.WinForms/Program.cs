
using DLWMS.WinForms.IB190031;
using System;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form stratnaForma = new frmStudentiPredmetiIB190031();
            Application.Run(stratnaForma);
        }
    }
}
