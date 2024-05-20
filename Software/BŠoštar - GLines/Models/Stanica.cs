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
        public string nazivStanice { get; set; }
        public string adresaStanice { get; set; }

        public override string ToString()
        {
            return nazivStanice;
        }

    }
}
