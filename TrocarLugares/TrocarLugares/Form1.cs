using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocarLugares
{
    public partial class frmTrocarLugares : Form
    {
        public frmTrocarLugares()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string stringInfo1 = "";
            string stringInfo2 = "";
            string stringInfoAux = "";



            string sInfoAux = txtInfo1.Text;
            txtInfo1.Text = txtInfo2.Text;
            txtInfo2.Text = sInfoAux;


               



        }
    }
}
