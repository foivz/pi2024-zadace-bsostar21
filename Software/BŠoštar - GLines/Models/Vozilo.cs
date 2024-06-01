using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Models
{
    public class Vozilo
    {
        public int IdVozilo { get; set; }
        public string oznakaVozila { get; set; }
        public string modelVozila { get; set; }
        public string markaVozila { get; set; }
        public string nazivVozila { get; set; }
        public int brojSjedala { get; set; }
        public int brojSlobodnihMjesta { get; set; }
        public int IdVozniRed {  get; set; }

        public override string ToString()
        {
            return oznakaVozila;
        }
    }
}
