using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class TKhachHang
{
    public string MaKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public bool? GioiTinh { get; set; }

    public int? Soluonghoadon { get; set; }

    public int? Sluonghoadonban { get; set; }

    public int? Slhoadonban { get; set; }

    public decimal? TongTienTieuDung { get; set; }

    public virtual ICollection<THoaDonBan> THoaDonBans { get; set; } = new List<THoaDonBan>();
}
