//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ViewChiTietHDX
    {
        public long ID { get; set; }
        public long IDHDX { get; set; }
        public long IDSP { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public Nullable<double> VAT { get; set; }
        public string TenSP { get; set; }
        public string DonViTinh { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    }
}