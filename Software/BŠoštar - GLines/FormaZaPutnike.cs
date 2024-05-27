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
    public partial class FormaZaPutnike : Form
    {
        public FormaZaPutnike()
        {
            InitializeComponent();
        }

        private void gumbZaposlenici_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaZaPutnike_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_bsostar21_DB", "PI2324_bsostar21_User", "3DeGe:j]");
            ShowVozniRed();
        }

        private void ShowVozniRed()
        {
            var redovi = VozniRedRepozitorij.GetVozneRedove();
            dgvRed.DataSource = redovi;

            dgvRed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRed.Columns["IdVozniRed"].Visible = false;

            dgvRed.Columns["stanicaPolaska"].DisplayIndex = 1;
            dgvRed.Columns["vrijemePolaska"].DisplayIndex = 2;
            dgvRed.Columns["stanicaDolaska"].DisplayIndex = 3;
            dgvRed.Columns["vrijemeDolaska"].DisplayIndex = 4;
            dgvRed.Columns["danUTjednu"].DisplayIndex = 5;

            dgvRed.Columns["stanicaPolaska"].HeaderText = "Stanica polaska";
            dgvRed.Columns["vrijemePolaska"].HeaderText = "Vrijeme polaska";
            dgvRed.Columns["stanicaDolaska"].HeaderText = "Stanica dolaska";
            dgvRed.Columns["vrijemeDolaska"].HeaderText = "Vrijeme dolaska";
            dgvRed.Columns["danUTjednu"].HeaderText = "Dan";

            dgvRed.Columns["vrijemePolaska"].DefaultCellStyle.Format = "HH:mm";
            dgvRed.Columns["vrijemeDolaska"].DefaultCellStyle.Format = "HH:mm";
        }

        private void gumbInfo_Click(object sender, EventArgs e)
        {
            VozniRed oznaceniVozniRed = dgvRed.CurrentRow.DataBoundItem as VozniRed;
            FormaZaDodatneInformacije formaZaDodatne = new FormaZaDodatneInformacije(oznaceniVozniRed);
            formaZaDodatne.ShowDialog();
        }

        private void gumbKupi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kupili ste kartu", "Uspejšna kupnja",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
