using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class Cau3
{
    public string MaKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? DienThoai { get; set; }

    public decimal? TongTienTieuDung { get; set; }
}
