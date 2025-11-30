using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class Cau13
{
    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public string? TacGia { get; set; }

    public int? SoLuongTon { get; set; }
}
