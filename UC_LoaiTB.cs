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
    public partial class UC_LoaiTB : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        LoaiThietBi loaithietbi;
        bool f_update = false;

        public UC_LoaiTB()
        {
            InitializeComponent();
        }

        public UC_LoaiTB(string id)
        {
            InitializeComponent();
            txtMa.Enabled = false;
            f_update = true;
            loaithietbi = db.LoaiThietBis.FirstOrDefault(p => p.MaLoaiTB == id);
            load();
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
                loaithietbi = new LoaiThietBi();
                loaithietbi.MaLoaiTB = txtMa.Text;
                loaithietbi.TenLoaiTB = txTen.Text;
                loaithietbi.MoTa = txtMoTa.Text;
                loaithietbi.deleted = false;

                db.LoaiThietBis.InsertOnSubmit(loaithietbi);
                db.SubmitChanges();
                MessageBox.Show("Seccess", "Message", MessageBoxButtons.OK);
                Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Mã đã tồn tại", "Message", MessageBoxButtons.OK);
            }
        }

        private void update()
        {
            try
            {
                loaithietbi.MaLoaiTB = txtMa.Text;
                loaithietbi.TenLoaiTB = txTen.Text;
                loaithietbi.MoTa = txtMoTa.Text;

                db.SubmitChanges();
                MessageBox.Show("Seccess", "Message", MessageBoxButtons.OK);
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail", "Message", MessageBoxButtons.OK);
            }
        }

        public void load()
        {
            try
            {
                txtMa.Text = loaithietbi.MaLoaiTB;
                txTen.Text = loaithietbi.TenLoaiTB;
                txtMoTa.Text = loaithietbi.MoTa;
            }
            catch (NullReferenceException ex)
            { }
        }

        public void Dispose()
        {
            if (f_update == false)
            {
                txtMa.ResetText();
                txTen.ResetText();
                txtMoTa.ResetText();
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

            result = check.checkEmpty(txtMa) && result;
            result = check.checkEmpty(txTen) && result;
            result = check.checkEmpty(txtMoTa) && result;

            return result;
        }

        private void btnCheckMaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiThietBi ltb = db.LoaiThietBis.Single(p => p.MaLoaiTB == txtMa.Text);
                MessageBox.Show("Mã đã tồn tại", "Message", MessageBoxButtons.OK);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Mã có thể dùng", "Message", MessageBoxButtons.OK);
            }
        }
    }
}
