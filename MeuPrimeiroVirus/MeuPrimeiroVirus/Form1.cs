using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuPrimeiroVirus
{
    public partial class frmVirus : Form
    {
        public frmVirus()
        {
            InitializeComponent();
        }

        private void btnVírus_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmVirus_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("Passou");
        }

        private void btnVírus_MouseHover(object sender, EventArgs e)
        {
           // MessageBox.Show("Passou Botão");
        }

        private void btnVírus_MouseEnter(object sender, EventArgs e)
        {
            //1024 x 768 comentário
            int x = DateTime.Now.Millisecond;
            int y = DateTime.Now.Second * 10;
            this.Top = Convert.ToInt32(y);
            this.Left = Convert.ToInt32(x);


            
        }

    }
}
