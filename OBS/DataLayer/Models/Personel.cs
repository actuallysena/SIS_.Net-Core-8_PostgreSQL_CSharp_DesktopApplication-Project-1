using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DataLayer.Models;

public partial class Personel
{
    public int PersId { get; set; }

    public string PersAdi { get; set; } = null!;

    public string PersSoyadi { get; set; } = null!;

    public string? PersGorev { get; set; }

    public string PersSifre { get; set; } = null!;

    public virtual ICollection<Fakulteler> Fakultelers { get; set; } = new List<Fakulteler>();
}
