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
using System.Xml;

namespace DeTai
{
    public partial class FormAuthenDelete : DevExpress.XtraEditors.XtraForm
    {
        SCXMdbDataContext db = new SCXMdbDataContext();

        public FormAuthenDelete()
        {
            InitializeComponent();
        }

        int dem = 0;
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                EncriptMD5 md5 = new EncriptMD5();
                String value = md5.encript(txtValue.Text);
                var role = from p in db.TaiKhoans
                           where p.Password == value && (p.QuyenTruyCap.MaQuyen == "qdelete" || p.QuyenTruyCap.MaQuyen == "qAdmin" && p.TrangThai == true)
                           select p;
                if (role.Count() > 0)
                    this.DialogResult = DialogResult.OK;
                else
                {
                    DialogResult result = MessageBox.Show("Fail, nhập lại?", "Không thành công", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        dem++;
                        if (dem > 5)
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                        return;
                    }
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnOK_Click(null, null);
            }
        }
    }
}