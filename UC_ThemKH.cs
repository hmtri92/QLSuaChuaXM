using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai
{
    public partial class UC_ThemKH : UserControl, IController
    {
        KhachHang khachhang;
        SCXMdbDataContext db = new SCXMdbDataContext();
        bool f_update = false;

        public UC_ThemKH()
        {
            InitializeComponent();
        }

        public UC_ThemKH(string id)
        {
            InitializeComponent();
            khachhang = db.KhachHangs.Single(p => p.MaKH == id);
            f_update = true;
            lblTitle.Text = "Sửa thông tin khách hàng";
        }

        public void save()
        {
            try
            {
                if (!checkData())
                    return;

                if (!f_update)
                    khachhang = new KhachHang();

                khachhang.TenKH = txtFullName.Text;
                khachhang.SoDienThoai = txtPhoneNum.Text;
                khachhang.DiaChi = txtAddress.Text;
                khachhang.MaKH = txtFullName.Text + txtPhoneNum.Text;

                if (!f_update)
                    db.KhachHangs.InsertOnSubmit(khachhang);
                db.SubmitChanges();

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkData()
        {
            Color color = Color.Khaki;
            bool result = true;

            Check check = new Check();

            result = check.checkEmpty(txtFullName) && result;
            result = check.checkEmpty(txtAddress) && result;
            result = check.checkPhone(txtPhoneNum) && result;
            
            return result;
        }

        private void textbox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        public void Dispose()
        {
            txtPhoneNum.ResetText();
            txtFullName.ResetText();
            txtAddress.ResetText();
        }

        public void load()
        {
            txtFullName.Text = khachhang.TenKH;
            txtAddress.Text = khachhang.DiaChi;
            txtPhoneNum.Text = khachhang.SoDienThoai;
        }
    }
}
