using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace DeTai.report
{
    public partial class RP_HoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_HoaDon(String id)
        {
            InitializeComponent();

            SCXMdbDataContext db = new SCXMdbDataContext();
            var hoadon = from p in db.PhieuThus
                         where p.deleted == false && p.SoPhieu == id
                         select p;

            PhieuThus phieuThu = db.PhieuThus.Single(p => p.SoPhieu == id);

            var cvsc = from p in db.CongViecSuaChuas
                       where p.deleted == false && p.ChiTietSuaChua.SuaChua.MaSC == phieuThu.MaSC
                       select p;
            var tbsc = from p in db.ThietBiSuaChuas
                       where p.deleted == false && p.ChiTietSuaChua.SuaChua.MaSC == phieuThu.MaSC
                       select p;

            bindingSourcePhieuThu.DataSource = hoadon;
            bindingSourceCongViecSuaChua.DataSource = cvsc;
            bindingSourceThietBiSuaChua.DataSource = tbsc;
        }

    }
}
