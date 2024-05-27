using BŠoštar___GLines.Models;
using BŠoštar___GLines.Repozitoriji;
using DBLayer;
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
    public partial class FormaZaLiniju : Form
    {
        public FormaZaLiniju()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajLiniju_Click(object sender, EventArgs e)
        {
            FormaDodajLiniju formaDodajLiniju = new FormaDodajLiniju();
            formaDodajLiniju.ShowDialog();
            RefreshLinija();
        }

        private void gumbAzurirajLiniju_Click(object sender, EventArgs e)
        {
            Linija oznacenaLinija = dgvLinije.CurrentRow.DataBoundItem as Linija;
            FormaAzurirajLiniju formaAzurirajLiniju = new FormaAzurirajLiniju(oznacenaLinija);
            formaAzurirajLiniju.ShowDialog();
            RefreshLinija();
        }

        private void ShowLinije()
        {
            var linije = LinijaRepozitorij.GetLinije();
            dgvLinije.DataSource = linije;

            dgvLinije.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvLinije.Columns["IdLinija"].DisplayIndex = 0;
            dgvLinije.Columns["nazivLinije"].DisplayIndex = 1;
            dgvLinije.Columns["polazisnaStanica"].DisplayIndex = 2;
            dgvLinije.Columns["odredisnaStanica"].DisplayIndex = 3;
            dgvLinije.Columns["vrijemePutovanja"].DisplayIndex = 4;

            dgvLinije.Columns["IdLinija"].HeaderText = "ID Linije";
            dgvLinije.Columns["nazivLinije"].HeaderText = "Naziv liinje";
            dgvLinije.Columns["polazisnaStanica"].HeaderText = "Stanica polazišta";
            dgvLinije.Columns["odredisnaStanica"].HeaderText = "Stanica odredišta";
            dgvLinije.Columns["vrijemePutovanja"].HeaderText = "Vrijeme putovanja u minutama";

            
            foreach (DataGridViewRow row in dgvLinije.Rows)
            {
                Linija linija = row.DataBoundItem as Linija;
                if (linija != null && LinijaRepozitorij.IsLinijaInUse(linija.idLinija))
                {
                    row.DefaultCellStyle.BackColor = Color.LimeGreen; 
                }
            }
        }


        private void FormaZaLiniju_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_bsostar21_DB", "PI2324_bsostar21_User", "3DeGe:j]");
            ShowLinije();


        }

        private void gumbObrisiLiniju_Click(object sender, EventArgs e)
        {
            Linija oznacenaLinija = dgvLinije.CurrentRow.DataBoundItem as Linija;
            LinijaRepozitorij.Delete(oznacenaLinija);
            RefreshLinija();
        }

        private void RefreshLinija()
        {
            List<Linija> listaLinija = LinijaRepozitorij.GetLinije();
            dgvLinije.DataSource = listaLinija;

            foreach (DataGridViewRow row in dgvLinije.Rows)
            {
                Linija linija = row.DataBoundItem as Linija;
                if (linija != null && LinijaRepozitorij.IsLinijaInUse(linija.idLinija))
                {
                    row.DefaultCellStyle.BackColor = Color.LimeGreen; 
                }
            }
        }

        private void txtPretrazivanjeLinije_TextChanged(object sender, EventArgs e)
        {
            string pretrazivanje = txtPretrazivanjeLinije.Text;
            List<Linija> linije = LinijaRepozitorij.GetLinijaByName(pretrazivanje);

            

            if (linije.Any())
            {
                dgvLinije.DataSource = linije;

                dgvLinije.Columns["IdLinija"].DisplayIndex = 0;
                dgvLinije.Columns["nazivLinije"].DisplayIndex = 1;
                dgvLinije.Columns["polazisnaStanica"].DisplayIndex = 2;
                dgvLinije.Columns["odredisnaStanica"].DisplayIndex = 3;
                dgvLinije.Columns["vrijemePutovanja"].DisplayIndex = 4;

                dgvLinije.Columns["IdLinija"].HeaderText = "ID Linije";
                dgvLinije.Columns["nazivLinije"].HeaderText = "Naziv liinje";
                dgvLinije.Columns["polazisnaStanica"].HeaderText = "Stanica polazišta";
                dgvLinije.Columns["odredisnaStanica"].HeaderText = "Stanica odredišta";
                dgvLinije.Columns["vrijemePutovanja"].HeaderText = "Vrijeme putovanja u minutama";

                foreach (DataGridViewRow row in dgvLinije.Rows)
                {
                    Linija linija = row.DataBoundItem as Linija;
                    if (linija != null && LinijaRepozitorij.IsLinijaInUse(linija.idLinija))
                    {
                        row.DefaultCellStyle.BackColor = Color.LimeGreen;        
                    }
                }
            }
            else
            {
                dgvLinije.DataSource = null;

            }
        }
    }
}
