using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BŠoštar___GLines.Models
{
    public class Zaposlenik
    {
        public int IdZaposlenik {  get; set; }
        public string imeZaposlenik { get; set; }
        public string prezimeZaposlenik { get; set; }
        public string korIme { get; set; }
        public string lozinka { get; set; }

        public bool CheckPassword(string password)
        {
            return lozinka == password;
        }
    }

    

}
