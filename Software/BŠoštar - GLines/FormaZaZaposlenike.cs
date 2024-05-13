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
    public partial class FormaZaZaposlenike : Form
    {
        public FormaZaZaposlenike()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbVozilo_Click(object sender, EventArgs e)
        {
            FormaZaVozila formaZaVozila = new FormaZaVozila();
            formaZaVozila.ShowDialog();
        }

        private void gumbStanica_Click(object sender, EventArgs e)
        {
            FormaZaStanicu formaZaStanicu = new FormaZaStanicu();   
            formaZaStanicu.ShowDialog();    
        }

        private void gumbLinija_Click(object sender, EventArgs e)
        {

        }

        private void gumbVozniRed_Click(object sender, EventArgs e)
        {

        }
    }
}
