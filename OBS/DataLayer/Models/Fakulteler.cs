using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Fakulteler
{
    public int FakId { get; set; }

    public string FakAdi { get; set; } = null!;

    public int? Dekan { get; set; }

    public int FkUniId { get; set; }

    public virtual ICollection<Bolumler> Bolumlers { get; set; } = new List<Bolumler>();

    public virtual Personel? DekanNavigation { get; set; }

    public virtual Universite FkUni { get; set; } = null!;
}
