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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Instanciamos um objeto da classe Usuário
        Usuario oUsuario = new Usuario();
        //Criamos o evento Click do botão cancelar (Clicando 2x sobre o componente)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fechamos o formulário de clientes
            this.Close();
        }
        //Criamos o evento Click do botão Ok (Clicando 2x sobre o componente)
        private void btnOk_Click(object sender, EventArgs e)
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Atribuímos o usuário digitado ao atributo o objeto
                oUsuario.strUsuario = txtUsuario.Text;                
                //Chamamos o método para autenticar o usuário digitado e verificamos seu retorno
                if (oUsuario.AutenticarUsuario())
                {                    
                    //Caso o retorno seja true, verificamos se a senha digitada confere com a 
                    //senha retornada pelo banco de dados
                    if (txtSenha.Text == oUsuario.strSenha)
                    {
                        //Caso a senha esteja correta, verificamos se o usuário está ativo
                        if (oUsuario.blnAtivo)
                        {
                            //Caso o usuário esteja ativo, mostramos a mensagem de boas vindas
                            MessageBox.Show("Bem Vindo "+ oUsuario.strNome, "CRM Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //Atribuímos os dados do usuário às variáveis estaticas
                            Global.intCodigoUsuario = oUsuario.intCodigo;
                            Global.strNomeUsuario = oUsuario.strNome;
                            //Definimos o resultado do diálogo como Ok
                            this.DialogResult = DialogResult.OK;
                            //Fechamos o formulário de login
                            this.Close();
                        }
                            //Caso o usuário esteja inativo
                        else
                        {
                            //Mostramos a mensagem ao usuário
                            MessageBox.Show("Usuário Inativo.", "CRM Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //Retornamos o cursor ao TextBox 
                            txtUsuario.Focus();
                        }
                    }
                        //Caso a senha não esteja correta
                    else
                    {
                        //Mostramos a mensagem ao usuário
                        MessageBox.Show("Senha incorreta.", "CRM Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Retornamos o cursor ao TextBox 
                        txtUsuario.Focus();
                    }
                }
                    //Caso o usuário não exista no banco de dados
                else
                {
                    //Mostramos a mensagem ao usuário
                    MessageBox.Show("Usuário inválido.", "CRM Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Retornamos o cursor ao TextBox 
                    txtUsuario.Focus();
                }
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //Mostramos o erro para o usuário
                MessageBox.Show("Erro-->" + ex.Message, "CRM Senac",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
