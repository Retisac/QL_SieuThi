using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QL_SieuThi
{
    static class Program
    {
        public static bool OpenDetailFormOnClose { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            OpenDetailFormOnClose = false;

            Application.Run(new frmDangNhap());

            if (OpenDetailFormOnClose)
            {
                Application.Run(new frmMain());
            }
            //Application.Run(new frmMain());
        }
    }
}
