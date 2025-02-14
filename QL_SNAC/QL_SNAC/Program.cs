using QL_SNAC.Login;
using QL_SNAC.MainForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SNAC
{
    internal static class Program
    {
    
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmLogin());
            Application.EnableVisualStyles();

            frmLogin loginForm = new frmLogin();
            if (loginForm.ShowDialog() == DialogResult.OK) // Use ShowDialog()
            {
                string tenDayDu = CauHinhHeThong.TenDayDu; // Access from CauHinhHeThong

                Application.Run(new frmMain(tenDayDu)); // Run with frmMain
            }
        }
    }
}