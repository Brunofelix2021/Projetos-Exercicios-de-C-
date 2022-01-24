using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindows
{
    public partial class FrnCalculadora : Form
    {
        public FrnCalculadora()
        {
            InitializeComponent();
        }


        double dblNumero1 = 0;
        double dblNumero2 = 0;
        string strMemoria = "0";                   // variavies
        string strOperacao = string.Empty;
        bool blnConcatenar = false;
        bool blnOperacao = false;


        private void btn1_Click(object sender, EventArgs e)

        {
            AtribuiNumero("1");

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            AtribuiNumero("2");

        }

        private void btn3_Click(object sender, EventArgs e)
        {

            AtribuiNumero("3");

        }

        private void btn4_Click(object sender, EventArgs e)


        {
            AtribuiNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)

        {
            AtribuiNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            AtribuiNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AtribuiNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            AtribuiNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            AtribuiNumero("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {


            if (strOperacao != string.Empty && !blnConcatenar)       // segue a mesma lógica do btn1 para os demais botões
            {

                lblVisor.Text += "0";
                blnConcatenar = true;

            }
            else if (lblVisor.Text != "0")
            {
                if (lblVisor.Text.Length < 10)
                {


                    lblVisor.Text += "0";

                }
            }
            blnOperacao = false;
        }

        private void btnC_Click(object sender, EventArgs e)  // limpando os campo e colocando parea exibir o 0 no visor
        {
            lblVisor.Text = "0";
            lblOperacao.Text = string.Empty;
            blnConcatenar = false;
            blnOperacao = false;
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {


            if (strOperacao != string.Empty && !blnConcatenar)                 //indexOF = "indece de" quando está em -1 é = vazio então quando estiever vazio ele não coloca , para que não ocorra de colocar varias vezes a virgula
            {
                lblVisor.Text += "0,";
                blnConcatenar = true;
            }
            else if (lblVisor.Text.IndexOf(",") == -1)
            {
                if (lblVisor.Text.Length < 10)
                {


                    lblVisor.Text += ",";

                }
            }
            blnOperacao = false;
        }
        private void btnInverterSinal_Click(object sender, EventArgs e) // colocando o botão +/- e colocando if para 
        {
            if (lblVisor.Text != "0") // if da condição para  que v
            {
                if (lblVisor.Text.IndexOf("-") == -1)
                {
                    lblVisor.Text = "-" + lblVisor.Text;
                }
                else
                {
                    lblVisor.Text = lblVisor.Text.Replace("-", "");
                    // lblVisor.Text = lblVisor.Text.Substring(1); também é uma opção  que da certo para este codigo
                }

            }

        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            int intTamanho = lblVisor.Text.Length;
            if (intTamanho == 1 || intTamanho == 2 && lblVisor.Text.IndexOf("-") != -1 || (lblVisor.Text == "-0,"))                 // mostrando que tem uma caracter ainda no visor pois o visor não pode ficar sem nenhum caracter no visor
            {
                lblVisor.Text = "0";

            }
            else
            {
                lblVisor.Text = lblVisor.Text.Substring(0, intTamanho - 1);
            }

        }

        private void btnMc_Click(object sender, EventArgs e) // botão da memoria limpando ela e apagando o M
        {
            lblMemoria.Visible = false;
            strMemoria = "0";
        }

        private void btnMr_Click(object sender, EventArgs e) //memoria recouver usada para armazenar números 
        {
            lblVisor.Text = strMemoria;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            Memoria("+");
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {

            Memoria("-");

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            AtribuirSinal("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            AtribuirSinal("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            AtribuirSinal("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            AtribuirSinal("/");
        }

        private double Somar()
        {
            return dblNumero1 + dblNumero2; // criando metodos iguais o da ultima calculadora para fazer as operções
        }
        private double Subtrair()
        {
            return dblNumero1 - dblNumero2;
        }
        private double Multiplicar()
        {
            return dblNumero1 * dblNumero2;
        }
        private double Dividir()
        {
            return dblNumero1 / dblNumero2;
        }

        private string Calcular()
        {
            double dblResultado = 0;   // metodos
            if (strOperacao == "+")
            {
                dblResultado = Somar();
            }
            else if (strOperacao == "-")
            {
                dblResultado = Subtrair();
            }
            else if (strOperacao == "*")
            {
                dblResultado = Multiplicar();
            }
            else if (strOperacao == "/")
            {
                dblResultado = Dividir();
            }

            return dblResultado.ToString();


        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            Resultado();

            lblOperacao.Text = string.Empty;
        }

        private void Resultado()
        {

            dblNumero2 = Convert.ToDouble(lblVisor.Text);
            string strResultado = Calcular();
            lblVisor.Text = strResultado.Length > 10 ? strResultado.Substring(0, 10) : strResultado;
        }

        private void AtribuiNumero(string strNumero)
        {
            if (lblVisor.Text == "0" || (strOperacao != string.Empty && !blnConcatenar))                    // colocando uma condição para que o 0 não seja exibida antes do 1
            {
                lblVisor.Text = strNumero;                                                                   // colocando que ele é igual a um
                blnConcatenar = true;
            }

            else
            {
                if (lblVisor.Text.Length < 10)                                                                // if criado para limitar a quantidade de caratcter no visor no caso até 10 números
                {
                    lblVisor.Text += strNumero;                                                                //concatenando os números 11111...
                }

            }

            blnOperacao = false;
        }

        private void AtribuirSinal(string strSinal)
        {
            if (blnOperacao)
            {
                lblOperacao.Text = lblOperacao.Text.Substring(0, lblOperacao.Text.Length - 1) + strSinal;
                strOperacao = strSinal;
            }

            else
            {


                lblVisor.Text = Convert.ToDouble(lblVisor.Text).ToString();

                if (lblOperacao.Text == string.Empty)

                {
                    lblOperacao.Text += lblVisor.Text + strSinal;
                    dblNumero1 = Convert.ToDouble(lblVisor.Text);
                }
                else
                {



                    bool blnNegativo = lblVisor.Text.IndexOf("-") != -1;
                    lblOperacao.Text += string.Format("{0}{1}{2}{3}", blnNegativo ? "(" : "", lblVisor.Text, blnNegativo ? ")" : "", strSinal); // colocado (Parebntes na conta para números negativos exemplo  10+20 trocando sinal -30(-)) 

                    dblNumero2 = Convert.ToDouble(lblVisor.Text);
                    Resultado();
                    dblNumero1 = Convert.ToDouble(lblVisor.Text);
                }


                strOperacao = strSinal;
                blnConcatenar = false;
                blnOperacao = true;
            }

        }

        private void Memoria(string strSinal)
        {
            dblNumero1 = Convert.ToDouble(strMemoria);        // criando metodos para o M+ memoria que soma os valores e guarda sempre o resultado
            dblNumero2 = Convert.ToDouble(lblVisor.Text);
            strOperacao = strSinal;
            lblVisor.Text = Calcular();
            strMemoria = lblVisor.Text;
            lblMemoria.Visible = true;
            blnConcatenar = false;
        }

        private void timer1_Tick(object sender, EventArgs e)  // Cronomo para chamado "Timer1", usado para atualzar coisas quando precisamos   usar automaticamente tipo um hiper link
        {
            toolTip1.SetToolTip(lblOperacao, lblOperacao.Text);
        }

        private void FrnCalculadora_KeyPress(object sender, KeyPressEventArgs e) // colocabdo evento para associar o teclado ao fotmulário
        {
           if(e.KeyChar == (char)Keys.Back)    // keys possui todas as teclas para ser igual a qual eu e colocar qual tecla quer associar a tecla ao botão do formulário
            {
                btnBS.PerformClick();
            }
           else if (e.KeyChar == '0')  // associando o botão da calculadora ao botão do teclado 
            {
                btn0.PerformClick();
            }
            else if (e.KeyChar == '1')  // associando o botão da calculadora ao botão do teclado
            {
                btn1.PerformClick();
            }
            else if (e.KeyChar == '2')   // associando o botão da calculadora ao botão do teclado
            {
                btn2.PerformClick();
            }
            else if (e.KeyChar == '3')      // associando o botão da calculadora ao botão do teclado
            {
                btn3.PerformClick();
            } 
            else if (e.KeyChar == '4')       // associando o botão da calculadora ao botão do teclado
            {
                btn4.PerformClick();
            }
            else if (e.KeyChar == '5')           // associando o botão da calculadora ao botão do teclado
            {
                btn5.PerformClick();
            }
            else if (e.KeyChar == '6')          // associando o botão da calculadora ao botão do teclado
            { 
                btn6.PerformClick();
            }
            else if (e.KeyChar == '7')          // associando o botão da calculadora ao botão do teclado
            {
                btn7.PerformClick();
            }
            else if (e.KeyChar == '8')          // associando o botão da calculadora ao botão do teclado
            {
                btn8.PerformClick();
            }
            else if (e.KeyChar == '9')          // associando o botão da calculadora ao botão do teclado
            {
                btn9.PerformClick();
            }
            else if (e.KeyChar == ',')          // associando o botão da calculadora ao botão do teclado
            {
                btndecimal.PerformClick();
            }
            else if (e.KeyChar == '+')
            {
                btnSomar.PerformClick();       // associando o botão da calculadora ao botão do teclado
            }
            else if (e.KeyChar == '-')
            {
                btnSubtrair.PerformClick();   // associando o botão da calculadora ao botão do teclado
            }
            else if (e.KeyChar == '/')
            {
                btnDividir.PerformClick();
            }
        

        }
    }
}
