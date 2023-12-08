using System;
using System.Collections.Generic;

namespace zh3_AFKFXH.Models;

public partial class Jateko
{
    public int JatekosId { get; set; }

    public string Nev { get; set; } = null!;

    public DateTime? SzuletesiDatum { get; set; }

    public string Poszt { get; set; } = null!;

    public int Mezszam { get; set; }

    public int? CsapatId { get; set; }

    public virtual Csapat? Csapat { get; set; }
}
