//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KursMıx.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Randevu
    {
        public int BaseID { get; set; }
        public Nullable<System.DateTime> BDate { get; set; }
        public Nullable<System.DateTime> EDate { get; set; }
        public string Acıklama { get; set; }
        public Nullable<int> OluşturanID { get; set; }
        public Nullable<int> RandevuKısıID { get; set; }
        public Nullable<int> RandevuTürID { get; set; }
        public Nullable<System.DateTime> mas_crdate { get; set; }
        public Nullable<bool> Aktif_fl { get; set; }
        public string SISKODU { get; set; }
        public Nullable<int> KISIID { get; set; }
    
        public virtual RandevuTürü RandevuTürü { get; set; }
    }
}
