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
    public partial class FormNhapSoTien : DevExpress.XtraEditors.XtraForm
    {
        public double sotien = 0;

        public FormNhapSoTien()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            sotien = Double.Parse(txtSoTien.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}