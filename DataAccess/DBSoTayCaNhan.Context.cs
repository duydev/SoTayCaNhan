﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBSoTayCaNhan : DbContext
    {
        public DBSoTayCaNhan()
            : base("name=DBSoTayCaNhan")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CongViec> CongViec { get; set; }
        public virtual DbSet<CT_CongViec> CT_CongViec { get; set; }
        public virtual DbSet<DanhBa> DanhBa { get; set; }
        public virtual DbSet<LichTrinh> LichTrinh { get; set; }
        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<NhacNho> NhacNho { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<ThongBao> ThongBao { get; set; }
    }
}
