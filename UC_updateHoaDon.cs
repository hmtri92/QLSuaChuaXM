using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;

namespace DeTai
{
    public partial class UC_updateHoaDon : UserControl, IController
    {
        const int ERROR_NON = 0;
        const int ERROR_CONGVIEC = 1;
        const int ERROR_THIETBI = 2;
        const int CANCEL = 3;

        SCXMdbDataContext db = new SCXMdbDataContext();

        KhachHang khachhang;
        Xe xe;
        Xe_Khach xekhach;
        SuaChua suachua;
        ChiTietSuaChua chitietsuachua;
        List<CongViecSuaChua> lstCVSC = new List<CongViecSuaChua>();

        bool f_themCTSC = false;
        int f_Error = 0;
        bool f_candelete = false;
        bool f_change = false;

        double tongtien;


        public UC_updateHoaDon(String suachua)
        {
            InitializeComponent();

            this.suachua = db.SuaChuas.Single(p => p.MaSC == suachua);

            xekhach = this.suachua.Xe_Khach;
            khachhang = xekhach.KhachHang;
            xe = xekhach.Xe;
        }

        public void save()
        {
            try
            {
            if (f_change == false)
                return;

                getDataSuaChua();
                setChitTietSuaChua();
                getCongViecSuaChua();
                getThietBiSuaChua();

                if (f_Error == CANCEL)
                {
                    return;
                }


                if (f_Error == ERROR_CONGVIEC)
                {
                    MessageBox.Show("Trường công việc trong danh sách công việc không được rỗng", "Không thể lưu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    f_Error = ERROR_NON;
                    return;
                }

                if (f_Error == ERROR_THIETBI)
                {
                    MessageBox.Show("Trường thiết bị trong danh sách thiết bị không được rỗng", "Không thể lưu",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    f_Error = ERROR_NON;
                    return;
                }

                if (f_themCTSC == false)
                {
                    chitietsuachua = null;
                }
                else
                {
                    db.ChiTietSuaChuas.InsertOnSubmit(chitietsuachua);
                }

                db.SubmitChanges();

                //double sum = tinhtien();
                //txtTongTien.Text = sum.ToString();
                UC_updateHoaDon_Load(null, null);

                f_change = false;

                MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Dispose()
        {
            try
            {
                db.GetChangeSet().Updates.Clear();
                db.GetChangeSet().Inserts.Clear();
            }
            catch (Exception ex)
            { }
            UC_updateHoaDon_Load(null, null);
        }

        private void getDataSuaChua()
        {
            suachua.NgaySC = dtDateCreate.DateTime;
            suachua.Tinhtrang = ckbFinish.Checked;
            //suachua.Xe_Khach.KhachHang = khachhang;
            //suachua.Xe_Khach.Xe = xe;
        }

        private void setChitTietSuaChua()
        {
            chitietsuachua = new ChiTietSuaChua();
            chitietsuachua.SuaChua = suachua;
            chitietsuachua.deleted = false;
            chitietsuachua.MaCTSC = suachua.MaSC + "-" + String.Format("{0:hh:mm:ss}", DateTime.Now);
        }

        // Nếu xóa công việc thì set deleted == true
        // Nếu thêm mới thì add cvsc vào lstCVSC
        // Nếu không thay đổi thì thôi
        private void getCongViecSuaChua()
        {
            int i = 0;
            while (i < gridviewCongViec.RowCount)
            {
                CongViecSuaChua cvsc = gridviewCongViec.GetRow(i) as CongViecSuaChua; ;

                if (cvsc == null)
                {
                    f_Error = ERROR_CONGVIEC;
                    i++;
                    break;
                }

                // GetRowCellValue
                String maCV = null;
                String maNV = null;
                try
                {
                    maCV = gridviewCongViec.GetRowCellValue(i, colCongViec).ToString();
                }
                catch (NullReferenceException ex)
                { }
                try
                {
                    maNV = gridviewCongViec.GetRowCellValue(i, colMaNV).ToString();
                }
                catch (Exception ex) { }


                if (maCV == null)
                {
                    if (cvsc.ChiTietSuaChua == null)
                    {
                        gridviewCongViec.DeleteRow(i);
                        congViecSuaChuaBindingSource.Remove(cvsc);
                        continue;
                    }
                    else
                    {
                        // Không cho thay đổi
                        String ms = "Công việc thứ " + i + " chưa được chọn, nhấn Ok để nhập lại";
                        MessageBox.Show(ms, "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Không được rồi
                        f_Error = CANCEL;
                        return;
                    }
                }

                // Check delete
                if (cvsc.deleted == true)
                {
                    if (f_candelete == false)
                    {
                        FormAuthenDelete frmAuthen = new FormAuthenDelete();
                        DialogResult result = frmAuthen.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            f_candelete = true;
                            i++;
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu");
                            f_Error = CANCEL;
                            f_themCTSC = false;
                            return;
                        }
                    }
                    else
                    {
                        i++;
                        continue;
                    }

                }

                CongViec cv = db.CongViecs.Single(p => p.MaCV == maCV);
                CongViecSuaChua check;

                //Thêm công việc đã tồn tại chưa bị xóa
                int j = 0;
                bool f = false;
                while(j < i)
                {
                    check = gridviewCongViec.GetRow(j) as CongViecSuaChua;
                    if (gridviewCongViec.GetRowCellValue(j, colCongViec).ToString() == maCV)
                    {
                        gridviewCongViec.SetRowCellValue(j, colSoLuongCV, check.soluong + cvsc.soluong);
                        gridviewCongViec.SetRowCellValue(j, colThanhTienCV, check.ThanhTien + cvsc.soluong * cv.TienCong);
                        gridviewCongViec.DeleteRow(i);
                        f = true;
                        break;
                    }
                    j++;
                }
                if (f == true)
                    continue;


                // cái load lên từ csdl, k cần thêm nữa
                if (cvsc.ChiTietSuaChua != null)
                {
                    i++;
                    continue;
                }

                // Nếu công việc được thêm có trong csdl mà bị xóa
                try
                {
                    // Không ổn
                    check = db.CongViecSuaChuas.Single(p => p.MaCV == maCV && p.ChiTietSuaChua.SuaChua == suachua && p.deleted == true);
                    check.deleted = false;
                    check.soluong = cvsc.soluong;
                    check.ThanhTien = cvsc.soluong * cv.TienCong;
                    check.MaNV = maNV;

                    gridviewCongViec.DeleteRow(i);
                    congViecSuaChuaBindingSource.Remove(cvsc);
                    continue;
                }
                catch ( Exception ex)
                {
                    // Thêm bình thường
                    cvsc.MaCV = maCV;
                    cvsc.MaNV = maNV;
                    cvsc.ChiTietSuaChua = chitietsuachua;
                    cvsc.deleted = false;
                    cvsc.ThanhTien = cv.TienCong * cvsc.soluong;

                    f_themCTSC = true;
                    i++;
                }
            }
        }

        private void getThietBiSuaChua()
        {
            int i = 0;
            while (i < gridViewThietBi.RowCount)
            {
                ThietBiSuaChua tbsc = gridViewThietBi.GetRow(i) as ThietBiSuaChua;

                if (tbsc == null)
                {
                    f_Error = ERROR_THIETBI;
                    i++;
                    break;
                }

                // GetRowCellValue
                String maTB = null;
                try
                {
                    maTB = gridViewThietBi.GetRowCellValue(i, colTenTB).ToString();
                }
                catch (NullReferenceException ex)
                { }


                if (maTB == null)
                {
                    if (tbsc.ChiTietSuaChua == null)
                    {
                        gridViewThietBi.DeleteRow(i);
                        thietBiSuaChuaBindingSource.Remove(tbsc);
                        continue;
                    }
                    else
                    {
                        // Không cho thay đổi
                        String ms = "Thiết bị thứ " + i + " chưa được chọn, nhấn Ok để nhập lại";
                        MessageBox.Show(ms, "Warning",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        f_Error = CANCEL;
                        return;
                    }
                }

                // Kiểm tra số lượng sản phẩm trong bảng có rỗng không
                // kiểm tra sản phẩm trong kho có đủ không
                int soluong = 0;
                ThietBi tb = db.ThietBis.Single(p => p.MaThietBi == maTB);
                try
                {
                    soluong = Int16.Parse(gridViewThietBi.GetRowCellValue(i, colSoLuongTB).ToString());
                }
                catch (NullReferenceException ex)
                { }
                catch (Exception ex)
                {
                    MessageBox.Show("Trường số lượng không được rỗng");
                    f_Error = CANCEL;
                    return;
                }

                if (tb.SoLuong < soluong)
                {
                    MessageBox.Show("Số lượng " + tb.TenThietBi + " không đủ, chỉ còn lại " + tb.SoLuong);
                    f_Error = CANCEL;
                    return;
                }

                // Check delete
                if (tbsc.deleted == true)
                {
                    if (f_candelete == false)
                    {
                        FormAuthenDelete frmAuthen = new FormAuthenDelete();
                        DialogResult result = frmAuthen.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            f_candelete = true;
                            i++;

                            // Trả thiết bị lại bảng thiết bị
                            tb.SoLuong += soluong;

                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu");
                            f_Error = CANCEL;
                            f_themCTSC = false;
                            return;
                        }
                    }
                    else
                    {
                        i++;
                        continue;
                    }

                }

                ThietBiSuaChua check;
                //Thêm công việc đã tồn tại
                for (int j = 0; j < i; j++)
                {
                    check = gridViewThietBi.GetRow(j) as ThietBiSuaChua;
                    if (gridViewThietBi.GetRowCellValue(j, colTenTB).ToString() == maTB)
                    {
                        gridViewThietBi.SetRowCellValue(j, colSoLuongTB, check.soluong + tbsc.soluong);
                        gridViewThietBi.SetRowCellValue(j, colThanhTienTB, check.ThanhTien + tbsc.soluong * tb.DonGia);

                        // Trừ thiết bị trong bảng thiết bị
                        tb.SoLuong -= soluong;

                        gridViewThietBi.DeleteRow(i);
                        continue;
                    }
                }


                // cái load lên từ csdl, k cần thêm nữa
                if (tbsc.ChiTietSuaChua != null)
                {
                    i++;
                    continue;
                }

                // Nếu thiết bị được thêm có trong csdl mà bị xóa
                try
                {
                    // Cái này không ổn: p.ChiTietSuaChua.SuaChua == suachua
                    check = db.ThietBiSuaChuas.Single(p => p.MaThietBi == maTB && p.ChiTietSuaChua.SuaChua == suachua && p.deleted == true);
                    check.deleted = false;
                    check.soluong = tbsc.soluong;
                    check.ThanhTien = tbsc.soluong * tb.DonGia;

                    gridViewThietBi.DeleteRow(i);
                    thietBiSuaChuaBindingSource.Remove(tbsc);
                    continue;
                }
                catch (Exception ex)
                {
                    // Thêm bình thường
                    tbsc.MaThietBi = maTB;
                    tbsc.ChiTietSuaChua = chitietsuachua;
                    tbsc.deleted = false;
                    tbsc.ThanhTien = tb.DonGia * tbsc.soluong;
                    tb.SoLuong -= soluong;

                    f_themCTSC = true;
                    i++;
                }
            }
        }

        public void load()
        {
            txtFullName.Focus();

            var loaixes = from lx in db.LoaiXes
                          select lx;

            lookLoaiXe.Properties.DataSource = loaixes;
            lookLoaiXe.Properties.DisplayMember = "TenLXe";
            lookLoaiXe.Properties.ValueMember = "MaLXe";

            var congviec = from p in db.CongViecs
                           where p.deleted == false
                           select p;
            congViecBindingSource.DataSource = congviec;

            var thietbi = from p in db.ThietBis
                          where p.deleted == false
                          select p;
            thietBiBindingSource.DataSource = thietbi;

            var nhanvien = from p in db.NhanViens
                           where p.deleted == false
                           select p;
            nhanVienBindingSource.DataSource = nhanvien;

            f_Error = 0;
            f_candelete = false;
        }

        private void UC_updateHoaDon_Load(object sender, EventArgs e)
        {
            load();
            initUpdate();
            checkPhieuThu();
        }

        private void initUpdate()
        {
            // Khach hang
            setKhachHang();

            //Xe
            setXe();

            dtDateCreate.DateTime = suachua.NgaySC;
            ckbFinish.Checked = suachua.Tinhtrang;
            txtNotes.Text = suachua.GhiChu;

            tongtien = tinhtien();
            txtTongTien.Text = tongtien.ToString();

            loadCongViecSuaChua();
            loadThietBiSuaChua();
        }

        private double tinhtien()
        {
            double sum = 0;
            try
            {
                var tienSC = from p in db.CongViecSuaChuas
                             where p.ChiTietSuaChua.SuaChua == suachua && p.deleted == false
                             select p.ThanhTien;
                if (tienSC.Count() > 0)
                    sum += tienSC.Sum().Value;
            }
            catch (InvalidOperationException ex)
            { }

            try
            {
                var tienTB = from p in db.ThietBiSuaChuas
                             where p.ChiTietSuaChua.SuaChua == suachua && p.deleted == false
                             select p.ThanhTien;
                if (tienTB.Count() > 0)
                    sum += tienTB.Sum().Value;
            }
            catch (InvalidOperationException ex)
            { }

            return sum;
        }

        private void loadCongViecSuaChua()
        {
            var congviecsuachua = from p in db.CongViecSuaChuas
                                  where p.ChiTietSuaChua.SuaChua == suachua && p.deleted == false
                                  select p;

            congViecSuaChuaBindingSource.DataSource = congviecsuachua;
            //gridviewCongViec.RefreshData();
        }

        private void loadThietBiSuaChua()
        {
            var thietbisuachua = from p in db.ThietBiSuaChuas
                                 where p.ChiTietSuaChua.SuaChua == suachua && p.deleted == false
                                 select p;
            thietBiSuaChuaBindingSource.DataSource = thietbisuachua;
        }

        private void setXe()
        {
            txtPlate.Text = xe.MaXe;
            txtColor.Text = xe.MauXe;
            lookLoaiXe.DataBindings.Control.Text = xe.LoaiXe.TenLXe;
        }

        // Set value khachhang get from formlookkhachhang
        private void setKhachHang()
        {
            txtFullName.Text = khachhang.TenKH;
            txtAddress.Text = khachhang.DiaChi;
            txtPhoneNum.Text = khachhang.SoDienThoai;
        }

        public void lblLookKhachHang_Click(object sender, EventArgs e)
        {
            FormLookKhachHang frmlookKhachHang = new FormLookKhachHang();
            DialogResult result = frmlookKhachHang.ShowDialog();

            if (result != DialogResult.OK)
                return;
            String maKH = frmlookKhachHang.khachhang.MaKH;
            try
            {
                khachhang = db.KhachHangs.Single(p => p.MaKH == maKH);
            }
            catch (InvalidOperationException ex)
            { }

            try
            {
                xekhach = db.Xe_Khaches.Single(p => p.MaKH == maKH && p.Xe == xe);
            }
            catch (InvalidOperationException ex)
            {
                xekhach = new Xe_Khach();
                xekhach.Xe = xe;
                xekhach.KhachHang = khachhang;
                xekhach.deleted = false;
                xekhach.ID = xe.MaXe + maKH;
            }
            suachua.Xe_Khach = xekhach;

            setKhachHang();
            f_change = true;
        }

        private void lblLookXe_Click(object sender, EventArgs e)
        {
            FormLookXe frmLookXe = new FormLookXe();
            DialogResult result = frmLookXe.ShowDialog();

            if (result != DialogResult.OK)
                return;

            String maXe = frmLookXe.xe.MaXe;

            try
            {
                xe = db.Xes.Single(p => p.MaXe == maXe);
            }
            catch (InvalidOperationException ex)
            { }

            try
            {
                xekhach = db.Xe_Khaches.Single(p => p.Xe == xe && p.KhachHang == khachhang);
            }
            catch (InvalidOperationException ex)
            {
                xekhach = new Xe_Khach();
                xekhach.Xe = xe;
                xekhach.KhachHang = khachhang;
                xekhach.deleted = false;
                xekhach.ID = xe.MaXe + khachhang.MaKH;
            }
            suachua.Xe_Khach = xekhach;

            setXe();
            f_change = true;
        }

        private void btnAddCongViec_Click(object sender, EventArgs e)
        {
            f_change = true;
            gridviewCongViec.AddNewRow();
        }

        private void btnAddThietBi_Click(object sender, EventArgs e)
        {
            f_change = true;
            gridViewThietBi.AddNewRow();
        }

        private void btnResetCV_Click(object sender, EventArgs e)
        {
            loadCongViecSuaChua();
            gridviewCongViec.RefreshData();
        }

        private void btnResetTB_Click(object sender, EventArgs e)
        {
            loadThietBiSuaChua();
            gridViewThietBi.RefreshData();
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (f_change == true)
            {
                result = MessageBox.Show("Lưu thay đổi và xuất phiếu thu", "Lưu", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    save();
                else
                    return;  
            }

            FormNhapSoTien frmSotien = new FormNhapSoTien();
            result = frmSotien.ShowDialog();
            if (result != DialogResult.OK)
                return;

            double sotien = frmSotien.sotien + suachua.DaThu.Value;

            if (sotien < tongtien)
            {
                MessageBox.Show("Số tiền không đủ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PhieuThus phieuthu = new PhieuThus();
            phieuthu.SuaChua = suachua;
            phieuthu.SoTien = sotien;
            phieuthu.NgayLapPhieu = DateTime.Now;
            phieuthu.UserName = Program.user.UserName;
            phieuthu.deleted = false;
            phieuthu.SoPhieu = String.Format("{0:s}", DateTime.Now);

            db.PhieuThus.InsertOnSubmit(phieuthu);
            db.SubmitChanges();

            MessageBox.Show("Tiền dư: " + (sotien - tongtien));
            clock();
        }

        private void checkPhieuThu()
        {
            try
            {
                var phieuthu = db.PhieuThus.Single(p => p.SuaChua == suachua);
                lblNguoiLapPhieu.Text = phieuthu.TaiKhoan.UserName;
                clock();
            }
            catch (Exception ex)
            {
                lblNguoiLapPhieu.Text = "";
            }
        }

        private void clock()
        {
            lblLookKhachHang.Visible = false;
            lblLookXe.Visible = false;
            btnAddCongViec.Visible = false;
            btnAddThietBi.Visible = false;
            btnResetCV.Visible = false;
            btnResetTB.Visible = false;
            txtNotes.Enabled = false;
            dtDateCreate.Enabled = false;
            btnXuatHoaDon.Enabled = false;
        }

        private void txtNotes_EditValueChanged(object sender, EventArgs e)
        {
            f_change = true;
        }
    }
}
