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
    
    public partial class FizikselYer
    {
        public int id { get; set; }
        public Nullable<int> BaglıYer { get; set; }
        public Nullable<int> BaglıKampus { get; set; }
        public string YerAdı { get; set; }
        public Nullable<int> YerTipi { get; set; }
        public Nullable<int> Kapasite { get; set; }
    
        public virtual Kampu Kampu { get; set; }
    }
}
