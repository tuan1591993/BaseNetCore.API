﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace BaseNetCore.Domain.Entities;

public partial class NhaCungCap
{
    public int Id { get; set; }

    public string MaNhaCungCap { get; set; } = null!;

    public string TenNhaCungCap { get; set; } = null!;

    public int? NhomNhaCungCapId { get; set; }

    public string? DiaChi { get; set; }

    public string? MaSoThue { get; set; }

    public string? Website { get; set; }

    public string? TknganHang { get; set; }

    public string? MoTai { get; set; }

    public string? Email { get; set; }

    public string? GhiChu { get; set; }
}