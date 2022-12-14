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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KURSDBEntities : DbContext
    {
        public KURSDBEntities()
            : base("name=KURSDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Apply> Applies { get; set; }
        public virtual DbSet<ApplyBaşvuru> ApplyBaşvuru { get; set; }
        public virtual DbSet<ApplyCOUNT> ApplyCOUNTs { get; set; }
        public virtual DbSet<ApplyDurum> ApplyDurums { get; set; }
        public virtual DbSet<Bran> Brans { get; set; }
        public virtual DbSet<Der> Ders { get; set; }
        public virtual DbSet<DersProgram> DersPrograms { get; set; }
        public virtual DbSet<Dönemler> Dönemler { get; set; }
        public virtual DbSet<EKurum> EKurums { get; set; }
        public virtual DbSet<FizikselYer> FizikselYers { get; set; }
        public virtual DbSet<Görüsler> Görüsler { get; set; }
        public virtual DbSet<Grup> Grups { get; set; }
        public virtual DbSet<Günler> Günler { get; set; }
        public virtual DbSet<IL> ILs { get; set; }
        public virtual DbSet<ILCE> ILCEs { get; set; }
        public virtual DbSet<İstenilenEvraklar> İstenilenEvraklar { get; set; }
        public virtual DbSet<Kampu> Kampus { get; set; }
        public virtual DbSet<KursTür> KursTür { get; set; }
        public virtual DbSet<Notlar> Notlars { get; set; }
        public virtual DbSet<Ögrenci> Ögrenci { get; set; }
        public virtual DbSet<Okul> Okuls { get; set; }
        public virtual DbSet<Organızasyon> Organızasyon { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Randevu> Randevus { get; set; }
        public virtual DbSet<RandevuTürü> RandevuTürü { get; set; }
        public virtual DbSet<Referan> Referans { get; set; }
        public virtual DbSet<s_user> s_user { get; set; }
        public virtual DbSet<Sezon> Sezons { get; set; }
        public virtual DbSet<Sınıf> Sınıf { get; set; }
        public virtual DbSet<Subeler> Subelers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ULKE> ULKEs { get; set; }
        public virtual DbSet<ViewDersProgram> ViewDersPrograms { get; set; }
        public virtual DbSet<YüklüEvraklar> YüklüEvraklar { get; set; }
        public virtual DbSet<Departman> Departmen { get; set; }
        public virtual DbSet<DersProgramHaftalık> DersProgramHaftalık { get; set; }
        public virtual DbSet<DersProgramMVC> DersProgramMVCs { get; set; }
        public virtual DbSet<ProgramView> ProgramViews { get; set; }
    
        public virtual ObjectResult<Nullable<int>> btest()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("btest");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<TableRender_Result> TableRender(string tablename)
        {
            var tablenameParameter = tablename != null ?
                new ObjectParameter("tablename", tablename) :
                new ObjectParameter("tablename", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TableRender_Result>("TableRender", tablenameParameter);
        }
    }
}
