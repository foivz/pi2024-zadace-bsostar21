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
    public partial class FormaDodajLiniju : Form
    {
        public FormaDodajLiniju()
        {
            InitializeComponent();
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajLiniju_Click(object sender, EventArgs e)
        {
            string naziv = txtNazivLinija.Text;
            string polazisna =cbPolazisnaStanica.Text;
            string odredisna = cbOdredisnaStanica.Text;
            int vrijeme = int.Parse(txtVrijemePutovanja.Text);

            var linija = new Linija
            {
                nazivLinije = naziv,
                polazisnaStanica = polazisna,
                odredisnaStanica = odredisna,
                vrijemePutovanja = vrijeme,

            };

            LinijaRepozitorij.Save(linija);
            this.Close();


        }

        private void FormaDodajLiniju_Load(object sender, EventArgs e)
        {
            List<Stanica> stanice = StanicaRepozitorij.GetStanice();

            foreach (var stanica in stanice)
            {
                cbPolazisnaStanica.Items.Add(stanica.nazivStanice);
                cbOdredisnaStanica.Items.Add(stanica.nazivStanice);
            }
        }
    }
}
