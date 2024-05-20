using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Models
{
    public class Stanica
    {
        public int idStanica { get; set; }
        public string nazivStanica { get; set; }
        public string adresaStanica { get; set; }

        public override string ToString()
        {
            return nazivStanica;
        }

    }
}
