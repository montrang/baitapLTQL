namespace LTQLWEB2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBConnect : DbContext
    {
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<NHOMSP> NHOMSPs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<CHITIETHD> CHITIETHDs { get; set; }
        public DBConnect()
            : base("name=DBConnect")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
