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
    public partial class FormLookXe : DevExpress.XtraEditors.XtraForm
    {
        public Xe xe;

        public FormLookXe()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String value = txtSearch.Text;
            SCXMdbDataContext db = new SCXMdbDataContext();

            var khachhangs = from p in db.Xes
                             where p.deleted == false && (p.MaXe.Contains(value) || p.LoaiXe.TenLXe.Contains(value))
                             select p;

            gridMain.DataSource = khachhangs;
            gridview.PopulateColumns();

            gridview.Columns["MaXe"].Caption = "Số xe";
            gridview.Columns["MauXe"].Caption = "Màu xe";
            gridview.Columns["MaLXe"].Visible = false;
            gridview.Columns["deleted"].Visible = false;
            gridview.Columns["LoaiXe"].Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                int row = gridview.GetSelectedRows()[0];

                xe = gridview.GetRow(row) as Xe;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnSearch_Click(null, null);
        }

        private void gridMain_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
        }
    }
}