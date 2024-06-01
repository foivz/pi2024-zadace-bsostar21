using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Models
{
    public class LinijaVozniRed
    {
        public int IdLinija { get; set; }
        public Linija Linija { get; set; }

        public int IdVozniRed { get; set; }
        public VozniRed VozniRed { get; set; }
    }
}
