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
    
    public partial class Apply
    {
        public int id { get; set; }
        public string uname { get; set; }
        public string lastname { get; set; }
        public string utel { get; set; }
        public string umaıl { get; set; }
        public Nullable<int> uulke { get; set; }
        public Nullable<int> uprogram { get; set; }
        public string uacıklama { get; set; }
        public Nullable<int> DurumID { get; set; }
        public Nullable<System.DateTime> mas_crdate { get; set; }
        public string SISKODU { get; set; }
    
        public virtual ApplyDurum ApplyDurum { get; set; }
        public virtual Program Program { get; set; }
        public virtual ULKE ULKE { get; set; }
    }
}
