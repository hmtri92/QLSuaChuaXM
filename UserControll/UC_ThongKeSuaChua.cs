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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DeTai
{
    public partial class UC_ThongKeSuaChua : UserControl
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        int numpage = 1;
        bool f_next = false;
        UserControl mainComponent;

        public UC_ThongKeSuaChua()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(panelPhieuThu);

                DateTime startTime = dtStart.DateTime;
                DateTime endTime = dtEnd.DateTime;

                if (f_next == false)
                {
                    numpage = 1;
                    txtpage.Text = numpage.ToString();
                }

                if (numpage < 1)
                    return;

                var phieuThus = from p in db.PhieuThus
                                where p.deleted == false && p.NgayLapPhieu >= startTime && p.NgayLapPhieu <= endTime
                                select p; 

                int n = phieuThus.Count();
                lblSoxe.Text = n.ToString();

                double tongtien = 0;
                if (n > 0)
                {
                    foreach (Object item in phieuThus)
                    {
                        PhieuThus phieuThu = item as PhieuThus;
                        tongtien += phieuThu.SoTien;
                    }
                }

                lblTongThu.Text = tongtien.ToString();

                if ((numpage * 25) > n)
                {
                    btnNext.Enabled = false;
                }

                gridMain.DataSource = phieuThus.Skip(numpage * 25 - 25).Take(25);

                gridView.PopulateColumns();

                gridView.Columns["SoPhieu"].Caption = "Mã phiếu thu";
                gridView.Columns["NgayLapPhieu"].Caption = "Ngày lập phiếu";
                gridView.Columns["UserName"].Caption = "Người lập phiếu";
                gridView.Columns["SoTien"].Caption = "Tổng tiền";
                gridView.Columns["MaSC"].Visible = false;
                gridView.Columns["SuaChua"].Visible = false;
                gridView.Columns["TaiKhoan"].Visible = false;
                gridView.Columns["deleted"].Visible = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Kiểm tra kết nối csdl", "Error", MessageBoxButtons.OK);
            }
            catch (Exception) { }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            f_next = true;
            numpage++;
            txtpage.Text = numpage.ToString();
            btnOk_Click(null, null);
        }

        private void btnRe_Click(object sender, EventArgs e)
        {
            if (numpage == 1)
            {
                btnRe.Enabled = false;
                return;
            }
            f_next = true;

            numpage--;
            txtpage.Text = numpage.ToString();
            btnOk_Click(null, null);
        }

        private void gridMain_DoubleClick(object sender, EventArgs e)
        {
            GridControl grid = sender as GridControl;

            Point pt = grid.PointToClient(Control.MousePosition);

            GridView view = (GridView)grid.FocusedView;

            GridHitInfo info = view.CalcHitInfo(pt);

            if (info.InRow || info.InRowCell)
            {
                String id = view.GetRowCellValue(info.RowHandle, "MaSC").ToString();
                mainComponent = new UC_updateHoaDon(id);

                panelMain.Controls.Clear();
                panelMain.Controls.Add(mainComponent);

                mainComponent.Dock = DockStyle.Fill;
            }
        }
    }
}
