using System;
using System.Collections.Generic;

namespace OBS_DataAccessLayer.Models;

public partial class Universite
{
    public int UniId { get; set; }

    public string UniAdi { get; set; } = null!;

    public int Rektor { get; set; }

    public virtual ICollection<Fakulteler> Fakultelers { get; set; } = new List<Fakulteler>();

    public virtual Personel RektorNavigation { get; set; } = null!;
}
