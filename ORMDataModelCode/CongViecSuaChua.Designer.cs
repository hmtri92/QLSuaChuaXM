//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DeTai.EF_QLSCXeMay
{

    public partial class CongViecSuaChua : XPLiteObject
    {
        string fid;
        [Key]
        [Size(128)]
        public string id
        {
            get { return fid; }
            set { SetPropertyValue<string>("id", ref fid, value); }
        }
        ChiTietSuaChua fMaCTSC;
        [Size(128)]
        [Association(@"CongViecSuaChuaReferencesChiTietSuaChua")]
        public ChiTietSuaChua MaCTSC
        {
            get { return fMaCTSC; }
            set { SetPropertyValue<ChiTietSuaChua>("MaCTSC", ref fMaCTSC, value); }
        }
        CongViecs fMaCV;
        [Size(128)]
        [Association(@"CongViecSuaChuaReferencesCongViecs")]
        public CongViecs MaCV
        {
            get { return fMaCV; }
            set { SetPropertyValue<CongViecs>("MaCV", ref fMaCV, value); }
        }
        int fsoluong;
        public int soluong
        {
            get { return fsoluong; }
            set { SetPropertyValue<int>("soluong", ref fsoluong, value); }
        }
        double fThanhTien;
        public double ThanhTien
        {
            get { return fThanhTien; }
            set { SetPropertyValue<double>("ThanhTien", ref fThanhTien, value); }
        }
        bool fdeleted;
        public bool deleted
        {
            get { return fdeleted; }
            set { SetPropertyValue<bool>("deleted", ref fdeleted, value); }
        }
    }

}
