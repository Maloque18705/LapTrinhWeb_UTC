using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class Cau8
{
    public string MaKh { get; set; } = null!;

    public string? TenKh { get; set; }

    public string? DienThoai { get; set; }

    public decimal? TongTieuDung { get; set; }
}
