using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_Senac
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Criamos uma variável DateTime
        DateTime dttLogin;
        //Criamos o evento Load (clicando 2x no cabeçalho do formulário)
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Atribuímos o nome do usuário logado ao Label
            lblUsuario.Text = "Usuário: " + Global.strNomeUsuario;
            //Armazenamos o horário em que o login foi efetuado
            dttLogin = DateTime.Now;
            //Iniciamos a contagem do Timer para exibirmos o tempo de logado
            timer1.Enabled = true;
        }
        //Criamos o evento Click do menu usuarios (clicando 2x sobre o menu)
        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            //Instanciamos um objeto da classe frmUsuarios;
            frmUsuarios ofrmUsuarios = new frmUsuarios();
            //Chamamos o método para abrir o formulário
            AbrirForm(ofrmUsuarios);
        }
        //Criamos o evento Click do menu clientes (clicando 2x sobre o menu)
        private void mnuClientes_Click(object sender, EventArgs e)
        {
            //Instanciamos um objeto da classe frmClientes;
            frmClientes ofrmClientes = new frmClientes();
            //Chamamos o método para abrir o formulário
            AbrirForm(ofrmClientes);
        }
        //Criamos o método para abrir o formulário informado
        private void AbrirForm(Form pForm)
        {
            //Criamos uma variável (flag) para servir de indicador caso o formulário já exteja aberto
            bool blnExiste = false;
            //Percorremos todos os formulários abertos (MdiChildren) no formulário principal (this)
            foreach (Form filho in this.MdiChildren)
            {
                //verificamos se o nome do formulário aberto coincide com o
                //formulário que está tentando ser aberto
                if (filho.Name == pForm.Name)
                {
                    //Caso os nomes sejam iguais, alteramos o indicador para true
                    blnExiste = true;
                    //Encerramos a busca
                    break;
                }
            }
            //Verificamos se o indicador está false
            if (!blnExiste)
            {
                //Definimos o formulário principal como PAI
                pForm.MdiParent = this;
                //Exibimos o formulário desejado
                pForm.Show();
            }
        }
        //Criamos o evento Click do menu sair (clicando 2x sobre o menu)
        private void mnuSair_Click(object sender, EventArgs e)
        {
            //Fechamos o formulário principal
            this.Close();
        }
        //Criamos o evento FormClosing do frmPrincipal através da janela propriedades e eventos para 
        //questionarmos o usuário sobre a intenção de fechar o sistema
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Questionamos ao usuário a intenção de encerrar a aplicação
            if (MessageBox.Show("Deseja encerrar o CRM Senac?",
               "CRM Senac", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                //Caso a resposta seja negativa, cancelamos o evento de fechamento do formulário (FormClosing)
                e.Cancel = true;
            }
            
        }
        //Criamos o evento Tick do Timer (clicando 2x sobre o menu)
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Instanciamos um objeto TimeSpan para efetuarmos contas com tempo, subtraindo a hora atual da hora do login
            TimeSpan ts = DateTime.Now.Subtract(dttLogin);
            //Mostramos ao usuário o tempo que o mesmo está logado
            lblTempo.Text = String.Format("Duração: {0}:{1}:{2}",
                ts.Hours.ToString("00"),
                ts.Minutes.ToString("00"),
                ts.Seconds.ToString("00"));
        }
        //Criamos o evento Click do menu sobre (clicando 2x sobre o menu)
        private void mnuSobre_Click(object sender, EventArgs e)
        {
            //Instanciamos um objeto da classe frmSobre;
            frmSobre ofrmSobre = new frmSobre();
            //Chamamos o método para abrir o formulário
            AbrirForm(ofrmSobre);
        }
    }
}
