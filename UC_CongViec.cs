using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai
{
    public partial class UC_CongViec : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        CongViec congviec;
        bool f_update = false;

        public UC_CongViec()
        {
            InitializeComponent();
        }

        public UC_CongViec(string id)
        {
            InitializeComponent();

            try
            {
                congviec = db.CongViecs.Single(p => p.MaCV == id);
                load();
            }
            catch (InvalidOperationException ex)
            {}
            catch (Exception ex) { }
            txtMaCV.Enabled = false;
            lblTitle.Text = "Sửa thông tin công việc";
            f_update = true;
        }

        public void load()
        {
            txtMaCV.Text = congviec.MaCV;
            txtMoTa.Text = congviec.MoTa;
            txtTenCV.Text = congviec.TenCV;
            txtTienCong.Text = congviec.TienCong.ToString();
        }

        public void save()
        {
            if (!checkData())
            {
                return;
            }

            if (f_update == false)
                insert();
            else
                update();
            
        }

        private void insert()
        {
            try
            {
                congviec = db.CongViecs.Single(p => p.MaCV == txtMaCV.Text);
                MessageBox.Show("Mã đã tồn tại");
                return;
            }
            catch (Exception ex)
            {
                congviec = new CongViec();
                congviec.MaCV = txtMaCV.Text;
                congviec.TenCV = txtTenCV.Text;
                congviec.TienCong = Double.Parse(txtTienCong.Text);
                congviec.MoTa = txtMoTa.Text;
                congviec.deleted = false;

                db.CongViecs.InsertOnSubmit(congviec);
                db.SubmitChanges();
                MessageBox.Show("Success");
            }
        }

        private void update()
        {
            try
            {
                congviec.TenCV = txtTenCV.Text;
                congviec.TienCong = Double.Parse(txtTienCong.Text);
                congviec.MoTa = txtMoTa.Text;
                db.SubmitChanges();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            
        }

        public void Dispose()
        {
            if (f_update == false)
                clear();
            else
                reset();
        }

        private void clear()
        {
            txtMaCV.ResetText();
            txtMoTa.ResetText();
            txtTenCV.ResetText();
            txtTienCong.ResetText();
        }

        private void reset()
        {
            txtMaCV.Text = congviec.MaCV;
            txtMoTa.Text = congviec.MoTa;
            txtTenCV.Text = congviec.TenCV;
            txtTienCong.Text = congviec.TienCong.ToString();
        }

        private bool checkData()
        {
            bool result = true;

            Check check = new Check();
            result = check.checkEmpty(txtMaCV) && result;
            result = check.checkEmpty(txtTenCV) && result;
            result = check.checkEmpty(txtTienCong) && result;
            result = check.checkEmpty(txtMoTa) && result;

            return result;
        }

        private void texBox_Click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void btnCheckMaCV_Click(object sender, EventArgs e)
        {
            try
            {
                CongViec a = db.CongViecs.Single(p => p.MaCV == txtMaCV.Text);
                MessageBox.Show("Mã đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã có thể dùng", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
