using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace DeTai.report
{
    public partial class RP_ThongKeSuaChua : DevExpress.XtraReports.UI.XtraReport
    {
        SCXMdbDataContext db = new SCXMdbDataContext();
        public RP_ThongKeSuaChua()
        {
            InitializeComponent();
        }

    }
}
