using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DataLayer.Models;

public partial class Devamsizlik
{
    public int DevamsizlikId { get; set; }

    public DateOnly Tarih { get; set; }

    public int FkOgrNo { get; set; }

    public int FkDersId { get; set; }

    public virtual Dersler FkDers { get; set; } = null!;

    public virtual Ogrenci FkOgrNoNavigation { get; set; } = null!;
}
