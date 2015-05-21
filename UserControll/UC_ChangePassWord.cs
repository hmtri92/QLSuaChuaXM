using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeTai
{
    public partial class UC_ChangePassWord : UserControl, IController
    {
        public UC_ChangePassWord()
        {
            InitializeComponent();
        }

        private void UC_ChangePassWord_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Program.user.UserName;
        }

        int dem = 0;

        public void save()
        {
            try
            {
                if (!CheckData())
                    return;
                SCXMdbDataContext db = new SCXMdbDataContext();
                TaiKhoan taikhoan = db.TaiKhoans.Single(p => p.UserName == Program.user.UserName);

                EncriptMD5 md5 = new EncriptMD5();
                if (md5.encript(txtOldPass.Text) != taikhoan.Password)
                {
                    MessageBox.Show("Mật khẩu sai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dem++;

                    if (dem >= 5)
                        Application.Exit();
                    return;
                }

                if (txtPass.Text != txtrePass.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp", "Error", MessageBoxButtons.OK);
                    txtPass.ResetText();
                    txtrePass.ResetText();
                    return;
                }

                taikhoan.Password = md5.encript(txtPass.Text);
                db.SubmitChanges();
                Dispose();
                MessageBox.Show("Success", "Message", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            { }
        }

        public void load()
        {

        }

        public void Dispose()
        {
            txtOldPass.ResetText();
            txtPass.ResetText();
            txtrePass.ResetText();
        }

        private bool CheckData()
        {
            bool result = true;
            Check check = new Check();

            result = check.checkEmpty(txtOldPass) && result;
            result = check.checkEmpty(txtPass) && result;
            result = check.checkEmpty(txtrePass) && result;

            return result;
        }

        private void textbox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void txtrePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                save();
        }
    }
}
