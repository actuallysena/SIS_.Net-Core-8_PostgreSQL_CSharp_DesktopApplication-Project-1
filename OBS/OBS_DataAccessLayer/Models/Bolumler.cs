using System;
using System.Collections.Generic;

namespace OBS_DataAccessLayer.Models;

public partial class Bolumler
{
    public int BolumId { get; set; }

    public string BolumAdi { get; set; } = null!;

    public int Baskan { get; set; }

    public int FkSekreter { get; set; }

    public int FkFakid { get; set; }

    public virtual ICollection<Akademisyen> Akademisyens { get; set; } = new List<Akademisyen>();

    public virtual Akademisyen BaskanNavigation { get; set; } = null!;

    public virtual ICollection<Dersler> Derslers { get; set; } = new List<Dersler>();

    public virtual Fakulteler FkFak { get; set; } = null!;

    public virtual Personel FkSekreterNavigation { get; set; } = null!;

    public virtual ICollection<Sinif> Sinifs { get; set; } = new List<Sinif>();
}
