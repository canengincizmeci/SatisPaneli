using System;
using System.Collections.Generic;

namespace SatisPaneli.Models;

public partial class Urunler
{
    public int UrunId { get; set; }

    public string? UrunAd { get; set; }

    public int? KategoriId { get; set; }

    public int? Miktar { get; set; }

    public virtual Kategoriler? Kategori { get; set; }

    public virtual ICollection<Satislar> Satislars { get; set; } = new List<Satislar>();
}
