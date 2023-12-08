using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh3_AFKFXH
{
    internal class Focista
    {
        public int JatekosId { get; set; }

        public string Nev { get; set; } = null!;

        public string Poszt { get; set; } = null!;

        public int Mezszam { get; set; }

        public int? CsapatId { get; set; }

        public int? Kor { get; set; }
    }
}
