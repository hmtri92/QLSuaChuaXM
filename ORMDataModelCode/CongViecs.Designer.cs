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

    public partial class CongViecs : XPLiteObject
    {
        string fMaCV;
        [Key]
        [Size(128)]
        public string MaCV
        {
            get { return fMaCV; }
            set { SetPropertyValue<string>("MaCV", ref fMaCV, value); }
        }
        string fTenCV;
        [Size(SizeAttribute.Unlimited)]
        public string TenCV
        {
            get { return fTenCV; }
            set { SetPropertyValue<string>("TenCV", ref fTenCV, value); }
        }
        string fMoTa;
        [Size(SizeAttribute.Unlimited)]
        public string MoTa
        {
            get { return fMoTa; }
            set { SetPropertyValue<string>("MoTa", ref fMoTa, value); }
        }
        double fTienCong;
        public double TienCong
        {
            get { return fTienCong; }
            set { SetPropertyValue<double>("TienCong", ref fTienCong, value); }
        }
        bool fdeleted;
        public bool deleted
        {
            get { return fdeleted; }
            set { SetPropertyValue<bool>("deleted", ref fdeleted, value); }
        }
        [Association(@"CongViecSuaChuaReferencesCongViecs", typeof(CongViecSuaChua))]
        public XPCollection<CongViecSuaChua> CongViecSuaChuas { get { return GetCollection<CongViecSuaChua>("CongViecSuaChuas"); } }
        [Association(@"MucDoThanhThaoReferencesCongViecs", typeof(MucDoThanhThao))]
        public XPCollection<MucDoThanhThao> MucDoThanhThaos { get { return GetCollection<MucDoThanhThao>("MucDoThanhThaos"); } }
    }

}
