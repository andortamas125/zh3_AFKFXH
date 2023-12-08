using System;
using System.Collections.Generic;

namespace zh3_AFKFXH.Models;

public partial class Csapat
{
    public int CsapatId { get; set; }

    public string Nev { get; set; } = null!;

    public string? EdzoNev { get; set; }

    public int? AlakulasiEv { get; set; }

    public virtual ICollection<Jateko> Jatekos { get; set; } = new List<Jateko>();

    public virtual ICollection<Mecc> MeccCsapat1Navigations { get; set; } = new List<Mecc>();

    public virtual ICollection<Mecc> MeccCsapat2Navigations { get; set; } = new List<Mecc>();
}
