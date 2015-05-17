using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Threading;

namespace DeTai
{
    static class Program
    {
        public static TaiKhoan user;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //initApp();

            thread_login = new Thread(new ThreadStart(openLogin));
            //thread_Admin = new Thread(new ThreadStart(openAddmin));
            //thread_KeToan = new Thread(new ThreadStart(openKeToan));
            //thread_Kho = new Thread(new ThreadStart(openKho));

            //Application.Run(new FormTaoMa());
            thread_login.Start();
        }

        static void initApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
        }

        public static void openLogin()
        {
            initApp();
            Application.Run(new FormLogin());

        }

        public static void openAddmin()
        {
            initApp();
            Application.Run(new FormAddmin());

        }

        public static void openKeToan()
        {
            initApp();
            Application.Run(new FormKeToan());
        }

        public static void openKho()
        {
            initApp();
            Application.Run(new FormKho());
        }

        public static Thread thread_login;
        public static Thread thread_Admin;
        public static Thread thread_KeToan;
        public static Thread thread_Kho;
    }
}