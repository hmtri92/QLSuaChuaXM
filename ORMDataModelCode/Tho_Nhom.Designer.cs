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

    public partial class Tho_Nhom : XPLiteObject
    {
        string fid;
        [Key]
        [Size(128)]
        public string id
        {
            get { return fid; }
            set { SetPropertyValue<string>("id", ref fid, value); }
        }
        NhanVien fMaTho;
        [Size(128)]
        [Association(@"Tho_NhomReferencesNhanVien")]
        public NhanVien MaTho
        {
            get { return fMaTho; }
            set { SetPropertyValue<NhanVien>("MaTho", ref fMaTho, value); }
        }
        NhomThoes fMaNhom;
        [Size(128)]
        [Association(@"Tho_NhomReferencesNhomThoes")]
        public NhomThoes MaNhom
        {
            get { return fMaNhom; }
            set { SetPropertyValue<NhomThoes>("MaNhom", ref fMaNhom, value); }
        }
        bool fdeleted;
        public bool deleted
        {
            get { return fdeleted; }
            set { SetPropertyValue<bool>("deleted", ref fdeleted, value); }
        }
    }

}
