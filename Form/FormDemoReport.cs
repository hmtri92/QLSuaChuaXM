using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace DeTai
{
    public partial class FormDemoReport : Form
    {
        public FormDemoReport()
        {
            InitializeComponent();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            //XtraReport2 report = new XtraReport2();
            //ReportHoaDon report = new ReportHoaDon("2014-12-12T05:46:15");
            //report.ShowPreview();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RP_Kho report = new RP_Kho();
            report.Print();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            RP_Kho report = new RP_Kho();
            report.ShowDesigner();
        }
    }
}
