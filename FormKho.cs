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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Data.SqlClient;

namespace DeTai
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        UserControl mainComponent;
        int numpage = 1;
        int f_Entity = 0;

        const int THIET_BI = 1;
        const int NSX = 2;
        const int LOAI_THIET_BI = 3;

        public FormKho()
        {
            InitializeComponent();
        }

        private void setView()
        {
            splitContainerControlRight.Panel2.Controls.Clear();

            splitContainerControlRight.Panel2.Controls.Add(panelMain);
            panelMain.Dock = DockStyle.Fill;

            btnSave.Enabled = false;
            btnReset.Enabled = false;
            btnChange.Enabled = true;
            btnDelete.Enabled = true;

            btnDelete.Enabled = true;
            btnNext.Enabled = true;
            btnRe.Enabled = true;
            txtpage.Enabled = true;
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

        private void btnXemThietBi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != THIET_BI)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                if (numpage < 1)
                    return;
                f_Entity = THIET_BI;

                SCXMdbDataContext db = new SCXMdbDataContext();

                var thietbis = from p in db.ThietBis
                               where p.deleted == false
                               select new
                               {
                                   ID = p.MaThietBi,
                                   tenTB = p.TenThietBi,
                                   quycach = p.QuyCach,
                                   donvi = p.DonVi,
                                   soluong = p.SoLuong,
                                   min = p.min,
                                   gianhap = p.GiaNhap,
                                   dongia = p.DonGia,
                                   baohanh = p.BaoHanh,
                                   nsx = p.NhaSanXuat1.TenNSX,
                                   loaithietbi = p.LoaiThietBi.TenLoaiTB
                               };
                int n = thietbis.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = thietbis.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã thiết bị";
                gridView.Columns["tenTB"].Caption = "Tên thiết bị";
                gridView.Columns["quycach"].Caption = "Quy cách";
                gridView.Columns["donvi"].Caption = "Đơn vị";
                gridView.Columns["soluong"].Caption = "Số lượng";
                gridView.Columns["min"].Caption = "Tối thiểu";
                gridView.Columns["gianhap"].Caption = "Giá nhập";
                gridView.Columns["dongia"].Caption = "Đơn giá";
                gridView.Columns["baohanh"].Caption = "Bảo hành";
                gridView.Columns["nsx"].Caption = "NSX";
                gridView.Columns["loaithietbi"].Caption = "Loại thiêt bị";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnXemNSX_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != NSX)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                if (numpage < 1)
                    return;
                f_Entity = NSX;

                SCXMdbDataContext db = new SCXMdbDataContext();

                var nhasanxuats = from p in db.NhaSanXuats
                                  where p.deleted == false
                                  select new
                                  {
                                      ID = p.MaNSX,
                                      tenNSX = p.TenNSX,
                                      diachi = p.DiaChi,
                                      sodienthoai = p.SoDienThoai
                                  };
                int n = nhasanxuats.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = nhasanxuats.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã nhà sản xuất";
                gridView.Columns["tenNSX"].Caption = "Tên";
                gridView.Columns["diachi"].Caption = "Địa chỉ";
                gridView.Columns["sodienthoai"].Caption = "Số điện thoại";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnXemLTB_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                setView();
                if (f_Entity != LOAI_THIET_BI)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }
                if (numpage < 1)
                    return;
                f_Entity = LOAI_THIET_BI;

                SCXMdbDataContext db = new SCXMdbDataContext();

                var loaithietbis = from p in db.LoaiThietBis
                                   where p.deleted == false
                                   select new
                                   {
                                       ID = p.MaLoaiTB,
                                       ten = p.TenLoaiTB,
                                       mota = p.MoTa,
                                   };
                int n = loaithietbis.Count();
                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = loaithietbis.Skip(numpage * 25 - 25).Take(25);
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã loại thiết bị";
                gridView.Columns["ten"].Caption = "Tên";
                gridView.Columns["mota"].Caption = "Mô tả";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnThemTB_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_ThietBi();
            setAddOrChange();
        }

        private void btnThemNSX_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_NSX();
            setAddOrChange();
        }

        private void btnThemLTB_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_LoaiTB();
            setAddOrChange();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                IController b = (IController)mainComponent;
                b.Dispose();
            }
            catch (NullReferenceException ex) { }
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
                    case THIET_BI:
                        mainComponent = new UC_ThietBi(id);
                        break;
                    case NSX:
                        mainComponent = new UC_NSX(id);
                        break;
                    case LOAI_THIET_BI:
                        mainComponent = new UC_LoaiTB(id);
                        break;
                }
                setAddOrChange();
            }
            catch (IndexOutOfRangeException ex) { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            switch (f_Entity)
            {
                case THIET_BI:
                    deleteThietBi(gridView);
                    break;
                case NSX:
                    deleteNSX(gridView);
                    break;
                case LOAI_THIET_BI:
                    deleteLoaiThietBi(gridView);
                    break;
            }
        }

        private void deleteLoaiThietBi(object sender)
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
                    LoaiThietBi loaithietbi = db.LoaiThietBis.Single(p => p.MaLoaiTB == id);
                    loaithietbi.deleted = true;
                    db.SubmitChanges();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
                }
                catch (Exception ex) { }


                view.DeleteRow(row);
            }
            catch (Exception ex) { }
        }

        private void deleteNSX(object sender)
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
                    NhaSanXuat nsx = db.NhaSanXuats.Single(p => p.MaNSX == id);
                    nsx.deleted = true;
                    db.SubmitChanges();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
                }
                catch (Exception ex) { }

                view.DeleteRow(row);
            }
            catch (Exception ex)
            { }
        }

        private void deleteThietBi(object sender)
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
                    ThietBi thietbi = db.ThietBis.Single(p => p.MaThietBi == id);
                    thietbi.deleted = true;
                    db.SubmitChanges();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
                }
                catch (Exception ex) { }


                view.DeleteRow(row);
            }
            catch (NullReferenceException ex)
            { }
            catch (Exception ex)
            { }
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
                case THIET_BI:
                    searchThietBi();
                    break;
                case NSX:
                    searchNSX();
                    break;
                case LOAI_THIET_BI:
                    searchLoaiThietBi();
                    break;
            }
        }

        private void searchLoaiThietBi()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var loaithietbis = from p in db.LoaiThietBis
                                   where p.deleted == false && p.TenLoaiTB.Contains(value)
                                   select new
                                   {
                                       ID = p.MaLoaiTB,
                                       ten = p.TenLoaiTB,
                                       mota = p.MoTa,
                                   };

                gridMain.DataSource = loaithietbis;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã loại thiết bị";
                gridView.Columns["ten"].Caption = "Tên";
                gridView.Columns["mota"].Caption = "Mô tả";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void searchNSX()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var nhasanxuats = from p in db.NhaSanXuats
                                  where p.deleted == false && p.TenNSX.Contains(value)
                                  select new
                                  {
                                      ID = p.MaNSX,
                                      tenNSX = p.TenNSX,
                                      diachi = p.DiaChi,
                                      sodienthoai = p.SoDienThoai
                                  };

                gridMain.DataSource = nhasanxuats;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã nhà sản xuất";
                gridView.Columns["tenNSX"].Caption = "Tên";
                gridView.Columns["diachi"].Caption = "Địa chỉ";
                gridView.Columns["sodienthoai"].Caption = "Số điện thoại";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void searchThietBi()
        {
            try
            {
                String value = txtSearch.Text;
                SCXMdbDataContext db = new SCXMdbDataContext();

                var thietbis = from p in db.ThietBis
                               where p.deleted == false && (p.TenThietBi.Contains(value) || p.QuyCach.Contains(value) || p.NhaSanXuat1.TenNSX.Contains(value))
                               select new
                                {
                                    ID = p.MaThietBi,
                                    tenTB = p.TenThietBi,
                                    quycach = p.QuyCach,
                                    donvi = p.DonVi,
                                    soluong = p.SoLuong,
                                    gianhap = p.GiaNhap,
                                    dongia = p.DonGia,
                                    baohanh = p.BaoHanh,
                                    nsx = p.NhaSanXuat1.TenNSX,
                                    loaithietbi = p.LoaiThietBi.TenLoaiTB
                                };

                gridMain.DataSource = thietbis;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã thiết bị";
                gridView.Columns["tenTB"].Caption = "Tên thiết bị";
                gridView.Columns["quycach"].Caption = "Quy cách";
                gridView.Columns["donvi"].Caption = "Đơn vị";
                gridView.Columns["soluong"].Caption = "Số lượng";
                gridView.Columns["gianhap"].Caption = "Giá nhập";
                gridView.Columns["dongia"].Caption = "Đơn giá";
                gridView.Columns["baohanh"].Caption = "Bảo hành";
                gridView.Columns["nsx"].Caption = "NSX";
                gridView.Columns["loaithietbi"].Caption = "Loại thiêt bị";
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

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            switch (f_Entity)
            {
                case THIET_BI:
                    changeThietBi(view, pt);
                    break;
                case NSX:
                    changeNSX(view, pt);
                    break;
                case LOAI_THIET_BI:
                    changeLoaiThietBi(view, pt);
                    break;
            }
        }

        private void changeLoaiThietBi(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_LoaiTB(id);
                setAddOrChange();
            }
        }

        private void changeNSX(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_NSX(id);
                setAddOrChange();
            }
        }

        private void changeThietBi(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "ID").ToString();
                mainComponent = new UC_ThietBi(id);
                setAddOrChange();
            }
        }

        private void gridMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                return;
            }

            btnDelete_Click(null, null);
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
                case THIET_BI:
                    btnThemTB_LinkClicked(null, null);
                    break;
                case NSX:
                    btnXemNSX_LinkClicked(null, null);
                    break;
                case LOAI_THIET_BI:
                    btnXemLTB_LinkClicked(null, null);
                    break;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            numpage++;
            txtpage.Text = numpage.ToString();

            switch (f_Entity)
            {
                case THIET_BI:
                    btnThemTB_LinkClicked(null, null);
                    break;
                case NSX:
                    btnXemNSX_LinkClicked(null, null);
                    break;
                case LOAI_THIET_BI:
                    btnXemLTB_LinkClicked(null, null);
                    break;
            }
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            this.Text = "User: " + Program.user.UserName;
            checkThietBi();
        }

        private void checkThietBi()
        {
            try
            {
                setView();
                f_Entity = THIET_BI;

                SCXMdbDataContext db = new SCXMdbDataContext();

                var thietbis = from p in db.ThietBis
                               where p.deleted == false && p.SoLuong <= p.min
                               select new
                               {
                                   ID = p.MaThietBi,
                                   tenTB = p.TenThietBi,
                                   quycach = p.QuyCach,
                                   donvi = p.DonVi,
                                   soluong = p.SoLuong,
                                   min = p.min,
                                   gianhap = p.GiaNhap,
                                   dongia = p.DonGia,
                                   baohanh = p.BaoHanh,
                                   nsx = p.NhaSanXuat1.TenNSX,
                                   loaithietbi = p.LoaiThietBi.TenLoaiTB
                               };
                int n = thietbis.Count();
                if (n < 0)
                {
                    MessageBox.Show("Số lượng thiết bị trong kho đủ", "Message", MessageBoxButtons.OK);
                    return;
                }
                String mess = "Có " + n + " thiết bị gần hết";
                MessageBox.Show(mess, "Message", MessageBoxButtons.OK);

                gridMain.DataSource = thietbis;
                gridView.PopulateColumns();

                gridView.Columns["ID"].Caption = "Mã thiết bị";
                gridView.Columns["tenTB"].Caption = "Tên thiết bị";
                gridView.Columns["quycach"].Caption = "Quy cách";
                gridView.Columns["donvi"].Caption = "Đơn vị";
                gridView.Columns["soluong"].Caption = "Số lượng";
                gridView.Columns["min"].Caption = "Tối thiểu";
                gridView.Columns["gianhap"].Caption = "Giá nhập";
                gridView.Columns["dongia"].Caption = "Đơn giá";
                gridView.Columns["baohanh"].Caption = "Bảo hành";
                gridView.Columns["nsx"].Caption = "NSX";
                gridView.Columns["loaithietbi"].Caption = "Loại thiêt bị";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception ex) { }
        }

        private void btnTaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            mainComponent = new UC_ChangePassWord();
            setAddOrChange();
        }

        private void btnCheckThietBi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            checkThietBi();
        }
    }
}