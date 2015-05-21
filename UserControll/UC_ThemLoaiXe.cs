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
    public partial class UC_ThemLoaiXe : UserControl, IController
    {
        LoaiXe loaixe;
        SCXMdbDataContext db = new SCXMdbDataContext();
        bool f_update = false;

        public UC_ThemLoaiXe()
        {
            InitializeComponent();
        }

        public UC_ThemLoaiXe(string id)
        {
            InitializeComponent();
            loaixe = db.LoaiXes.Single(p => p.MaLXe == id);
            txtMaLXe.Enabled = false;
            f_update = true;
            lblTitle.Text = "Sửa thông tin loại xe";
            load();
        }

        public void save()
        {
            try
            {
                if (!checkData())
                {
                    return;
                }

                if (f_update == false)
                    insert();
                else
                    change();

                MessageBox.Show("Success");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void insert()
        {
            try
            {
                loaixe = db.LoaiXes.Single(p => p.MaLXe == txtMaLXe.Text);
                MessageBox.Show("Mã loại xe đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            catch (InvalidOperationException ex)
            {
                try
                {
                    loaixe = new LoaiXe();
                    loaixe.MaLXe = txtMaLXe.Text;
                    loaixe.TenLXe = txtTenLXe.Text;
                    loaixe.MoTa = txtMoTa.Text;
                    loaixe.deleted = false;

                    db.LoaiXes.InsertOnSubmit(loaixe);
                    db.SubmitChanges();
                }
                catch (Exception e) { }
            }
            catch (Exception ex) { }
        }

        private void change()
        {
            loaixe.TenLXe = txtTenLXe.Text;
            loaixe.MoTa = txtMoTa.Text;
            db.SubmitChanges();
        }

        public void load()
        {
            txtMaLXe.Text = loaixe.MaLXe;
            txtMoTa.Text = loaixe.MoTa;
            txtTenLXe.Text = loaixe.TenLXe;
        }

        public void Dispose()
        {
            if(f_update)
            {
                load();
            }
            else
            {
                txtMoTa.ResetText();
                txtMaLXe.ResetText();
                txtTenLXe.ResetText();
            }
        }

        private bool checkData()
        {
            Color color = Color.Khaki;
            bool result = true;

            Check check = new Check();

            result = check.checkEmpty(txtMaLXe) && result;
            result = check.checkEmpty(txtMoTa) && result;
            result = check.checkEmpty(txtTenLXe) && result;

            return result;
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void btnCheckMaCV_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiXe a = db.LoaiXes.Single(p => p.MaLXe == txtMaLXe.Text);
                MessageBox.Show("Mã đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Mã có thể dùng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void UC_ThemLoaiXe_Load(object sender, EventArgs e)
        {

        }
    }
}
