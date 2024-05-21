using BŠoštar___GLines.Models;
using BŠoštar___GLines.Repozitoriji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BŠoštar___GLines
{
    public partial class FormaAzurirajLiniju : Form
    {
        private Linija linija = null;

        public FormaAzurirajLiniju(Linija linije)
        {
            InitializeComponent();

            linija = linije;
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbAzurirajLiniju_Click(object sender, EventArgs e)
        {
            linija.nazivLinije = txtNazivLinija.Text;
            linija.polazisnaStanica = cbPolazisnaStanica.Text;
            linija.odredisnaStanica = cbOdredisnaStanica.Text;
            int vrijemePutovanja;
            if(int.TryParse(textVrijemePutovanja.Text, out vrijemePutovanja))
            {
                linija.vrijemePutovanja = vrijemePutovanja;
            }
            
            LinijaRepozitorij.Update(linija);
            this.Close();

        }

        private void FormaAzurirajLiniju_Load(object sender, EventArgs e)
        {
            

            List<Stanica> stanice = StanicaRepozitorij.GetStanice();

            foreach (var stanica in stanice)
            {
                cbPolazisnaStanica.Items.Add(stanica.nazivStanice);
                cbOdredisnaStanica.Items.Add(stanica.nazivStanice);
            }

            txtNazivLinija.Text = linija.nazivLinije;
            textVrijemePutovanja.Text = linija.vrijemePutovanja.ToString();
            cbPolazisnaStanica.Text = linija.polazisnaStanica;
            cbOdredisnaStanica.Text = linija.odredisnaStanica;

        }
    }
}
