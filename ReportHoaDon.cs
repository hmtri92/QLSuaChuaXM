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
    public partial class ReportHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        public ReportHoaDon(string id)
        {
            InitializeComponent();

            var phieuthus = from p in db.PhieuThus
                            where p.SoPhieu == id
                            select p;

            PhieuThubindingSource.DataSource = phieuthus;
        }

    }
}
