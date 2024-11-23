using System;
using System.Collections.Generic;

namespace OBS_DataAccessLayer.Models;

public partial class Sinif
{
    public int Snf { get; set; }

    public int FkBolId { get; set; }

    public virtual ICollection<Dersler> Derslers { get; set; } = new List<Dersler>();

    public virtual Bolumler FkBol { get; set; } = null!;

    public virtual ICollection<Ogrenci> Ogrencis { get; set; } = new List<Ogrenci>();
}
