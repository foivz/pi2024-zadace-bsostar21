﻿using BŠoštar___GLines.Models;
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
    public partial class FormaAzurirajVozniRed : Form
    {
        private VozniRed red = null;

        public FormaAzurirajVozniRed(VozniRed redovi)
        {
            InitializeComponent();

            red = redovi;
        }

        private void gumbOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbAzurirajVozniRed_Click(object sender, EventArgs e)
        {
            red.vrijemePolaska = dtVrijemePolaska.Value;
            red.vrijemeDolaska = dtVrijemeDolaska.Value;
            red.stanicaPolaska = cbStanicaPolaska.Text;
            red.stanicaDolaska = cbStanicaDolaska.Text;
            red.danUTjednu = cmbDani.SelectedItem?.ToString();
            int linija;
            if (int.TryParse(cmLinija.Text, out linija))
            {
                red.IdLinija = linija;
            }

            VozniRedRepozitorij.Update(red);
            this.Close();
        }

        private void FormaAzurirajVozniRed_Load(object sender, EventArgs e)
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

            dtVrijemePolaska.Value = red.vrijemePolaska;
            dtVrijemeDolaska.Value = red.vrijemeDolaska;

            cbStanicaPolaska.Text = red.stanicaPolaska;
            cbStanicaDolaska.Text = red.stanicaDolaska;

            cmbDani.Text = red.danUTjednu;

            var linija = LinijaRepozitorij.GetLinije();
            cmLinija.DataSource = linija;
            //cmbVoziRed.DisplayMember = "stanicaPolaska";
            cmLinija.ValueMember = "IdLinija";


            cmLinija.Text = red.IdLinija.ToString();

            

        }
    }
}
