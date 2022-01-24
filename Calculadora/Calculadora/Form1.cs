using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculdora : Form
    {
        public frmCalculdora()
        {
            InitializeComponent();
        }

        string strOperacao = string.Empty; // vareavel criada fora para todos os metodos 
                                           // verem ela.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            nudNumero1.Value = 0;   // Criando variaveis
            nudNumero2.Value = 0;   // criando variaveis
            txtOperacao.Text = string.Empty; // limpando dados
            txtResultado.Text = string.Empty; //limpando dados
            nudNumero1.Focus();               // colocando o curso no 1º campo 


        }
        private decimal Somar(decimal decN1, decimal decN2)
        {
            return decN1 + decN2;
        }
        private decimal Subtrair(decimal decN1, decimal decN2)
        {
            return decN1 - decN2;
        }
        private decimal Multiplicar(decimal decN1, decimal decN2)
        {
            return decN1 * decN2;
        }
        private decimal Dividir(decimal decN1, decimal decN2)
        {
            return decN1 / decN2;

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "Somar";
            strOperacao = "+";
            btnCalcular.Enabled = true;
        }

        private void btnSubitrair_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "Subtrair";
            strOperacao = "-";
            btnCalcular.Enabled = true;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "Multiplicar";
            strOperacao = "*";
            btnCalcular.Enabled = true;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtOperacao.Text = "Dividir";
            strOperacao = "/";
            btnCalcular.Enabled = true;
        }

        private string Calcular()
        {
            decimal decResultado = 0;
            if (strOperacao == "+")

            {

                decResultado = Somar(nudNumero1.Value, nudNumero2.Value);
            }
            else if (strOperacao == "-")
            {
                decResultado = Subtrair(nudNumero1.Value, nudNumero2.Value);
            }

            else if (strOperacao == "*")
            {
                decResultado = Multiplicar(nudNumero1.Value, nudNumero2.Value);
            }
            else if (strOperacao == "/")
            {
                decResultado = Dividir(nudNumero1.Value, nudNumero2.Value);
            }
            return decResultado.ToString();



        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (strOperacao == "/" && nudNumero2.Value == 0)

            {
                MessageBox.Show("Não é possível dividir por zero.");
            }
            else
            { 
                txtResultado.Text = Calcular();
            }






        }


    }

}

