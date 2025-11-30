using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class Cau19
{
    public string MaNxb { get; set; } = null!;

    public string? TenNxb { get; set; }

    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public int? TongSoLuongNhap { get; set; }
}
