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
    public partial class UC_Role : UserControl, IController
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        QuyenTruyCap role;
        bool f_update = false;

        public UC_Role()
        {
            InitializeComponent();
        }

        public UC_Role(string id)
        {
            InitializeComponent();
            try
            {
                role = db.QuyenTruyCaps.Single(p => p.MaQuyen == id);
                f_update = true;
            }
            catch (Exception ex)
            {
                role = null;
            }
        }

        public void save()
        {
            if (!CheckData())
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
                role = new QuyenTruyCap();
                role.MaQuyen = txtMaQuyen.Text;
                role.TenQuyen = txtName.Text;
                role.GhiChu = txtGhiChu.Text;

                db.QuyenTruyCaps.InsertOnSubmit(role);
                db.SubmitChanges();
                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Success");
            }
        }

        private void update()
        {
            try
            {
                role.TenQuyen = txtName.Text;
                role.GhiChu = txtGhiChu.Text;
                db.SubmitChanges();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Success");
            }
        }

        public void load()
        {
            txtMaQuyen.Text = role.MaQuyen;
            txtMaQuyen.Enabled = false;
            txtName.Text = role.TenQuyen;
            txtGhiChu.Text = role.GhiChu;
        }

        public void Dispose()
        {
            if (f_update == false)
            {
                txtGhiChu.ResetText();
                txtName.ResetText();
                txtMaQuyen.ResetText();
            }
            else
                load();
        }

        private bool CheckData()
        {
            bool result = true;

            Check check = new Check();
            result = check.checkEmpty(txtMaQuyen) && result;
            result = check.checkEmpty(txtName) && result;
            result = check.checkEmpty(txtGhiChu) && result;

            return result;
        }

        private void btnCheckMaCV_Click(object sender, EventArgs e)
        {
            try
            {
                QuyenTruyCap a = db.QuyenTruyCaps.Single(p => p.MaQuyen == txtMaQuyen.Text);
                MessageBox.Show("User đã tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("User có thể dùng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void UC_Role_Load(object sender, EventArgs e)
        {
            if (f_update == true)
                load();
        }
    }
}
