using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Notlar
{
    public int NotId { get; set; }

    public decimal Puan { get; set; }

    public string NotTur { get; set; } = null!;

    public int FkOgrrNo { get; set; }

    public int FkDerssId { get; set; }

    public virtual Dersler FkDerss { get; set; } = null!;

    public virtual Ogrenci FkOgrrNoNavigation { get; set; } = null!;
}
