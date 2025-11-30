using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class Cau10
{
    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public string? TenTheLoai { get; set; }

    public int TongSoLuongNhap { get; set; }

    public int TongSoLuongBan { get; set; }

    public int? SoLuongTon { get; set; }
}
