﻿using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class Universite
{
    public int UniId { get; set; }

    public string UniAdi { get; set; } = null!;

    public int? Rektor { get; set; }

    public virtual ICollection<Fakulteler> Fakultelers { get; set; } = new List<Fakulteler>();
}
