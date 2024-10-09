using System;
using System.Collections.Generic;
using FiyatGor.DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace FiyatGor.DataAccessLayer.Context;

public partial class FiyatgordbContext : DbContext
{
    public FiyatgordbContext()
    {
    }

    public FiyatgordbContext(DbContextOptions<FiyatgordbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Stok> Stoks { get; set; }

   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Stok>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Barkod, e.Kod })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("stok")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_general_ci");

            entity.HasIndex(e => e.Barkod, "BARKOD");

            entity.HasIndex(e => e.Kod, "kod");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("BARKOD");
            entity.Property(e => e.Kod)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("kod");
            entity.Property(e => e.AFiyat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("a_fiyat");
            entity.Property(e => e.Aciklama).HasColumnName("aciklama");
            entity.Property(e => e.Ad).HasColumnName("ad");
            entity.Property(e => e.AliciUrunKodu).HasMaxLength(255);
            entity.Property(e => e.Bakiye).HasDefaultValueSql("'0'");
            entity.Property(e => e.Birim)
                .HasMaxLength(50)
                .HasDefaultValueSql("'-'")
                .HasColumnName("birim");
            entity.Property(e => e.DovizTur)
                .HasMaxLength(255)
                .HasColumnName("dovizTur");
            entity.Property(e => e.Grup)
                .HasMaxLength(150)
                .HasDefaultValueSql("'-'")
                .HasColumnName("grup");
            entity.Property(e => e.KdvDahil)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Kdv Dahil'")
                .HasColumnName("kdv_dahil");
            entity.Property(e => e.KdvMuafiyetKodu)
                .HasMaxLength(255)
                .HasColumnName("kdv_muafiyet_kodu");
            entity.Property(e => e.KdvOran)
                .HasMaxLength(50)
                .HasDefaultValueSql("'1'")
                .HasColumnName("kdv_oran");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasDefaultValueSql("'rifat.kurt@bilsoft.com'")
                .HasColumnName("kullaniciAdi");
            entity.Property(e => e.Marka)
                .HasMaxLength(255)
                .HasColumnName("marka");
            entity.Property(e => e.OivDahil)
                .HasMaxLength(255)
                .HasColumnName("oiv_dahil");
            entity.Property(e => e.OivOran)
                .HasMaxLength(255)
                .HasColumnName("oiv_oran");
            entity.Property(e => e.OtvDahil)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("otv_dahil");
            entity.Property(e => e.OtvKodu)
                .HasMaxLength(255)
                .HasColumnName("otv_kodu");
            entity.Property(e => e.OtvOran)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("otv_oran");
            entity.Property(e => e.ResimYolu)
                .HasMaxLength(255)
                .HasDefaultValueSql("'-'")
                .HasColumnName("resimYolu");
            entity.Property(e => e.SFiyat)
                .HasDefaultValueSql("'0'")
                .HasColumnName("s_fiyat");
            entity.Property(e => e.SaticiUrunKodu).HasMaxLength(255);
            entity.Property(e => e.SeriNo).HasMaxLength(255);
            entity.Property(e => e.StokN11Id)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0.00'")
                .HasColumnName("stok_n11ID");
            entity.Property(e => e.StokOzelKod1)
                .HasMaxLength(255)
                .HasColumnName("stokOzelKod1");
            entity.Property(e => e.StokOzelKod2)
                .HasMaxLength(255)
                .HasColumnName("stokOzelKod2");
            entity.Property(e => e.StokOzelKod3)
                .HasMaxLength(255)
                .HasColumnName("stokOzelKod3");
            entity.Property(e => e.StokOzelKod4)
                .HasMaxLength(255)
                .HasColumnName("stokOzelKod4");
            entity.Property(e => e.StokRafi)
                .HasMaxLength(255)
                .HasColumnName("stokRafi");
            entity.Property(e => e.SubeAdi)
                .HasMaxLength(255)
                .HasDefaultValueSql("'BLACK'")
                .HasColumnName("subeAdi");
            entity.Property(e => e.TevkifatKodu)
                .HasMaxLength(255)
                .HasColumnName("tevkifat_kodu");
            entity.Property(e => e.Bakiye)
               .HasDefaultValueSql("'0'")
               .HasColumnName("Bakiye");

        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
