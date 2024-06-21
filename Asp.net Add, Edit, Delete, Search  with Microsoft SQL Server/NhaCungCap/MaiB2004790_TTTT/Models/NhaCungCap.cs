using System;
using System.Collections.Generic;

namespace MaiB2004790_TTTT.Models;

public partial class NhaCungCap
{
    public int Id { get; set; }

    public string MaSoThue { get; set; } = null!;

    public string TenNhaCungCap { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SoTk { get; set; } = null!;
}
