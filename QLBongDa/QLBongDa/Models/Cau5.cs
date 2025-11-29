using System;
using System.Collections.Generic;

namespace QLBongDa.Models;

public partial class Cau5
{
    public string? CauLacBoId { get; set; }

    public string? TenClb { get; set; }

    public string? HoVaTen { get; set; }

    public string? TenSan { get; set; }

    public DateTime? NgayThiDau { get; set; }

    public int? ThoiDiemGhiBan { get; set; }
}
