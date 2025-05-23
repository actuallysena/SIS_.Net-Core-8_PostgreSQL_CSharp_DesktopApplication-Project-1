using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Bolumler
{
    public int BolumId { get; set; }

    public string BolumAdi { get; set; } = null!;

    public int? Baskan { get; set; }

    public int FkSekreter { get; set; }

    public int FakId { get; set; }

    public virtual ICollection<Akademisyen> Akademisyens { get; set; } = new List<Akademisyen>();

    public virtual Fakulteler Fak { get; set; } = null!;

    public virtual ICollection<Sinif> Sinifs { get; set; } = new List<Sinif>();
}
