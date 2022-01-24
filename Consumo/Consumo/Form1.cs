using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumo
{
    public partial class FrmConsumo : Form
    {
        public FrmConsumo()
        {
            InitializeComponent();
        }

        private void btnCalcularConsumo_Click(object sender, EventArgs e)
        {
            string strMsgErro = string.Empty;
            decimal decAux = 0;


            if (txtNome.Text.Trim() == string.Empty)
            {

                strMsgErro += ("Nome em Branco!\n");
            }

            if (txtDistância.Text == string.Empty)

            {
                strMsgErro += ("Distância em branco!\n");

            }

            else if (!decimal.TryParse(txtDistância.Text, out decAux))// verdadeiro ou falso
            {
                strMsgErro += ("Distância invalida!\n");
            }

            if (txtLitros.Text == string.Empty)
            {

                strMsgErro += ("campo Litros em branco!\n");


            }

            else if (!decimal.TryParse(txtLitros.Text, out decAux))
            {
                strMsgErro += ("Campo litros invalidos!\n");
            }



            if (strMsgErro != string.Empty)
            {

                MessageBox.Show(strMsgErro);
            }
            else
            {
                decimal intConsumida; //vareaveis
                decimal intDistância;  //vareaveis
                decimal intLitros;     //vareaveis

                intDistância = Convert.ToInt32(txtDistância.Text); //convertendo de 
                intLitros = Convert.ToInt32(txtLitros.Text);        // texto para decim.

                intConsumida = intDistância / intLitros;   // fazendo operação matematica

                txtConsumo.Text = intConsumida.ToString(); // fazendo a com que resultado
                                                           //da operação a sendo colocada no campo a ser exibido o textbox do consumo





            }

        }
    }
}
