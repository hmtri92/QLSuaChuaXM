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

    public partial class PhieuThus : XPLiteObject
    {
        string fSoPhieu;
        [Key]
        [Size(128)]
        public string SoPhieu
        {
            get { return fSoPhieu; }
            set { SetPropertyValue<string>("SoPhieu", ref fSoPhieu, value); }
        }
        double fSoTien;
        public double SoTien
        {
            get { return fSoTien; }
            set { SetPropertyValue<double>("SoTien", ref fSoTien, value); }
        }
        DateTime fNgayLapPhieu;
        public DateTime NgayLapPhieu
        {
            get { return fNgayLapPhieu; }
            set { SetPropertyValue<DateTime>("NgayLapPhieu", ref fNgayLapPhieu, value); }
        }
        SuaChuas fMaSC;
        [Size(128)]
        [Association(@"PhieuThusReferencesSuaChuas")]
        public SuaChuas MaSC
        {
            get { return fMaSC; }
            set { SetPropertyValue<SuaChuas>("MaSC", ref fMaSC, value); }
        }
        TaiKhoans fUserName;
        [Size(128)]
        [Association(@"PhieuThusReferencesTaiKhoans")]
        public TaiKhoans UserName
        {
            get { return fUserName; }
            set { SetPropertyValue<TaiKhoans>("UserName", ref fUserName, value); }
        }
        bool fdeleted;
        public bool deleted
        {
            get { return fdeleted; }
            set { SetPropertyValue<bool>("deleted", ref fdeleted, value); }
        }
    }

}
