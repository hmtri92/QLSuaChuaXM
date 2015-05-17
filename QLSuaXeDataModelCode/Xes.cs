using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DeTai.EF_QLSCXeMay
{

    public partial class Xes
    {
        public Xes(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
