using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DeTai
{
    public partial class UC_TaiKhoan : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        TaiKhoan taikhoan;
        bool f_update = false;

        public UC_TaiKhoan()
        {
            InitializeComponent();
        }

        public UC_TaiKhoan(string id)
        {
            InitializeComponent();
            taikhoan = db.TaiKhoans.Single(p => p.UserName == id);
            f_update = true;
        }

        private void UC_TaiKhoan_Load(object sender, EventArgs e)
        {
            var quyens = from p in db.QuyenTruyCaps
                         where p.deleted == false
                         select p;
            quyenTruyCapBindingSource.DataSource = quyens;
            if (f_update)
                load();
        }

        public void load() 
        {
            txtUserName.Text = taikhoan.UserName;
            txtUserName.Enabled = false;

            if (taikhoan.MaQuyen != null)
            lookRole.DataBindings.Control.Text = taikhoan.MaQuyen;

            rdoStay.SelectedIndex = taikhoan.TrangThai == true ? 0 : 1;
        }

        public void save()
        {
            if (!checkData())
                return;

            if (f_update == false)
                insert();
            else
                update();
        }

        private void insert()
        {
            try
            {
                taikhoan = new TaiKhoan();
                taikhoan.UserName = txtUserName.Text;
                EncriptMD5 coder = new EncriptMD5();
                taikhoan.Password = coder.encript(txtPass.Text);
                taikhoan.QuyenTruyCap = (QuyenTruyCap)lookRole.GetSelectedDataRow();
                taikhoan.TrangThai = rdoStay.SelectedIndex == 0;
                taikhoan.deleted = false;

                db.TaiKhoans.InsertOnSubmit(taikhoan);
                db.SubmitChanges();
                MessageBox.Show("Success");

                txtUserName.ResetText();
                txtrePass.ResetText();
                txtPass.ResetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }
        }

        private void update()
        {
            FormAuthenDelete frmAuthen = new FormAuthenDelete();
            DialogResult result = frmAuthen.ShowDialog();

            if (result != DialogResult.OK)
                return;

            try
            {
                if (txtPass.Text != "" && txtrePass.Text != "")
                {
                    EncriptMD5 coder = new EncriptMD5();
                    taikhoan.Password = coder.encript(txtPass.Text);
                }
                taikhoan.QuyenTruyCap = (QuyenTruyCap)lookRole.GetSelectedDataRow();
                taikhoan.TrangThai = rdoStay.SelectedIndex == 0;

                db.SubmitChanges();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }
        }

        public void Dispose()
        {
            if (f_update == false)
            {
                txtUserName.ResetText();
                txtrePass.ResetText();
                txtPass.ResetText();
            }
            else
            {
                load();
            }
        }

        private bool checkData()
        {
            bool result = true;
            Check check = new Check();

            result = check.checkEmpty(txtUserName) && result;

            if (f_update == false)
            {
                result = check.checkEmpty(txtrePass) && result;
                result = check.checkEmpty(txtPass) && result;
            }

            QuyenTruyCap q = (QuyenTruyCap)lookRole.GetSelectedDataRow();
            if (q == null)
            {
                lookRole.BackColor = Color.Khaki;
                return false;
            }

            if (txtPass.Text != txtrePass.Text)
            {
                picWarningPassword.Visible = true;
                return false;
            }
            else
            {
                picWarningPassword.Visible = false;
            }

            return result;
        }

        private void texbox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void btnCheckMaCV_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan a = db.TaiKhoans.Single(p => p.UserName == txtUserName.Text);
                MessageBox.Show("User đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("User có thể dùng", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
