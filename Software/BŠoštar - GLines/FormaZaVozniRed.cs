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
    public partial class FormaZaVozniRed : Form
    {
        public FormaZaVozniRed()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajVozniRed_Click(object sender, EventArgs e)
        {
            FormaDodajVozniRed formaDodajVozniRed = new FormaDodajVozniRed();
            formaDodajVozniRed.ShowDialog();
        }

        private void gumbAzurirajVozniRed_Click(object sender, EventArgs e)
        {
            FormaAzurirajVozniRed formaAzurirajVozniRed = new FormaAzurirajVozniRed();
            formaAzurirajVozniRed.ShowDialog();
        }
    }
}
