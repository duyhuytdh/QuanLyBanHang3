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
    
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            this.SanPhams = new HashSet<SanPham>();
        }
    
        public long ID { get; set; }
        public string TenLoaiSP { get; set; }
        public string MaLoai { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
    
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
