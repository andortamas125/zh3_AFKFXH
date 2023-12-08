using System;
using System.Collections.Generic;

namespace zh3_AFKFXH.Models;

public partial class Stadion
{
    public int StadionId { get; set; }

    public string Varos { get; set; } = null!;

    public int Ferohelyek { get; set; }

    public virtual ICollection<Mecc> Meccs { get; set; } = new List<Mecc>();
}
