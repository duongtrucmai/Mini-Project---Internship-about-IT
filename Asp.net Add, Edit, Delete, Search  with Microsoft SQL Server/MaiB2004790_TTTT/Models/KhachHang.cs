using System;
using System.Collections.Generic;

namespace MaiB2004790_TTTT.Models;

public partial class KhachHang
{
    public int Id { get; set; }

    public string Tên { get; set; } = null!;

    public string? Họ { get; set; }

    public int Sđt { get; set; }

    public string ĐịaChỉ { get; set; } = null!;
}
