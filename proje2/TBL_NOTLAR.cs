//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace proje2
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_NOTLAR
    {
        public int Not_ID { get; set; }
        public Nullable<int> OGR { get; set; }
        public Nullable<int> DERS { get; set; }
        public Nullable<short> SINAV1 { get; set; }
        public Nullable<short> SINAV2 { get; set; }
        public Nullable<decimal> ORTALAMA { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        public virtual TBL_DERS TBL_DERS { get; set; }
        public virtual TBL_OGR TBL_OGR { get; set; }
    }
}
