using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Akademisyen
{
    public int AkademisyenId { get; set; }

    public string AkademisyenAdi { get; set; } = null!;

    public string AkademisyenSoyadi { get; set; } = null!;

    public string? AkademisyenTc { get; set; }

    public string? AkademisyenTel { get; set; }

    public string? AkademisyenMail { get; set; }

    public string AkademisyenSifre { get; set; } = null!;

    public int FkBolumId { get; set; }

    public virtual Bolumler FkBolum { get; set; } = null!;
}
