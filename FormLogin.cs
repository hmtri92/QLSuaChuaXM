using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Xml;
using System.Threading;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace DeTai
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        int dem = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        protected internal void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SCXMdbDataContext db = new SCXMdbDataContext();
                String username = txtUserName.Text;

                EncriptMD5 encripter = new EncriptMD5();
                String pass = encripter.encript(txtPassWord.Text);
                Program.user = null;

                try
                {
                    Program.user = db.TaiKhoans.Single(u => u.UserName == username && u.TrangThai == true);
                }
                catch (InvalidOperationException ex)
                {
                    warnning();
                    return;
                }


                if (Program.user.Password != pass)
                {
                    warnning();
                    return;
                }

                if (Program.user.MaQuyen == "qadmin")
                {
                    Program.thread_Admin.SetApartmentState(ApartmentState.STA);
                    Program.thread_Admin.Start();
                    this.Close();
                }

                if (Program.user.MaQuyen == "qkho")
                {
                    Program.thread_Kho.SetApartmentState(ApartmentState.STA);
                    Program.thread_Kho.Start();
                    this.Close();
                }

                if (Program.user.MaQuyen == "qketoan")
                {
                    Program.thread_KeToan.SetApartmentState(ApartmentState.STA);
                    Program.thread_KeToan.Start();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        void warnning()
        {
            dem++;

            if (dem >= 5)
            {
                Application.Exit();
            }
            else
            {
                String mess = "Số lần đăng nhập còn lại " + (5 - dem);
                lblMessage.Text = mess;
                lblMessage.Visible = true;
            }


            txtUserName.BackColor = Color.Gold;
            txtPassWord.BackColor = Color.Gold;
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = Color.White;
            txtPassWord.BackColor = Color.White;
        }
    }
}