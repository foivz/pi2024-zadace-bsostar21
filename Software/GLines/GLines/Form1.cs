using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gumbPutnici_Click(object sender, EventArgs e)
        {
            
            FormaZaPutnike frmPutnici = new FormaZaPutnike();
            frmPutnici.ShowDialog();


        }

        private void gumbZaposlenici_Click(object sender, EventArgs e)
        {
            
            FormaZaPrijavu frmPrijava = new FormaZaPrijavu();
            frmPrijava.ShowDialog();

        }
    }
}
