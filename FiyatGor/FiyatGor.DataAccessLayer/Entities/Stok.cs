using System;
using System.Collections.Generic;

namespace FiyatGor.DataAccessLayer.Entities;

public partial class Stok
{
    public int Id { get; set; }

    public string Kod { get; set; } = null!;

    public string? Ad { get; set; }

    public string? Grup { get; set; }

    public double? AFiyat { get; set; }

    public double? SFiyat { get; set; }

    public string? KdvOran { get; set; }

    public string? KdvDahil { get; set; }

    public string? OtvOran { get; set; }

    public string? OtvDahil { get; set; }

    public string? Birim { get; set; }

    public string Barkod { get; set; } = null!;

    public string? ResimYolu { get; set; }

    public string? StokRafi { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? SubeAdi { get; set; }

    public string? StokN11Id { get; set; }

    public string? StokOzelKod1 { get; set; }

    public string? StokOzelKod2 { get; set; }

    public string? StokOzelKod3 { get; set; }

    public string? StokOzelKod4 { get; set; }

    public string? AliciUrunKodu { get; set; }

    public string? SaticiUrunKodu { get; set; }

    public string? SeriNo { get; set; }

    public string? OivOran { get; set; }

    public string? OivDahil { get; set; }

    public string? DovizTur { get; set; }

    public string? Aciklama { get; set; }

    public string? KdvMuafiyetKodu { get; set; }

    public string? TevkifatKodu { get; set; }

    public string? OtvKodu { get; set; }

    public string? Marka { get; set; }

    public double? Bakiye { get; set; }
}
