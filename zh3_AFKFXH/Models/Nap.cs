using System;
using System.Collections.Generic;

namespace zh3_AFKFXH.Models;

public partial class Nap
{
    public int NapId { get; set; }

    public string Nev { get; set; } = null!;

    public int Jegyar { get; set; }

    public virtual ICollection<Mecc> Meccs { get; set; } = new List<Mecc>();
}
