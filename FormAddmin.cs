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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using System.Data.SqlClient;
using System.Threading;

namespace DeTai
{
    public partial class FormAddmin : DevExpress.XtraEditors.XtraForm
    {
        SCXMdbDataContext db;

        UserControl mainComponent;
        int numpage = 1;
        int f_Entity = 0;

        const int TAI_KHOAN = 1;
        const int ROLE = 2;
        const int NHAN_VIEN = 3;
        const int NHOM_THO = 4;
        const int THONG_KE = 5;

        public FormAddmin()
        {
            InitializeComponent();
            this.Text = Program.user.UserName;
            db = new SCXMdbDataContext();
        }

        private void setView()
        {
            try
            {
                splitContainerControlRight.Panel2.Controls.Clear();

                splitContainerControlRight.Panel2.Controls.Add(panelMain);
                panelMain.Dock = DockStyle.Fill;

                //btnClear.Enabled = false;
                btnSave.Enabled = false;
                btnReset.Enabled = false;
                btnChange.Enabled = true;
                btnDelete.Enabled = true;

                btnDelete.Enabled = true;
                btnNext.Enabled = true;
                btnRe.Enabled = true;
                txtpage.Enabled = true;
            }
            catch (Exception ex) { }
        }

        void setAddOrChange()
        {
            splitContainerControlRight.Panel2.Controls.Clear();
            splitContainerControlRight.Panel2.Controls.Add(mainComponent);
            mainComponent.Dock = DockStyle.Fill;

            btnReset.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnChange.Enabled = false;
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            switch (f_Entity)
            {
                case TAI_KHOAN:
                    changeTaiKhoan(view, pt);
                    break;
                case ROLE:
                    changeRole(view, pt);
                    break;
                case NHAN_VIEN:
                    changeNhanVien(view, pt);
                    break;
                case NHOM_THO:
                    changeNhomTho(view, pt);
                    break;
                case THONG_KE:
                    break;
            }
        }

        private void changeNhomTho(GridView view, Point pt)
        {
            try
            {
                GridHitInfo info = view.CalcHitInfo(pt);

                if (info.InRow || info.InRowCell)
                {
                    String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                    mainComponent = new UC_NhomTho(id);
                    setAddOrChange();
                }
            }
            catch (Exception ex) { }
        }

        private void changeNhanVien(GridView view, Point pt)
        {
            try
            {
                GridHitInfo info = view.CalcHitInfo(pt);

                if (info.InRow || info.InRowCell)
                {
                    String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                    mainComponent = new UC_NhanVien(id);
                    setAddOrChange();
                }
            }
            catch (Exception ex) { }
        }

        private void changeRole(GridView view, Point pt)
        {
            try
            {
                GridHitInfo info = view.CalcHitInfo(pt);

                if (info.InRow || info.InRowCell)
                {
                    String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                    mainComponent = new UC_Role(id);
                    setAddOrChange();
                }
            }
            catch (Exception ex) { }
        }

        private void changeTaiKhoan(GridView view, Point pt)
        {
            try
            {
                GridHitInfo info = view.CalcHitInfo(pt);

                if (info.InRow || info.InRowCell)
                {
                    String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                    mainComponent = new UC_TaiKhoan(id);
                    setAddOrChange();
                }
            }
            catch (Exception ex) { }
        }


        private void btnXemTaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != TAI_KHOAN)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                if (numpage < 1)
                    return;
                f_Entity = TAI_KHOAN;

                //SCXMdbDataContext db = new SCXMdbDataContext();

