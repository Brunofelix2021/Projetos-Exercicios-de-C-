using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContadorX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            txtContar.Text = string.Empty;

            decimal decContador = nudinicio.Value;
            do

            {
               





                if (decContador % NudMultiplo.Value  != 0) // se o resto da divisão por 4 for diferente de 0
                {
                    txtContar.Text += decContador.ToString(); // então ele adiciona o numeoro do contador

                }


                else
                {
                    txtContar.Text += "X"; // se o resto for igual a 0 ele adiciona o "X"

                }

                if (decContador < nudTermino.Value)   // += acrescenta  depois do numero para somar e colocar o "-" para separar o codigo
                    txtContar.Text += "-";
                decContador = decContador + 1;
            } while (decContador <= nudTermino.Value );



        



        



    
        }
    }
}
