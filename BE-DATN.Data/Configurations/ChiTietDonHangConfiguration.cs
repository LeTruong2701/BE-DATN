using BE_DATN.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE_DATN.Data.Configurations
{
    public class ChiTietDonHangConfiguration : IEntityTypeConfiguration<ChiTietDonHang>
    {
        public void Configure(EntityTypeBuilder<ChiTietDonHang> builder)
        {
            builder.ToTable("ChiTietDonHang");
            builder.HasKey(x => x.IdChiTietDonHang);
            builder.Property(x => x.IdDonHang).IsRequired();
            builder.Property(x => x.IdSanPham).IsRequired();
            builder.Property(x => x.IdMauSanPham).IsRequired();
            builder.Property(x => x.IdSizeSanPham).IsRequired();
            builder.Property(x => x.SoLuong).IsRequired();
            builder.Property(x => x.GiaMua).IsRequired();


            //builder.HasOne(x => x.DonHang).WithMany(x => x.ChiTietDonHangs).HasForeignKey(x => x.IdDonHang).OnDelete(DeleteBehavior.NoAction);
            ////builder.HasOne(x => x.SanPham).WithMany(x => x.ChiTietDonHangs).HasForeignKey(x => x.IdSanPham).OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(x => x.MauSanPham).WithMany(x => x.ChiTietDonHangs).HasForeignKey(x => x.IdMauSanPham).OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(x => x.SizeSanPham).WithMany(x => x.ChiTietDonHangs).HasForeignKey(x => x.IdSizeSanPham).OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.DonHang).WithMany().HasForeignKey(fk => fk.IdDonHang);
            builder.HasOne(x => x.MauSanPham).WithMany().HasForeignKey(fk => fk.IdMauSanPham);
            //builder.HasOne(x=>x.SanPham).WithMany().HasForeignKey(fk => fk.IdSanPham);
            //builder.HasOne(x=>x.SizeSanPham).WithMany().HasForeignKey(fk => fk.IdSizeSanPham);

        }

        
    }

}
