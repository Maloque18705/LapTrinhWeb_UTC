using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class Cau5
{
    public string SoHdb { get; set; } = null!;

    public DateTime? NgayBan { get; set; }

    public string? MaKh { get; set; }

    public string? MaNv { get; set; }

    public decimal? TongTienHoaDon { get; set; }
}
