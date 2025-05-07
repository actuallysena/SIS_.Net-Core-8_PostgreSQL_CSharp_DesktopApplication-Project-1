using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Dersler
{
    public int DersId { get; set; }

    public string DersAdi { get; set; } = null!;

    public string? Derslik { get; set; }

    public int Kredi { get; set; }

    public int Akts { get; set; }

    public string? DersDonem { get; set; }

    public int FkSnf { get; set; }

    public int FkBolm { get; set; }

    public virtual ICollection<Devamsizlik> Devamsizliks { get; set; } = new List<Devamsizlik>();

    public virtual ICollection<Notlar> Notlars { get; set; } = new List<Notlar>();

    public virtual Sinif Sinif { get; set; } = null!;
}
