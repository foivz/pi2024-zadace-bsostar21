using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Models
{
    public class VozniRed
    {
        public int IdVOzniRed {  get; set; }

        public DateTime vrijemePolaska { get; set; }
        public DateTime vrijemeDolaska { get; set; }
        public string stanicaPolaska { get; set; }
        public string stanicaDolaska { get; set; }
        public string danUTjednu {  get; set; }

        public override string ToString()
        {
            return stanicaPolaska;
        }
    }
}
