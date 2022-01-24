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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        //Instanciamos um objeto da Classe Cliente
        Cliente oCliente = new Cliente();
        //Criamos o evento Click do botão cancelar (Clicando 2x sobre o componente)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fechamos o formulário de clientes
            this.Close();
        }
        //Criamos o método para validar o preenchimento do formulário
        private string ValidarPreenchimento()
        {
            //Criamos uma variável string para armazenar as mensagens de erro
            string strMensagem = string.Empty;
            //Verificamos se os campos estão em branco (string.Empty)
            if (txtCPF.Text == string.Empty)
            {
                strMensagem = "CPF em branco.\n";
            }
            if (txtNome.Text == string.Empty)
            {
                strMensagem += "Nome em branco.\n";
            }
            if (txtEndereco.Text == string.Empty)
            {
                strMensagem += "Endereço em branco.\n";
            }
            if (txtNumero.Text == string.Empty)
            {
                strMensagem += "Número em branco.\n";
            }
            if (txtBairro.Text == string.Empty)
            {
                strMensagem += "Bairro em branco.\n";
            }
            if (txtCEP.Text == string.Empty)
            {
                strMensagem += "CEP em branco.\n";
            }
            if (txtCidade.Text == string.Empty)
            {
                strMensagem += "Cidade em branco.\n";
            }
            if (txtEstado.Text == string.Empty)
            {
                strMensagem += "Estado em branco.\n";
            }
            if (lstTelefone.Items.Count == 0)
            {
                strMensagem += "Nenhum telefone informado.";
            }
            //Retornamos a mensagem de erro
            return strMensagem;
        }
        //Criamos o método para preencher os campos do formulário com os dados retornados do banco de dados
        private void PreencherForm()
        {
            //Atribuímos cada informação a seu respectivo componente
            txtNome.Text = oCliente.strNome;
            txtEndereco.Text = oCliente.strEndereco;
            txtNumero.Text = oCliente.strNumero;
            txtComplemento.Text = oCliente.strComplemento;
            txtBairro.Text = oCliente.strBairro;
            txtCEP.Text = oCliente.strCEP;
            txtCidade.Text = oCliente.strCidade;
            txtEstado.Text = oCliente.strEstado;
            //Percorremos a lista de telefones
            foreach (string tel in oCliente.strTelefones)
            {
                //Adicionando cada um deles ao ListBox
                lstTelefone.Items.Add(tel);
            }
        }
        //Criamos o método para armazenar os dados que serão enviados ao banco de dados
        private void PreencherClasse()
        {
            //Atribuímos cada informação a seus respectivo atributo
            oCliente.strCPF = txtCPF.Text;
            oCliente.strNome = txtNome.Text;
            oCliente.strEndereco = txtEndereco.Text;
            oCliente.strNumero = txtNumero.Text;
            oCliente.strComplemento = txtComplemento.Text;
            oCliente.strBairro = txtBairro.Text;
            oCliente.strCEP = txtCEP.Text;
            oCliente.strCidade = txtCidade.Text;
            oCliente.strEstado = txtEstado.Text;
            oCliente.strTelefones.Clear();
            //Percorremos todos os itens do ListBox
            foreach (string tel in lstTelefone.Items)
            {
                //Adicionando cada um deles a lista de telefones
                oCliente.strTelefones.Add(tel);
            }
        }
        //Criamos o método para limpar os campos do formulário
        private void LimparCampos()
        {
            //Limpamos todos os TextBox
            txtCPF.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCEP.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            //Limpamos todos os items do ListBox
            lstTelefone.Items.Clear();
            //Criamos um novo objeto substituindo o anterior
            oCliente = new Cliente();
        }
        //Criamos o evento Click do botão limpar (Clicando 2x sobre o componente)
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chamamos o método para limpar os campos do formulário
            LimparCampos();
        }
        //Criamos o evento Click do botão adicionar (Clicando 2x sobre o componente)
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Verificamos se algum dado existe no TextBox
            if (txtTelefone.Text != string.Empty)
            {
                //Verificamos se o telefone digitado já existe no ListBox
                if (lstTelefone.Items.IndexOf(txtTelefone.Text) == -1)
                {
                    //Adicionamos o telefone aos itens do ListBox
                    lstTelefone.Items.Add(txtTelefone.Text);
                    //Limpamos o TextBox para a digitação de um novo telefone
                    txtTelefone.Text = string.Empty;
                }
                //Caso o telefone já exista 
                else
                {
                    //Mostramos a mensagem ao usuário
                    MessageBox.Show("Telefone já adicionado.", "CRM Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Retornamos o cursor ao TextBox
                    txtTelefone.Focus();
                }
            }
        }
        //Criamos o evento Click do botão remover (Clicando 2x sobre o componente)
        private void btnRemover_Click(object sender, EventArgs e)
        {
            //Verificamos se existe algum item selecionado no ListBox
            if (lstTelefone.SelectedIndex != -1)
            {
                //Removemos o item selecionado (SelectedIndex)
                lstTelefone.Items.RemoveAt(lstTelefone.SelectedIndex);
            }
        }
        //Criamos o evento Click do botão gravar (Clicando 2x sobre o componente)
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Chamamos o método para validar o preenchimento do formulário
                //e atribuímos a mensagem de erro a string strMsgErro
                string strMsgErro = ValidarPreenchimento();
                //Verificamos se existe alguma mensagem na variável
                if (strMsgErro != string.Empty)
                {
                    //Mostramos a mensagem de erro
                    MessageBox.Show(strMsgErro, "CRM Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Retornamos o cursor ao TextBox CPF
                    txtCPF.Focus();
                }
                //Caso não exista dados na mensagem
                else
                {
                    //Chamamos o método para armazenarmos os dados preenchidos no formulário
                    PreencherClasse();
                    //Chamamos o método para efetuar a gravação dos dados no banco de dados
                    oCliente.Gravar();
                    //Exibimos a mensagem de sucesso ao usuário
                    MessageBox.Show("Cliente gravado com sucesso.", "CRM Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Chamamos o método para limpar os campos do formulário
                    LimparCampos();
                    //Retornamos o cursor ao TextBox CPF
                    txtCPF.Focus();
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
        //Criamos o método Leave do TextBox através da janela propriedades e eventos para consultarmos o CPF digitado
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Verificamos se o CPF foi preenchido
                if (txtCPF.Text != string.Empty)
                {
                    //Atribuímos o CPF digitado ao objeto oCliente
                    oCliente.strCPF = txtCPF.Text;
                    //Chamamos o método para consultar o CPF informado
                    oCliente.Consultar();
                    //Verificamos se existe algum código de cliente retornado
                    if (oCliente.intCodigo != 0)
                    {
                        //Limpamos os itens do ListBox
                        lstTelefone.Items.Clear();
                        //Chamamos o método para preencher os campos do formulário 
                        //com os dados retornados do banco de dados
                        PreencherForm();
                    }
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

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
