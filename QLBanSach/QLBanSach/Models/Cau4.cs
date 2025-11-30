using System;
using System.Collections.Generic;

namespace QLBanSach.Models;

public partial class Cau4
{
    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public int Slnhap2021 { get; set; }

    public int Slban2021 { get; set; }

    public int? ChenhLech { get; set; }
}
