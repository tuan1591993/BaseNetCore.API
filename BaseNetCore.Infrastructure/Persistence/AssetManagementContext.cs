﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using BaseNetCore.Application.Common.Interdaces;
using BaseNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BaseNetCore.Infrastructure.Persistence
{
    public partial class AssetManagementContext : DbContext, IAssetManagementContext
    {
        public AssetManagementContext()
        {
        }

        public AssetManagementContext(DbContextOptions<AssetManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LoaiTaiSan> LoaiTaiSans { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhomTaiSan> NhomTaiSans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiTaiSan>(entity =>
            {
                entity.ToTable("LoaiTaiSan");

                entity.Property(e => e.CachDanhMa).HasMaxLength(500);

                entity.Property(e => e.GhiChu).HasColumnType("ntext");

                entity.Property(e => e.MaLoaiTaiSan)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenLoaiTaiSan)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.ToTable("NhaCungCap");

                entity.Property(e => e.DiaChi).HasMaxLength(1000);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.GhiChu).HasMaxLength(1000);

                entity.Property(e => e.MaNhaCungCap)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaSoThue).HasMaxLength(20);

                entity.Property(e => e.MoTai).HasMaxLength(200);

                entity.Property(e => e.TenNhaCungCap)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TknganHang)
                    .HasMaxLength(100)
                    .HasColumnName("TKNganHang");

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<NhomTaiSan>(entity =>
            {
                entity.ToTable("NhomTaiSan");

                entity.Property(e => e.MaNhom)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TenNhom)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}