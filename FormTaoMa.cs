using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai
{
    public partial class FormTaoMa : Form
    {
        public FormTaoMa()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EncriptMD5 en = new EncriptMD5();
            txtKetQua.Text = en.encript(txtNguon.Text);
        }
    }
}
