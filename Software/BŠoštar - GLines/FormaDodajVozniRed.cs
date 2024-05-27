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
    public partial class FormaDodajVozniRed : Form
    {
        public FormaDodajVozniRed()
        {
            InitializeComponent();
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaDodajVozniRed_Load(object sender, EventArgs e)
        {
            List<Stanica> stanice = StanicaRepozitorij.GetStanice();

            foreach (var stanica in stanice)
            {
                cbStanicaPolaska.Items.Add(stanica.nazivStanice);
                cbStanicaDolaska.Items.Add(stanica.nazivStanice);
            }
            
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };
            
            foreach (var dan in daniUTjednu)
            {
                cmbDani.Items.Add(dan);
            }
            
        }

        private void gumbDodajVozniRed_Click(object sender, EventArgs e)
        {
            string stanicapolazak = cbStanicaPolaska.Text;
            string stanicadolazak = cbStanicaDolaska.Text;
            DateTime vrijemepolazak = dtVrijemePolaska.Value;
            DateTime vrijemedolazak = dtVrijemeDolaska.Value;
            string odabraniDan = cmbDani.SelectedItem?.ToString(); 

            var redovi = new VozniRed
            {
                stanicaPolaska = stanicapolazak,
                stanicaDolaska = stanicadolazak,
                vrijemePolaska = vrijemepolazak,
                vrijemeDolaska = vrijemedolazak,
                danUTjednu = odabraniDan
            };

            VozniRedRepozitorij.Save(redovi);

            this.Close();
        }
    }
}
