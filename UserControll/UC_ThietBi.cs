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
    public partial class UC_ThietBi : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        ThietBi thietbi;
        bool f_update = false;

        public UC_ThietBi()
        {
            InitializeComponent();
        }

        public UC_ThietBi(string id)
        {
            InitializeComponent();
            f_update = true;
            try
            {
                txtMaTB.Enabled = false;
                thietbi = db.ThietBis.FirstOrDefault(p => p.MaThietBi == id);
            }
            catch (Exception ex)
            { }
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
                thietbi = new ThietBi();

                thietbi.MaThietBi = txtMaTB.Text;
                thietbi.TenThietBi = txtName.Text;
                thietbi.QuyCach = txtQuyCach.Text;
                thietbi.SoLuong = Int16.Parse(txtSoLuong.Text);
                thietbi.BaoHanh = Int16.Parse(txtBaoHanh.Text);
                thietbi.DonVi = txtDonVi.Text;
                thietbi.GiaNhap = Double.Parse(txtGiaNhap.Text);
                thietbi.min = Int16.Parse(txtMin.Text);
                thietbi.DonGia = Double.Parse(txtDonGia.Text);
                thietbi.deleted = false;

                LoaiThietBi loaiTb = lookLoaiTB.GetSelectedDataRow() as LoaiThietBi;
                thietbi.LoaiThietBi = loaiTb;

                NhaSanXuat nsx = lookNSX.GetSelectedDataRow() as NhaSanXuat;
                thietbi.NhaSanXuat1 = nsx;

                db.ThietBis.InsertOnSubmit(thietbi);
                db.SubmitChanges();
                MessageBox.Show("Seccess", "Message", MessageBoxButtons.OK);
            }
            catch (Exception ex )
            {
                MessageBox.Show("Kiểm tra lại mã", "Message", MessageBoxButtons.OK);
            }

        }

        private void update()
        {
            try
            {
                thietbi.MaThietBi = txtMaTB.Text;
                thietbi.TenThietBi = txtName.Text;
                thietbi.QuyCach = txtQuyCach.Text;
                thietbi.SoLuong = Int16.Parse(txtSoLuong.Text);
                thietbi.BaoHanh = Int16.Parse(txtBaoHanh.Text);
                thietbi.DonVi = txtDonVi.Text;
                thietbi.GiaNhap = Double.Parse(txtGiaNhap.Text);
                thietbi.min = Int16.Parse(txtMin.Text);
                thietbi.DonGia = Double.Parse(txtDonGia.Text);

                LoaiThietBi loaiTb = lookLoaiTB.GetSelectedDataRow() as LoaiThietBi;
                if (loaiTb != null)
                {
                    thietbi.LoaiThietBi = loaiTb;
                }
                else
                    thietbi.LoaiThietBi = null;

                NhaSanXuat nsx = lookNSX.GetSelectedDataRow() as NhaSanXuat;
                if (nsx != null)
                    thietbi.NhaSanXuat1 = nsx;
                else
                    thietbi.NhaSanXuat1 = null;

                db.SubmitChanges();
                MessageBox.Show("Seccess", "Message", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

            }
        }

        public void load()
        {
            txtMaTB.Text = thietbi.MaThietBi;
            txtName.Text = thietbi.TenThietBi;
            txtQuyCach.Text = thietbi.QuyCach;
            txtSoLuong.Text = thietbi.SoLuong.ToString();
            txtBaoHanh.Text = thietbi.BaoHanh.ToString();
            txtGiaNhap.Text = thietbi.GiaNhap.ToString();
            txtDonGia.Text = thietbi.DonGia.ToString();
            txtDonVi.Text = thietbi.DonVi;
            txtMin.Text = thietbi.min.ToString();

            if (thietbi.LoaiThietBi != null)
                lookLoaiTB.DataBindings.Control.Text = thietbi.LoaiThietBi.TenLoaiTB;

            if (thietbi.NhaSanXuat1 != null)
                lookNSX.DataBindings.Control.Text = thietbi.NhaSanXuat1.TenNSX;
        }

        public void Dispose()
        {
            if (f_update == false)
            {
                txtMaTB.ResetText();
                txtName.ResetText();
                txtQuyCach.ResetText();
                txtSoLuong.ResetText();
                txtBaoHanh.ResetText();
                txtGiaNhap.ResetText();
                txtDonGia.ResetText();
                txtDonVi.ResetText();
                txtMin.ResetText();
                lookLoaiTB.ResetText();
                lookNSX.ResetText();
            }
            else
            {
                //db.GetChangeSet().Updates.Clear();
                //db.GetChangeSet().Inserts.Clear();
                UC_ThietBi_Load(null, null);
            }
        }

        private bool checkData()
        {
            bool result = true;
            Check check = new Check();

            result = check.checkEmpty(txtMaTB) && result;
            result = check.checkEmpty(txtBaoHanh) && result;
            result = check.checkEmpty(txtDonGia) && result;
            result = check.checkEmpty(txtDonVi) && result;
            result = check.checkEmpty(txtGiaNhap) && result;
            result = check.checkEmpty(txtMin) && result;
            result = check.checkEmpty(txtName) && result;
            result = check.checkEmpty(txtQuyCach) && result;
            result = check.checkEmpty(txtSoLuong) && result;
            result = check.checkEmpty(lookLoaiTB) && result;
            result = check.checkEmpty(lookNSX) && result;

            return result;
        }

        private void texBox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void btnCheckMaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                ThietBi tb = db.ThietBis.Single(p => p.MaThietBi == txtMaTB.Text);
                MessageBox.Show("Mã đã tồn tại", "Fail", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã có thể dùng", "Success", MessageBoxButtons.OK);
            }
        }

        private void UC_ThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                var nhasanxuat = from p in db.NhaSanXuats
                                 where p.deleted == false
                                 select p;
                nhaSanXuatBindingSource.DataSource = nhasanxuat;

                var loaiTB = from p in db.LoaiThietBis
                             where p.deleted == false
                             select p;
                loaiThietBiBindingSource.DataSource = loaiTB;

                if (f_update == true)
                {
                    load();
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
