using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasRepeticao
{
    public partial class frmRepeticao : Form
    {
        public frmRepeticao()
        {
            InitializeComponent();
        }

        private void btnEnquantoFaca_Click(object sender, EventArgs e)
        {
            int intContador = 10;
            while (intContador <=5)
            {
                MessageBox.Show("Estou valendo" + intContador);
                intContador++;
            }
        }

        private void btnFacaEnquanto_Click(object sender, EventArgs e)
        {
            int intContador = 10;
            do
            {
                MessageBox.Show("Estou valendo" + intContador);
                intContador = intContador + 1;
            } while (intContador <= 5);
        
            
            
            }

        private void btnParaAteFaca_Click(object sender, EventArgs e)
        {
            for ( int intContador = 0; intContador <= 5; intContador++)
            {
                MessageBox.Show("Estou valendo" + intContador);


            }
        }
    }
}
