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
    public partial class FormaZaVozila : Form
    {
        public FormaZaVozila()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajVozilo_Click(object sender, EventArgs e)
        {
            FormaDodajVozilo formaDodajVozilo = new FormaDodajVozilo();
            formaDodajVozilo.ShowDialog();
        }

        private void gumbAzurirajVozilo_Click(object sender, EventArgs e)
        {

        }
    }
}
