using BaseNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BaseNetCore.Application.Common.Interdaces
{
    public interface IAssetManagementContext
    {
        DbSet<LoaiTaiSan> LoaiTaiSans { get; set; }
        DbSet<NhaCungCap> NhaCungCaps { get; set; }
        DbSet<NhomTaiSan> NhomTaiSans { get; set; }
    }
}
