﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanHang.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class QuanLyBanHangEntities : DbContext
    {
        public QuanLyBanHangEntities()
            : base("name=QuanLyBanHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ChiTietHDN> ChiTietHDNs { get; set; }
        public DbSet<ChiTietHDX> ChiTietHDXes { get; set; }
        public DbSet<DatHang> DatHangs { get; set; }
        public DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public DbSet<HoaDonXuat> HoaDonXuats { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<ViewDatHang> ViewDatHangs { get; set; }
        public DbSet<ViewSanPham> ViewSanPhams { get; set; }
        public DbSet<ViewChiTietHDN> ViewChiTietHDNs { get; set; }
        public DbSet<ViewChiTietHDX> ViewChiTietHDXes { get; set; }
        public DbSet<ViewTongHopHDN> ViewTongHopHDNs { get; set; }
        public DbSet<ViewTongHopHDX> ViewTongHopHDXes { get; set; }
        public DbSet<ViewTongHopTonKho> ViewTongHopTonKhoes { get; set; }
    
        //public virtual ObjectResult<pr_bc_doanh_thu_Result> pr_bc_doanh_thu(Nullable<System.DateTime> tu_ngay, Nullable<System.DateTime> den_ngay)
        //{
        //    var tu_ngayParameter = tu_ngay.HasValue ?
        //        new ObjectParameter("tu_ngay", tu_ngay) :
        //        new ObjectParameter("tu_ngay", typeof(System.DateTime));
    
        //    var den_ngayParameter = den_ngay.HasValue ?
        //        new ObjectParameter("den_ngay", den_ngay) :
        //        new ObjectParameter("den_ngay", typeof(System.DateTime));
    
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_bc_doanh_thu_Result>("pr_bc_doanh_thu", tu_ngayParameter, den_ngayParameter);
        //}
    
        //public virtual ObjectResult<pr_bc_nhap_hang_Result> pr_bc_nhap_hang(Nullable<System.DateTime> tu_ngay, Nullable<System.DateTime> den_ngay)
        //{
        //    var tu_ngayParameter = tu_ngay.HasValue ?
        //        new ObjectParameter("tu_ngay", tu_ngay) :
        //        new ObjectParameter("tu_ngay", typeof(System.DateTime));
    
        //    var den_ngayParameter = den_ngay.HasValue ?
        //        new ObjectParameter("den_ngay", den_ngay) :
        //        new ObjectParameter("den_ngay", typeof(System.DateTime));
    
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_bc_nhap_hang_Result>("pr_bc_nhap_hang", tu_ngayParameter, den_ngayParameter);
        //}
    
        //public virtual ObjectResult<pr_bc_xuat_hang_Result> pr_bc_xuat_hang(Nullable<System.DateTime> tu_ngay, Nullable<System.DateTime> den_ngay)
        //{
        //    var tu_ngayParameter = tu_ngay.HasValue ?
        //        new ObjectParameter("tu_ngay", tu_ngay) :
        //        new ObjectParameter("tu_ngay", typeof(System.DateTime));
    
        //    var den_ngayParameter = den_ngay.HasValue ?
        //        new ObjectParameter("den_ngay", den_ngay) :
        //        new ObjectParameter("den_ngay", typeof(System.DateTime));
    
        //    return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_bc_xuat_hang_Result>("pr_bc_xuat_hang", tu_ngayParameter, den_ngayParameter);
        //}
    }
}
