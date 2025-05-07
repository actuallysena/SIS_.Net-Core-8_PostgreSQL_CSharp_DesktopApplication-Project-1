using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Ogrenci
{
    public int OgrNo { get; set; }

    public string OgrAdi { get; set; } = null!;

    public string OgrSoyadi { get; set; } = null!;

    public string? OgrTel { get; set; }

    public string? OgrMail { get; set; }

    public string? OgrTc { get; set; }

    public string OgrSifre { get; set; } = null!;

    public string? OgrProgram { get; set; }

    public string? OgrOgretim { get; set; }

    public bool? OgrDurum { get; set; }

    public int? Danisman { get; set; }

    public int FkSnff { get; set; }

    public int FkBolmm { get; set; }

    public virtual ICollection<Devamsizlik> Devamsizliks { get; set; } = new List<Devamsizlik>();

    public virtual ICollection<Notlar> Notlars { get; set; } = new List<Notlar>();

    public virtual Sinif Sinif { get; set; } = null!;
}
