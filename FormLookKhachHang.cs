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

namespace DeTai
{
    public partial class FormLookKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public KhachHang khachhang;
        public FormLookKhachHang()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String value = txtSearch.Text;
            SCXMdbDataContext db = new SCXMdbDataContext();

            var khachhangs = from p in db.KhachHangs
                             where p.deleted == false && (p.SoDienThoai.Contains(value) || p.TenKH.Contains(value) || p.DiaChi.Contains(value))
                             select p;

            gridMain.DataSource = khachhangs;
            gridview.PopulateColumns();

            gridview.Columns["MaKH"].Visible = false;
            gridview.Columns["TenKH"].Caption = "Tên khách hàng";
            gridview.Columns["SoDienThoai"].Caption = "Số điện thoại";
            gridview.Columns["DiaChi"].Caption = "Địa chỉ";
            gridview.Columns["deleted"].Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int row = gridview.GetSelectedRows()[0];

                khachhang = gridview.GetRow(row) as KhachHang;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void gridMain_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnSearch_Click(null, null);
        }
    }
}