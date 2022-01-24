using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NomeCompleto
{
    public partial class FfmNomeCompleto : Form
    {
        public FfmNomeCompleto()
        {
            InitializeComponent();
        }

        private void FfmNomeCompleto_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtSobrenome.Text != string.Empty)
            {
                txtNomeCompleto.Text = txtNome.Text.Trim() + " " + txtSobrenome.Text.Trim();
            }
            else
            {
                string strMsgErro = string.Empty;
                // verificando se o some está preenchido *****SE NÃO

                if (txtNome.Text == string.Empty)
                {
                     strMsgErro ="Nome em Branco.\n";
                }

                if (txtSobrenome.Text == string.Empty)

                {
                     strMsgErro += "Sobrenome em branco.";


                }
                MessageBox.Show(strMsgErro);

             }

         }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty; //deixando 
            txtSobrenome.Text = string.Empty;
            txtNomeCompleto.Text = string.Empty;
            txtNome.Focus();

        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
