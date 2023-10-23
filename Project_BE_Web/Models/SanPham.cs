﻿using System;
using System.Collections.Generic;

namespace Project_BE_Web.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            DonHangs = new HashSet<DonHang>();
        }

        public string MaSp { get; set; } = null!;
        public string MaNsx { get; set; } = null!;
        public int? SoLuong { get; set; }
        public string? TenSp { get; set; }
        public string? CauHinh { get; set; }
        public string? MoTa { get; set; }
        public string? PhienBan { get; set; }
        public int? KhuyenMai { get; set; }
        public string? MauSac { get; set; }
        public string? AnhSp { get; set; }

        public virtual Nsx MaNsxNavigation { get; set; } = null!;
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
