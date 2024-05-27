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
using static System.Net.Mime.MediaTypeNames;

namespace BŠoštar___GLines
{
    public partial class FormaZaDodatneInformacije : Form
    {
        private VozniRed red =null;
        private int kasnjenje = -1;

        public FormaZaDodatneInformacije(VozniRed redovi)
        {
            InitializeComponent();

            red = redovi;

            
    }

    private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormaZaDodatneInformacije_Load(object sender, EventArgs e)
        {
            DB.SetConfiguration("PI2324_bsostar21_DB", "PI2324_bsostar21_User", "3DeGe:j]");

            if (red != null)
            {
                
                Vozilo vozilo = VoziloRepozitorij.GetVoziloByVozniRedId(red.IdVOzniRed);

                if (vozilo != null)
                {
                    txtVozilo.Text = vozilo.oznakaVozila;
                    txtKasnjenje.Text = GenerirajKasnjenje().ToString();
                    txtStanica.Text = red.stanicaPolaska;
                    napomena.Text = "NAPOMENA: Nema napomene.";

                }
                else
                {
                    napomena.Text = "NAPOMENA: Za odabrani vozni red, trenutno nije definirano nijedno vozilo!";
                }
            }

        }


        private int GenerirajKasnjenje()
        {
            if (kasnjenje == -1) 
            {
                Random random = new Random();
                int maxKasnjenje = 10;
                kasnjenje = random.Next(maxKasnjenje + 1);
            }
            return kasnjenje;
        }


    }
}
