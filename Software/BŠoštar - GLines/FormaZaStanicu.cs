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
    public partial class FormaZaStanicu : Form
    {
        public FormaZaStanicu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gumbDodajStanicu_Click(object sender, EventArgs e)
        {
            FormaDodajStanicu formaDodajStanicu = new FormaDodajStanicu();
            formaDodajStanicu.ShowDialog();
        }
    }
}
