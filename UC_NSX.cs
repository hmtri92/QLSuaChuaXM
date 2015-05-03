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
    public partial class UC_NSX : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        NhaSanXuat nhasanxuat;
        bool f_update = false;

        public UC_NSX()
        {
            InitializeComponent();
        }

        public UC_NSX(string id)
        {
            InitializeComponent();
            txtMaNSX.Enabled = false;
            f_update = true;
            nhasanxuat = db.NhaSanXuats.FirstOrDefault(p => p.MaNSX == id);
        }

        public void save()
        {
            if (checkData() == false)
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
                nhasanxuat = new NhaSanXuat();
                nhasanxuat.MaNSX = txtMaNSX.Text;
                nhasanxuat.TenNSX = txtTenNSX.Text;
                nhasanxuat.SoDienThoai = txtSDT.Text;
                nhasanxuat.DiaChi = txtDiaChi.Text;
                nhasanxuat.deleted = false;

                db.NhaSanXuats.InsertOnSubmit(nhasanxuat);
                db.SubmitChanges();
                MessageBox.Show("Seccess", "Seccess", MessageBoxButtons.OK);
            }
            catch (SqlException sx)
            {
                MessageBox.Show("Mã đã tồn tại", "Fail", MessageBoxButtons.OK);
            }
        }

        private void update()
        {
            try
            {
                nhasanxuat.TenNSX = txtTenNSX.Text;
                nhasanxuat.SoDienThoai = txtSDT.Text;
                nhasanxuat.DiaChi = txtDiaChi.Text;

                db.SubmitChanges();
                MessageBox.Show("Seccess", "Seccess", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void load()
        {
            try
            {
                txtMaNSX.Text = nhasanxuat.MaNSX;
                txtTenNSX.Text = nhasanxuat.TenNSX;
                txtDiaChi.Text = nhasanxuat.DiaChi;
                txtSDT.Text = nhasanxuat.SoDienThoai;
            }
            catch (NullReferenceException ex)
            { }
        }

        public void Dispose()
        {
            if (f_update == false)
            {
                txtMaNSX.ResetText();
                txtTenNSX.ResetText();
                txtDiaChi.ResetText();
                txtSDT.ResetText();
            }
            else
            {
                //db.GetChangeSet().Updates.Clear();
                //db.GetChangeSet().Inserts.Clear();
                load();
            }
        }

        private bool checkData()
        {
            bool result = true;
            Check check = new Check();

            result = check.checkEmpty(txtMaNSX) && result;
            result = check.checkEmpty(txtTenNSX) && result;
            result = check.checkPhone(txtSDT) && result;
            result = check.checkEmpty(txtDiaChi) && result;

            return result;
        }

        private void UC_NSX_Load(object sender, EventArgs e)
        {
            if (f_update == true)
                load();
        }

        private void btnCheckMaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                NhaSanXuat n = db.NhaSanXuats.Single(p => p.MaNSX == txtMaNSX.Text);
                MessageBox.Show("Mã đã tồn tại", "Fail", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã có thể dùng", "Success", MessageBoxButtons.OK);
            }
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }
    }
}
