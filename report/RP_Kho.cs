using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTai
{
    public partial class RP_Kho : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_Kho()
        {
            InitializeComponent();

            SCXMdbDataContext db = new SCXMdbDataContext();
            var thietbis = from p in db.ThietBis
                           where p.deleted == false && p.SoLuong <= p.min
                           select p;
            ThietBibindingSource.DataSource = thietbis;
        }
    }
}
