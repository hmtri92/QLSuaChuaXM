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
    public partial class UC_ThemXe : UserControl, IController
    {
        Xe xe;
        SCXMdbDataContext db = new SCXMdbDataContext();
        bool f_update = false;

        public UC_ThemXe()
        {
            InitializeComponent();
        }

        public UC_ThemXe(string id)
        {
            InitializeComponent();
            try
            {
                xe = db.Xes.Single(p => p.MaXe == id);
            }
            catch (InvalidOperationException ex)
            { }
            txtPlate.Enabled = false;
            f_update = true;
            lblTitle.Text = "Sửa thông tin xe";
        }

        private bool checkData()
        {
            bool result = true;
            Check check = new Check();

            result = check.checkEmpty(txtColor) && result;
            result = check.checkEmpty(txtPlate) && result;
            result = check.checkEmpty(lookLoaiXe) && result;

            return result;
        }

        public void save()
        {
            if (!checkData())
                return;
            if (f_update == false)
            {
                insert();
            }
            else
                update();
        }

        private void insert()
        {
            try
            {
                try
                {
                    xe = db.Xes.Single(p => p.MaXe == txtPlate.Text);
                    if (xe.deleted == true)
                    {
                        xe.deleted = false;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    xe = new Xe();
                    xe.MaXe = txtPlate.Text;
                    xe.deleted = false;
                    xe.LoaiXe = (LoaiXe)lookLoaiXe.GetSelectedDataRow();
                    xe.MauXe = txtColor.Text;
                    db.Xes.InsertOnSubmit(xe);
                }

                db.SubmitChanges();
                MessageBox.Show("success");
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void update()
        {
            try
            {
                xe.LoaiXe = (LoaiXe)lookLoaiXe.GetSelectedDataRow();
                xe.MauXe = txtColor.Text;
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
            txtColor.ResetText();
            txtPlate.ResetText();
        }

        public void load()
        {
            try
            {
                txtPlate.Text = xe.MaXe;
                txtColor.Text = xe.MauXe;
                lookLoaiXe.DataBindings.Control.Text = xe.LoaiXe.TenLXe;
            }
            catch (NullReferenceException ex)
            { }
        }

        private void texbox_click(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void UC_ThemXe_Load(object sender, EventArgs e)
        {
            var loaixes = from p in db.LoaiXes
                          where p.deleted == false
                          select p;
            loaiXeBindingSource.DataSource = loaixes;

            if (f_update)
                load();
        }
    }
}
