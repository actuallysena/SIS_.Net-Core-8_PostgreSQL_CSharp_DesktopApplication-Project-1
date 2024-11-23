using System;
using System.Collections.Generic;

namespace OBS_DataAccessLayer.Models;

public partial class Personel
{
    public int PersId { get; set; }

    public string PersAdi { get; set; } = null!;

    public string PersSoyadi { get; set; } = null!;

    public string? PersGorev { get; set; }

    public string PersSifre { get; set; } = null!;

    public int FkFakId { get; set; }

    public virtual ICollection<Bolumler> Bolumlers { get; set; } = new List<Bolumler>();

    public virtual ICollection<Fakulteler> Fakultelers { get; set; } = new List<Fakulteler>();

    public virtual Fakulteler FkFak { get; set; } = null!;

    public virtual ICollection<Universite> Universites { get; set; } = new List<Universite>();
}
