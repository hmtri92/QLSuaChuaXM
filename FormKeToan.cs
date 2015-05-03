using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraGrid.Views.Grid;
using System.Xml;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;
using System.Data.SqlClient;


namespace DeTai
{
    public partial class FormKeToan : XtraForm
    {
        UserControl mainComponent;
        int numpage = 1;
        int f_Entity = 0;

        const int SUACHUA = 1;
        const int KHACHHANG = 2;
        const int XE = 3;
        const int LOAIXE = 4;
        const int CONGVIEC = 5;

        public FormKeToan()
        {
            InitializeComponent();
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

        private void setView()
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

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            switch (f_Entity)
            {
                case SUACHUA:
                    changeSuaChua(view, pt);
                    break;
                case KHACHHANG:
                    changeKhachHang(view, pt);
                    break;
                case XE:
                    changeXe(view, pt);
                    break;
                case LOAIXE:
                    changeLXe(view, pt);
                    break;
                case CONGVIEC:
                    changeCongViec(view, pt);
                    break;
            }
        }

        private void changeCongViec(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_CongViec(id);
                setAddOrChange();
            }
        }

        private void changeSuaChua(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_updateHoaDon(id);
                setAddOrChange();
            }
        }

        private void changeKhachHang(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_ThemKH(id);
                setAddOrChange();
            }
        }

        private void changeXe(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_ThemXe(id);
                setAddOrChange();
            }
        }

        private void changeLXe(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_ThemLoaiXe(id);
                setAddOrChange();
            }
        }
        

        /*===========================================================================================
         * */

        private void FormKeToan_Load(object sender, EventArgs e)
        {
            mainComponent = new UC_HoaDon();
            setAddOrChange();
            this.Text = "User: " + Program.user.UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                IController b = (IController)mainComponent;
                b.save();
            }
            catch (NullReferenceException ex) { }
        }

        private void btnXemHoaDon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != SUACHUA)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                if (numpage < 1)
                    return;
                f_Entity = SUACHUA;

                SCXMdbDataContext db = new SCXMdbDataContext();

                var suachuas = from p in db.SuaChuas
                               where p.deleted == false
                               select new
                               {
                                   ID = p.MaSC,
                                   date = p.NgaySC,
                                   tinhtrang = p.Tinhtrang,
                                   xe = p.Xe_Khach.MaXe,
                                   tenkhachhang = p.Xe_Khach.KhachHang.TenKH,
                                   maKH = p.Xe_Khach.KhachHang.MaKH
                               };
                int n = suachuas.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = suachuas.Skip(numpage * 25 - 25).Take(25);

                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã sửa chữa";
                gridView.Columns["date"].Caption = "Ngày sửa chữa";
                gridView.Columns["tinhtrang"].Caption = "Đã sửa xong";
                gridView.Columns["xe"].Caption = "Số xe";
                gridView.Columns["tenkhachhang"].Caption = "Khách hàng";
                gridView.Columns["maKH"].Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
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

        private void deleteSuaChua(object sender)
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

                SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    SuaChua suachua = db.SuaChuas.Single(p => p.MaSC == id);
                    suachua.deleted = true;
                    db.SubmitChanges();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Không tìm thấy");
                }

                view.DeleteRow(row);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void deleteXe(object sender)
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

                SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    Xe xe = db.Xes.Single(p => p.MaXe == id);
                    xe.deleted = true;
                    db.SubmitChanges();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Không tìm thấy");
                }

                view.DeleteRow(row);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void deleteLoaiXe(object sender)
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

                SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    LoaiXe loaixe = db.LoaiXes.Single(p => p.MaLXe == id);
                    loaixe.deleted = true;
                    db.SubmitChanges();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Không tìm thấy");
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

        private void txtpage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                numpage = int.Parse(txtpage.Text);
                btnXemHoaDon_LinkClicked(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (f_Entity)
            {
                case SUACHUA:
                    deleteSuaChua(gridView);
                    break;
                case XE:
                    deleteXe(gridView);
                    break;
                case LOAIXE:
                    deleteLoaiXe(gridView);
                    break;
                case CONGVIEC:
                    deletecongViec(gridView);
                    break;
            }
        }

        private void deletecongViec(object sender)
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

                SCXMdbDataContext db = new SCXMdbDataContext();
                try
                {
                    CongViec congviec = db.CongViecs.Single(p => p.MaCV == id);
                    congviec.deleted = true;
                    db.SubmitChanges();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Không tìm thấy");
                }

                view.DeleteRow(row);
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
                case SUACHUA:
                    btnXemHoaDon_LinkClicked(null, null);
                    break;
                case XE:
                    btnXemXe_LinkClicked(null, null);
                    break;
                case LOAIXE:
                    btnXemLXe_LinkClicked(null, null);
                    break;
                case CONGVIEC:
                    btnXemCV_LinkClicked(null, null);
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numpage ++;
            txtpage.Text = numpage.ToString();

            switch (f_Entity)
            {
                case SUACHUA:
                    btnXemHoaDon_LinkClicked(null, null);
                    break;
                case XE:
                    btnXemXe_LinkClicked(null, null);
                    break;
                case LOAIXE:
                    btnXemLXe_LinkClicked(null, null);
                    break;
                case CONGVIEC:
                    btnXemCV_LinkClicked(null, null);
                    break;
            }
            
        }

        private void btnThemHoaDon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_HoaDon();
            setAddOrChange();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                IController b = (IController)mainComponent;
                b.Dispose();
            }
            catch (NullReferenceException ex) { }
        }

        private void btnTimKhach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainerControlRight.Panel2.Controls.Clear();
            setView();
            f_Entity = KHACHHANG;

            txtSearch.Focus();
        }

        private void btnXemXe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != XE)
                {
                    numpage = 1;
                    txtpage.Text = "" + 1;
                }

                if (numpage < 1)
                    return;

                f_Entity = XE;

                SCXMdbDataContext db = new SCXMdbDataContext();

                var xes = from p in db.Xes
                          where p.deleted == false
                          select new
                          {
                              ID = p.MaXe,
                              mauxe = p.MauXe,
                              loaixe = p.LoaiXe.TenLXe
                          };

                int n = xes.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = xes.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Số xe";
                gridView.Columns["mauxe"].Caption = "Màu xe";
                gridView.Columns["loaixe"].Caption = "Loại xe";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = true;

                int row = gridView.GetSelectedRows()[0];
                String id = gridView.GetRowCellValue(row, "ID").ToString();

                switch (f_Entity)
                {
                    case SUACHUA:
                        mainComponent = new UC_updateHoaDon(id);
                        break;
                    case KHACHHANG:
                        mainComponent = new UC_ThemKH(id);
                        break;
                    case XE:
                        mainComponent = new UC_ThemXe(id);
                        break;
                    case LOAIXE:
                        mainComponent = new UC_ThemLoaiXe(id);
                        break;
                    case CONGVIEC:
                        mainComponent = new UC_CongViec(id);
                        break;
                }
                setAddOrChange();
            }
            catch (IndexOutOfRangeException ex)
            { }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch_Click(null, null);
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
                case SUACHUA:
                    searchSuaChua();
                    break;
                case KHACHHANG:
                    searchKhachHang();
                    break;
                case XE:
                    searchXe();
                    break;
                case LOAIXE:
                    searchLXe();
                    break;
                case CONGVIEC:
                    searchCongViec();
                    break;
            }
        }

        private void searchCongViec()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var congviecs = from p in db.CongViecs
                                where p.deleted == false && (p.TenCV.Contains(value) || p.MoTa.Contains(value))
                                select new
                                {
                                    ID = p.MaCV,
                                    name = p.TenCV,
                                    description = p.MoTa,
                                    money = p.TienCong
                                };
                gridMain.DataSource = congviecs;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã công việc";
                gridView.Columns["name"].Caption = "Tên công việc";
                gridView.Columns["description"].Caption = "Mô tả";
                gridView.Columns["money"].Caption = "Tiền công";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void searchLXe()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var loaixes = from p in db.LoaiXes
                              where p.deleted == false && p.TenLXe.Contains(value)
                              select new
                              {
                                  ID = p.MaLXe,
                                  name = p.TenLXe,
                                  description = p.MoTa
                              };

                gridMain.DataSource = loaixes;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã loại xe";
                gridView.Columns["name"].Caption = "Tên loại xe";
                gridView.Columns["description"].Caption = "Mô tả";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void searchXe()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var xes = from p in db.Xes
                          where p.deleted == false && (p.MaXe.Contains(value) || p.LoaiXe.TenLXe.Contains(value))
                          select new
                          {
                              ID = p.MaXe,
                              mauxe = p.MauXe,
                              loaixe = p.LoaiXe.TenLXe
                          };

                gridMain.DataSource = xes;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Số xe";
                gridView.Columns["mauxe"].Caption = "Màu xe";
                gridView.Columns["loaixe"].Caption = "Loại xe";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void searchKhachHang()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var khachhangs = from p in db.KhachHangs
                                 where p.deleted == false && (p.SoDienThoai.Contains(value) || p.TenKH.Contains(value) || p.DiaChi.Contains(value))
                                 select new
                                 {
                                     ID = p.MaKH,
                                     name = p.TenKH,
                                     phone = p.SoDienThoai,
                                     home = p.DiaChi
                                 };

                gridMain.DataSource = khachhangs;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã khách hàng";
                gridView.Columns["name"].Caption = "Tên khách hàng";
                gridView.Columns["phone"].Caption = "Số điện thoại";
                gridView.Columns["home"].Caption = "Địa chỉ";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void searchSuaChua()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var suachuas = from p in db.SuaChuas
                               where p.deleted == false &&
                               (p.Xe_Khach.KhachHang.TenKH.Contains(value) ||
                                p.Xe_Khach.Xe.MaXe.Contains(value) ||
                                p.Xe_Khach.KhachHang.SoDienThoai.Contains(value))
                               select new
                               {
                                   ID = p.MaSC,
                                   tenkhach = p.Xe_Khach.KhachHang.TenKH,
                                   soxe = p.Xe_Khach.Xe.MaXe,
                                   ngaysua = p.NgaySC,
                                   tinhtrang = p.Tinhtrang,
                                   tamthu = p.DaThu,
                                   ghichu = p.GhiChu
                               };

                gridMain.DataSource = suachuas;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Visible = false;
                gridView.Columns["tenkhach"].Caption = "Khách hàng";
                gridView.Columns["soxe"].Caption = "Số xe";
                gridView.Columns["ngaysua"].Caption = "Ngày sửa";
                gridView.Columns["tinhtrang"].Caption = "Tình trạng";
                gridView.Columns["tamthu"].Caption = "Tạm thu";
                gridView.Columns["ghichu"].Caption = "Ghi Chú";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnThemKH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_ThemKH();
            setAddOrChange();
        }

        private void btnThemXe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_ThemXe();
            setAddOrChange();
        }

        private void btnXemLXe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != LOAIXE)
                {
                    numpage = 1;
                    txtpage.Text = "" + 1;
                }


                if (numpage < 1)
                    return;

                f_Entity = LOAIXE;

                SCXMdbDataContext db = new SCXMdbDataContext();

                var loaixes = from p in db.LoaiXes
                              where p.deleted == false
                              select new
                              {
                                  ID = p.MaLXe,
                                  name = p.TenLXe,
                                  description = p.MoTa
                              };

                int n = loaixes.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = loaixes.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã loại xe";
                gridView.Columns["name"].Caption = "Tên loại xe";
                gridView.Columns["description"].Caption = "Mô tả";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnThemLXe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_ThemLoaiXe();
            setAddOrChange();
        }

        private void btnXemCV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != CONGVIEC)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }

                f_Entity = CONGVIEC;
                SCXMdbDataContext db = new SCXMdbDataContext();
                var congviecs = from p in db.CongViecs
                                where p.deleted == false
                                select new
                                {
                                    ID = p.MaCV,
                                    name = p.TenCV,
                                    description = p.MoTa,
                                    money = p.TienCong
                                };

                int n = congviecs.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = congviecs;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã công việc";
                gridView.Columns["name"].Caption = "Tên công việc";
                gridView.Columns["description"].Caption = "Mô tả";
                gridView.Columns["money"].Caption = "Tiền công";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnThemCV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_CongViec();
            setAddOrChange();
        }

        private void btnChangePass_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_ChangePassWord();
            setAddOrChange();
        }

    }
}