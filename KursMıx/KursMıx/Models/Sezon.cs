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
    
    public partial class Sezon
    {
        public int ID { get; set; }
        public string SezonName { get; set; }
        public string SezonKodu { get; set; }
        public Nullable<int> PesınatOran { get; set; }
        public Nullable<int> MaxTaksit { get; set; }
        public Nullable<System.DateTime> SezonBaslangıc { get; set; }
        public Nullable<System.DateTime> SezonBitis { get; set; }
        public Nullable<bool> Aktif { get; set; }
        public Nullable<bool> Gösterim { get; set; }
        public Nullable<int> SubeID { get; set; }
    
        public virtual Subeler Subeler { get; set; }
    }
}
