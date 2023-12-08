using System;
using System.Collections.Generic;

namespace zh3_AFKFXH.Models;

public partial class Mecc
{
    public int MeccsId { get; set; }

    public int? Csapat1 { get; set; }

    public int? Csapat2 { get; set; }

    public int? StadionId { get; set; }

    public int? NapId { get; set; }

    public int? Nezoszam { get; set; }

    public string Eredmeny { get; set; } = null!;

    public virtual Csapat? Csapat1Navigation { get; set; }

    public virtual Csapat? Csapat2Navigation { get; set; }

    public virtual Nap? Nap { get; set; }

    public virtual Stadion? Stadion { get; set; }
}