                var taikhoans = from p in db.TaiKhoans
                                where p.deleted == false
                                select new
                                {
                                    ID = p.UserName,
                                    trangthai = p.TrangThai,
                                    quyen = p.QuyenTruyCap.TenQuyen
                                };
                int n = taikhoans.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = taikhoans.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Username";
                gridView.Columns["trangthai"].Caption = "Trạng thái hoạt động";
                gridView.Columns["quyen"].Caption = "Quyền";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnXemQuyen_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != ROLE)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                f_Entity = ROLE;

                //SCXMdbDataContext db = new SCXMdbDataContext();

                var roles = from p in db.QuyenTruyCaps
                            where p.deleted == false
                            select new
                            {
                                ID = p.MaQuyen,
                                TenQuyen = p.TenQuyen,
                                ghichu = p.GhiChu
                            };
                int n = roles.Count();
                if ((numpage * 25 - 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = roles.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "ID";
                gridView.Columns["TenQuyen"].Caption = "Tên quyền";
                gridView.Columns["ghichu"].Caption = "Ghi chú";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void xemNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != NHAN_VIEN)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                f_Entity = NHAN_VIEN;

                //SCXMdbDataContext db = new SCXMdbDataContext();

                var nhanviens = from p in db.NhanViens
                                where p.deleted == false
                                select new
                                {
                                    ID = p.MaNV,
                                    TenNV = p.TenNV,
                                    namsinh = p.NamSinh,
                                    gioitinh = p.GioiTinh,
                                    sodienthoai = p.SDT,
                                    diachi = p.DiaChi,
                                    loaiNV = p.LoaiNV.TenLoaiNV,
                                    luong = p.Luong
                                };

                int n = nhanviens.Count();
                if ((numpage * 25 - 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = nhanviens.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "ID";
                gridView.Columns["TenNV"].Caption = "Họ tên";
                gridView.Columns["namsinh"].Caption = "Năm sinh";
                gridView.Columns["gioitinh"].Caption = "Nữ";
                gridView.Columns["sodienthoai"].Caption = "Số điện thoại";
                gridView.Columns["diachi"].Caption = "Địa chỉ";
                gridView.Columns["loaiNV"].Caption = "Loại nhân viên";
                gridView.Columns["luong"].Caption = "Lương";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnXemNhomTho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != NHOM_THO)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                f_Entity = NHOM_THO;

                //SCXMdbDataContext db = new SCXMdbDataContext();

                var nhomthos = from p in db.NhomThoes
                               where p.deleted == false
                               select new
                               {
                                   ID = p.MaNhom,
                                   TenNhom = p.TenNhom,
                                   TruongNhom = p.NhanVien.TenNV
                               };

                int n = nhomthos.Count();
                if ((numpage * 25 - 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = nhomthos.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "ID";
                gridView.Columns["TenNhom"].Caption = "Tên nhóm";
                gridView.Columns["TruongNhom"].Caption = "Trưởng nhóm";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            if (numpage == 1)
            {
                btnRe.Enabled = false;
                return;
            }
            numpage--;
            txtpage.Text = numpage.ToString();

            switch (f_Entity)
            {
                case TAI_KHOAN:
                    btnXemTaiKhoan_LinkClicked(null, null);
                    break;
                case ROLE:
                    btnXemQuyen_LinkClicked(null, null);
                    break;
                case NHAN_VIEN:
                    xemNhanVien_LinkClicked(null, null);
                    break;
                case NHOM_THO:
                    btnXemNhomTho_LinkClicked(null, null);
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numpage++;
            txtpage.Text = numpage.ToString();

            switch (f_Entity)
            {
                case TAI_KHOAN:
                    btnXemTaiKhoan_LinkClicked(null, null);
                    break;
                case ROLE:
                    btnXemQuyen_LinkClicked(null, null);
                    break;
                case NHAN_VIEN:
                    xemNhanVien_LinkClicked(null, null);
                    break;
                case NHOM_THO:
                    btnXemNhomTho_LinkClicked(null, null);
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setView();
            btnDelete.Enabled = true;
            btnNext.Enabled = false;
            btnRe.Enabled = false;
            txtpage.Enabled = false;

            switch (f_Entity)
            {
                case TAI_KHOAN:
                    searchTaiKhoan();
                    break;
                case ROLE:
                    searchRole();
                    break;
                case NHAN_VIEN:
                    searchNhanVien();
                    break;
                case NHOM_THO:
                    SearchNhomTho();
                    break;
            }
        }

        private void SearchNhomTho()
        {
            try
            {
                String value = txtSearch.Text;
                //SCXMdbDataContext db = new SCXMdbDataContext();
                var nhomthos = from p in db.NhomThoes
                               where p.deleted == false && (p.TenNhom.Contains(value) || p.NhanVien.TenNV.Contains(value)
                               || p.TruongNhom.Contains(value))
                               select new
                               {
                                   ID = p.MaNhom,
                                   TenNhom = p.TenNhom,
                                   TruongNhom = p.NhanVien.TenNV
                               };
                gridMain.DataSource = nhomthos;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "ID";
                gridView.Columns["TenNhom"].Caption = "Tên nhóm";
                gridView.Columns["TruongNhom"].Caption = "Trưởng nhóm";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu", "Error", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            { }
        }

        private void searchNhanVien()
        {
            try
            {
                String value = txtSearch.Text;
                //SCXMdbDataContext db = new SCXMdbDataContext();

                var nhanviens = from p in db.NhanViens
                                where p.deleted == false && (p.TenNV.Contains(value) || p.SDT.Contains(value)
                                 || p.DiaChi.Contains(value) || p.LoaiNV.TenLoaiNV.Contains(value))
                                select new
                                {
                                    ID = p.MaNV,
                                    TenNV = p.TenNV,
                                    namsinh = p.NamSinh,
                                    gioitinh = p.GioiTinh,
                                    sodienthoai = p.SDT,
                                    diachi = p.DiaChi,
                                    loaiNV = p.LoaiNV.TenLoaiNV,
                                    luong = p.Luong
                                };
                gridMain.DataSource = nhanviens;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "ID";
                gridView.Columns["TenNV"].Caption = "Họ tên";
                gridView.Columns["namsinh"].Caption = "Năm sinh";
                gridView.Columns["gioitinh"].Caption = "Nữ";
                gridView.Columns["sodienthoai"].Caption = "Số điện thoại";
                gridView.Columns["diachi"].Caption = "Địa chỉ";
                gridView.Columns["loaiNV"].Caption = "Loại nhân viên";
                gridView.Columns["luong"].Caption = "Lương";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            { }
        }

        private void searchRole()
        {
            try
            {
                String value = txtSearch.Text;
                //SCXMdbDataContext db = new SCXMdbDataContext();

                var roles = from p in db.QuyenTruyCaps
                            where p.deleted == false && (p.TenQuyen.Contains(value))
                            select new
                            {
                                ID = p.MaQuyen,
                                TenQuyen = p.TenQuyen,
                                ghichu = p.GhiChu
                            };
                gridMain.DataSource = roles;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "ID";
                gridView.Columns["TenQuyen"].Caption = "Tên quy";
                gridView.Columns["ghichu"].Caption = "Ghi chú";

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            { }
        }

        private void searchTaiKhoan()
        {
            try
            {
                String value = txtSearch.Text;
                //SCXMdbDataContext db = new SCXMdbDataContext();

                var taikhoans = from p in db.TaiKhoans
                                where p.deleted == false && (p.UserName.Contains(value))
                                select new
                                {
                                    ID = p.UserName,
                                    trangthai = p.TrangThai,
                                    quyen = p.QuyenTruyCap.TenQuyen
                                };
                gridMain.DataSource = taikhoans;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Username";
                gridView.Columns["trangthai"].Caption = "Trạng thái khóa";
                gridView.Columns["quyen"].Caption = "Quyền";

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            { }
        }

        private void txtThemTaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_TaiKhoan();
            setAddOrChange();
        }

        private void txtThemQuyen_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_Role();
            setAddOrChange();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                IController b = (IController)mainComponent;
                b.save();
            }
            catch (NullReferenceException ex)
            { }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                IController b = (IController)mainComponent;
                b.Dispose();
            }
            catch (NullReferenceException ex)
            { }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = true;

                int row = gridView.GetSelectedRows()[0];
                String id = gridView.GetRowCellValue(row, "ID").ToString();

                switch (f_Entity)
                {
                    case TAI_KHOAN:
                        mainComponent = new UC_TaiKhoan(id);
                        break;
                    case ROLE:
                        mainComponent = new UC_Role(id);
                        break;
                    case NHAN_VIEN:
                        mainComponent = new UC_NhanVien(id);
                        break;
                    case NHOM_THO:
                        mainComponent = new UC_NhomTho(id);
                        break;
                }
                setAddOrChange();
            }
            catch (IndexOutOfRangeException ex)
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                switch (f_Entity)
                {
                    case TAI_KHOAN:
                        deleteTaiKhoan(gridView);
                        break;
                    case ROLE:
                        deleteRole(gridView);
                        break;
                    case NHAN_VIEN:
                        deleteNhanVien(gridView);
                        break;
                    case NHOM_THO:
                        deleteNhomTho(gridView);
                        break;
                }
            }
            catch (IndexOutOfRangeException ex)
            { }
        }

        private void deleteNhomTho(object sender)
        {
            try
            {
                FormAuthenDelete frmAuthen = new FormAuthenDelete();
                frmAuthen.ShowDialog();

                if (frmAuthen.DialogResult != DialogResult.OK)
                    return;

                GridView view = sender as GridView;
                int row = view.GetSelectedRows()[0];
                String id = view.GetRowCellValue(row, "ID").ToString();

                //SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    NhomThoe nhomtho = db.NhomThoes.Single(p => p.MaNhom == id);
                    nhomtho.deleted = true;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                { }


                view.DeleteRow(row);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu, kiểm tra service", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            { }
        }

        private void deleteNhanVien(object sender)
        {
            try
            {
                FormAuthenDelete frmAuthen = new FormAuthenDelete();
                frmAuthen.ShowDialog();

                if (frmAuthen.DialogResult != DialogResult.OK)
                    return;

                GridView view = sender as GridView;
                int row = view.GetSelectedRows()[0];
                String id = view.GetRowCellValue(row, "ID").ToString();

                //SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    NhanVien nhanvien = db.NhanViens.Single(p => p.MaNV == id);
                    nhanvien.deleted = true;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                { }


                view.DeleteRow(row);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void deleteRole(object sender)
        {
            try
            {
                FormAuthenDelete frmAuthen = new FormAuthenDelete();
                frmAuthen.ShowDialog();

                if (frmAuthen.DialogResult != DialogResult.OK)
                    return;

                GridView view = sender as GridView;
                int row = view.GetSelectedRows()[0];
                String id = view.GetRowCellValue(row, "ID").ToString();

                //SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    QuyenTruyCap role = db.QuyenTruyCaps.Single(p => p.MaQuyen == id);
                    role.deleted = true;
                    db.SubmitChanges();
                }
                catch (Exception ex)
                { }


                view.DeleteRow(row);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void deleteTaiKhoan(object sender)
        {
            try
            {
                FormAuthenDelete frmAuthen = new FormAuthenDelete();
                frmAuthen.ShowDialog();

                if (frmAuthen.DialogResult != DialogResult.OK)
                    return;

                GridView view = sender as GridView;
                int row = view.GetSelectedRows()[0];
                String id = view.GetRowCellValue(row, "ID").ToString();

                //SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    TaiKhoan taikhoan = db.TaiKhoans.Single(p => p.UserName == id);
                    taikhoan.deleted = true;
                    db.SubmitChanges();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
                }

                view.DeleteRow(row);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void gridMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                return;
            }

            btnDelete_Click(null, null);
        }

        private void btnThemNV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_NhanVien();
            setAddOrChange();
        }

        private void btnThemNhomTho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_NhomTho();
            setAddOrChange();
        }

        private void gridMain_DoubleClick(object sender, EventArgs e)
        {
            GridControl grid = sender as GridControl;

            Point pt = grid.PointToClient(Control.MousePosition);

            GridView view = (GridView)grid.FocusedView;

            btnSave.Enabled = true;
            btnReset.Enabled = true;

            DoRowDoubleClick(view, pt);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Program.thread_login = new Thread(new ThreadStart(Program.openLogin));
            Program.thread_login.SetApartmentState(ApartmentState.STA);
            Program.thread_login.Start();
            this.Close();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_ThongKeSuaChua();

            splitContainerControlRight.Panel2.Controls.Clear();
            splitContainerControlRight.Panel2.Controls.Add(mainComponent);
            mainComponent.Dock = DockStyle.Fill;

            btnSave.Enabled = false;
            btnReset.Enabled = false;
            btnChange.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}