using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh3_AFKFXH
{
    public class Mérkőzés
    {
        public int MeccsId { get; set; }
        public string? Csapat1 { get; set; }

        public string? Csapat2 { get; set; }

        public int? Nezoszam { get; set; }

        public int? Bevétel { get; set; }

        public string Eredmeny { get; set; } = null!;

        public string? Nap { get; set; }
    }
}
