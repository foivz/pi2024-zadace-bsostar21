using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Models
{
    public class StanicaLinija
    {
        public int IdStanica { get; set; }
        public Stanica Stanica { get; set; }

        public int IdLinija { get; set; }
        public Linija Linija { get; set; }
    }
}
