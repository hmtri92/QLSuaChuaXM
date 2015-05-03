using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace DeTai
{
    public partial class UC_HoaDon : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();

        bool f_look_KhachHang = false;
        bool f_look_Xe = false;

        KhachHang khachhang;
        Xe xe;
        Xe_Khach xekhach;
        SuaChua suachua;
        ChiTietSuaChua chitietsuachua;
        List<CongViecSuaChua> lstCVSC;

        public UC_HoaDon()
        {
            InitializeComponent();
        }

        public void save()
        {
            try
            {
                if (!checkValue())
                    return;

                setDataKH();
                setdataXe();
                setdataXeKhach();
                setdataSuaChua();

                getListWork();
                db.SuaChuas.InsertOnSubmit(suachua);

                db.SubmitChanges();

                MessageBox.Show("Success");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failse");
            }
        }

        public void Dispose()
        {
            lblClearKH_Click(null, null);
            lblClearXe_Click(null, null);

            khachhang = null;
            xe = null;
            xekhach = null;
            suachua = null;
            chitietsuachua = null;
            lstCVSC.Clear();

            cklstCongViec.UnCheckAll();
            cklstCongViec.UnCheckSelectedItems();
            txtNotes.ResetText();
            txtTamThu.ResetText();
        }

        public void load()
        {
            txtFullName.Focus();

            try
            {
                var congviec = from cv in db.CongViecs
                               where cv.deleted == false
                               select cv;
                cklstCongViec.DataSource = congviec;
                cklstCongViec.DisplayMember = "TenCV";
                cklstCongViec.ValueMember = "MaCV";

                var loaixes = from lx in db.LoaiXes
                              select lx;

                lookLoaiXe.Properties.DataSource = loaixes;
                lookLoaiXe.Properties.DisplayMember = "TenLXe";
                lookLoaiXe.Properties.ValueMember = "MaLXe";
            }
            catch (SqlException ex)
            {}
        }

        

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            load();
        }

        private void lblLookKhachHang_Click(object sender, EventArgs e)
        {
            FormLookKhachHang frmlookKhachHang = new FormLookKhachHang();
            DialogResult result = frmlookKhachHang.ShowDialog();

            if (result != DialogResult.OK)
                return;

            khachhang = frmlookKhachHang.khachhang;
            f_look_KhachHang = true;

            setKhachHang();
        }

        private void lblLookXe_Click(object sender, EventArgs e)
        {
            FormLookXe frmLookXe = new FormLookXe();
            DialogResult result =  frmLookXe.ShowDialog();

            if (result != DialogResult.OK)
                return;

            xe = frmLookXe.xe;
            f_look_Xe = true;

            setXe();
        }

        private void lblClearKH_Click(object sender, EventArgs e)
        {
            f_look_KhachHang = false;
            txtFullName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhoneNum.Enabled = true;

            txtFullName.ResetText();
            txtAddress.ResetText();
            txtPhoneNum.ResetText();

            khachhang = null;

        }

        private void lblClearXe_Click(object sender, EventArgs e)
        {
            f_look_Xe = false;

            txtPlate.Enabled = true;
            txtColor.Enabled = true;
            lookLoaiXe.Enabled = true;

            txtColor.ResetText();
            txtPlate.ResetText();

            xe = null;
        }

        private void texbox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }


        /*
         * Check
         * */
        bool checkValue()
        {
            Color color = Color.Khaki;
            bool result = true;

            Check check = new Check();

            result = check.checkEmpty(txtFullName) && result;
            result = check.checkEmpty(txtAddress) && result;
            result = check.checkEmpty(txtPlate) && result;
            result = check.checkEmpty(txtColor) && result;
            result = check.checkEmpty(dtDateCreate) && result;
            result = check.checkEmpty(lookLoaiXe) && result;
            result = check.checkPhone(txtPhoneNum) && result;

            return result;
        }

        /*
         * Dung chung
         * */
        // Set value xe get from formlookxe
        private void setXe()
        {
            setComponentsXe();
            disableXe();
        }

        private void disableXe()
        {
            txtPlate.Enabled = false;
            txtColor.Enabled = false;
            lookLoaiXe.Enabled = false;

        }

        private void setComponentsXe()
        {
            txtPlate.Text = xe.MaXe;
            txtColor.Text = xe.MauXe;
            lookLoaiXe.DataBindings.Control.Text = xe.LoaiXe.TenLXe;
        }

        // Set value khachhang get from formlookkhachhang
        private void setKhachHang()
        {
            setComponentsKhach();
            disableKH();
        }

        private void disableKH()
        {
            txtFullName.Enabled = false;
            txtAddress.Enabled = false;
            txtPhoneNum.Enabled = false;
        }

        private void setComponentsKhach()
        {
            txtFullName.Text = khachhang.TenKH;
            txtAddress.Text = khachhang.DiaChi;
            txtPhoneNum.Text = khachhang.SoDienThoai;
        }

        /*================             Them               ===============*/

        // Nhập thông tin xe, nếu xe đã tồn tại thì select xe đó trong csdl
        private void setdataXe()
        {
            if (f_look_Xe == true)
                return;

            try
            {
                xe = db.Xes.Single(p => p.MaXe == txtPlate.Text);
                if (xe.deleted == true)
                    xe.deleted = false;
            }
            catch (InvalidOperationException ex)
            {
                xe = new Xe();
                xe.MaXe = txtPlate.Text;
                xe.MauXe = txtColor.Text;
                xe.LoaiXe = (LoaiXe)lookLoaiXe.GetSelectedDataRow();
                xe.deleted = false;
            }
        }

        // Nhập thông khách hàng, nếu KH đã tồn tại thì select trong csdl
        private void setDataKH()
        {
            if (f_look_KhachHang == true)
                return;

            try
            {
                String id = txtFullName.Text + txtPhoneNum.Text;
                khachhang = db.KhachHangs.Single(p => p.MaKH == id);

                if (khachhang.deleted == true)
                    khachhang.deleted = false;
            }
            catch (InvalidOperationException ex)
            {
                khachhang = new KhachHang();
                khachhang.TenKH = txtFullName.Text;
                khachhang.DiaChi = txtAddress.Text;
                khachhang.SoDienThoai = txtPhoneNum.Text;
                khachhang.deleted = false;
                khachhang.MaKH = txtFullName.Text + khachhang.SoDienThoai;
                khachhang.deleted = false;
            }
        }

        //  Tạo mới xe_khách, nếu đã tồn tại thì selecttrong csdl
        private void setdataXeKhach()
        {
            try
            {
                xekhach = db.Xe_Khaches.Single(p => p.Xe == xe || p.KhachHang == khachhang);
                if (xekhach.deleted == true)
                    xekhach.deleted = false;
            }
            catch (InvalidOperationException ex)
            {
                xekhach = new Xe_Khach();
                xekhach.ID = xe.MaXe + khachhang.MaKH;
                xekhach.KhachHang = khachhang;
                xekhach.Xe = xe;
                xekhach.deleted = false;
            }
        }

        // Nhập thông Sửa chữa
        private void setdataSuaChua()
        {
            DateTime date = dtDateCreate.DateTime;
            bool tinhtrang = ckbFinish.Checked;

            suachua = new SuaChua();
            suachua.MaSC = xekhach.ID + "-D-" + String.Format("{0:s}", DateTime.Now);
            suachua.NgaySC = date;
            suachua.Tinhtrang = tinhtrang;
            suachua.Xe_Khach = xekhach;
            suachua.deleted = false;
            suachua.GhiChu = txtNotes.Text;
            suachua.DaThu = Double.Parse(txtTamThu.Text);
        }

        

        // Create chitietsuachua and list congviecsuachua from congviec check in cklstCongViec
        private void getListWork()
        {
            try
            {
                if (suachua == null)
                    return;

                chitietsuachua = new ChiTietSuaChua();
                chitietsuachua.deleted = false;
                chitietsuachua.SuaChua = suachua;
                chitietsuachua.MaCTSC = suachua.Xe_Khach.MaXe + "-" + String.Format("{0:s}", DateTime.Now);

                lstCVSC = new List<CongViecSuaChua>();

                // Create list ChiTietCongViec
                foreach (object item in cklstCongViec.CheckedItems)
                {
                    CongViec congviec = item as CongViec;

                    // Cong viec sua chua
                    CongViecSuaChua cvsc = new CongViecSuaChua();
                    cvsc.ChiTietSuaChua = chitietsuachua;
                    cvsc.CongViec = congviec;
                    cvsc.soluong = 1;

                    cvsc.ThanhTien = congviec.TienCong;
                    chitietsuachua.TienCong += cvsc.ThanhTien;

                    cvsc.deleted = false;
                    lstCVSC.Add(cvsc);
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
