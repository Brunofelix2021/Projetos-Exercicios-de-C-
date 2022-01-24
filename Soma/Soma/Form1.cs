using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma
{
    public partial class frmSoma : Form
    {
        public frmSoma()
        {
            InitializeComponent();
        }
        int intNumero1 = 0;
        int intNumero2 = 0;
        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            int intSoma = 0;

            intNumero1 = Convert.ToInt32 (txtNumero1.Text);
            intNumero2 = Convert.ToInt32 (txtNumero2.Text);
            intSoma = Somar();
            txtSoma.Text = intSoma.ToString();
        }
        private int Somar()
        {
            return intNumero1 + intNumero2;
        }
      

    }
}
