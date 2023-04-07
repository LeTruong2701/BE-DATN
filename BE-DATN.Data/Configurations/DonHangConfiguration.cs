using BE_DATN.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE_DATN.Data.Configurations
{
    public class DonHangConfiguration : IEntityTypeConfiguration<DonHang>
    {
        public void Configure(EntityTypeBuilder<DonHang> builder)
        {
            builder.ToTable("DonHang");
            builder.HasKey(x => x.IdDonHang);
            builder.Property(x => x.IdKhachHang).IsRequired();
            builder.Property(x => x.NgayDat).HasDefaultValueSql("getdate()");

            builder.Property(x => x.GhiChu).IsRequired(false).HasColumnType("nvarchar(500)");

            builder.Property(x => x.DiaChiGiaoHang).IsRequired().HasColumnType("nvarchar(500)");
            builder.Property(x => x.TrangThaiDonHang).IsRequired(false).HasColumnType("nvarchar(250)");
            builder.Property(x => x.TongTien).IsRequired();

            //builder.HasOne(x => x.KhachHang).WithMany(x => x.DonHangs).HasForeignKey(x => x.IdKhachHang);
            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(fk => fk.IdKhachHang);

        }

      
    }

}
