using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class OgrenciDer
{
    public int OgrNo { get; set; }

    public int DersId { get; set; }

    public string Donemkodu { get; set; } = null!;

    public decimal? Vizenotu { get; set; }

    public decimal? Finalnotu { get; set; }

    public int? Devamsizlik { get; set; }

    public bool Devamzorunlulugu { get; set; }

    public decimal? Butunlemenotu { get; set; }

    public decimal? Ortalama { get; set; }

    public bool? Gectimi { get; set; }

    public string? Harfnotu { get; set; }

    public virtual Dersler Ders { get; set; } = null!;

    public virtual Ogrenci OgrNoNavigation { get; set; } = null!;
}
