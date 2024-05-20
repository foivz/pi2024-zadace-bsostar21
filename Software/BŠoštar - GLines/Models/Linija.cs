using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Models
{
    public class Linija
    {
        public int idLinija { get; set; }
        public string nazivLinije { get; set; }
        public string polazisnaStanica{ get; set; }
        public string odredisnaStanica { get; set; }

        public int vrijemePutovanja { get; set; }

        public override string ToString()
        {
            return nazivLinije;
        }
    }
}
