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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
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
        //Criamos o evento TextChanged do frmUsuarios através da janela propriedades e eventos para 
        //efetuarmos a pesquisa por parte do nome do usuário a cada tecla pressionada
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            //Atribuímos o conteúdo do TextBox ao atributo nome do objeto
            oUsuario.strNome = txtPesquisa.Text;
            //Zeramos o código e apagamos o usuário para garantirmos a pesquisa pelo nome
            oUsuario.intCodigo = 0;
            oUsuario.strUsuario = string.Empty;
            //chamamos o método para efetuar a consulta e preencher o grid com o resultado
            CarregarGrid();
        }
        //Criamos o método para efetuar a consulta do usuário e preencher o grid
        private void CarregarGrid()
        {
            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Chamamos o método consultar da classe Usuario e atribuímos o resultado 
                //com origem dos dados (DataSource) do grid
                grdUsuarios.DataSource = oUsuario.Consultar();
                //Definimos as colunas 0 e 2 como invisíveis (código e senha)
                grdUsuarios.Columns[0].Visible = false;
                grdUsuarios.Columns[2].Visible = false;
                //Defimos a largura do restante das colunas
                grdUsuarios.Columns[1].Width = 100;
                grdUsuarios.Columns[3].Width = 200;
                grdUsuarios.Columns[4].Width = 50;
                //Definimos o cabeçalho do grid para um texto amigável
                grdUsuarios.Columns[1].HeaderText = "Usuário";
                grdUsuarios.Columns[3].HeaderText = "Nome";
                grdUsuarios.Columns[4].HeaderText = "Status";
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //Mostramos o erro para o usuário
                MessageBox.Show("Erro-->" + ex.Message, "CRM Senac",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Criamos o método para preencher os campos do formulário com os dados retornados do banco de dados
        private void PreencherForm()
        {
            //Atribuímos cada informação a seu respectivo componente
            txtUsuario.Text = oUsuario.strUsuario;
            txtNome.Text = oUsuario.strNome;
            txtSenha.Text = oUsuario.strSenha;
            txtConfirmacao.Text = oUsuario.strSenha;
            rdbAtivo.Checked = oUsuario.blnAtivo;
            rdbInativo.Checked = !oUsuario.blnAtivo;
        }
        //Criamos o método para armazenar os dados que serão enviados ao banco de dados
        private void PreencherClasse()
        {
            //Atribuímos cada informação a seus respectivo atributo
            oUsuario.strUsuario = txtUsuario.Text;
            oUsuario.strNome = txtNome.Text;
            oUsuario.strSenha = txtSenha.Text;
            oUsuario.blnAtivo = rdbAtivo.Checked;
        }
        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oUsuario.intCodigo = Convert.ToInt32(grdUsuarios.SelectedCells[0].Value);
                oUsuario.Consultar();
                PreencherForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "CRM Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Criamos o método para limpar os campos do formulário
        private void LimparCampos()
        {
            //Limpamos todos os TextBox
            txtUsuario.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmacao.Text = string.Empty;
            rdbAtivo.Checked = true;
            //Criamos um novo objeto substituindo o anterior
            oUsuario = new Usuario();
            //Limpamos o TextBox de Pesquisa
            txtPesquisa.Text = string.Empty;
        }
        //Criamos o evento Click do botão limpar (Clicando 2x sobre o componente)
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Chamamos o método para limpar os campos do formulário
            LimparCampos();
        }
        //Criamos o evento Load (clicando 2x no cabeçalho do formulário)
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            //Chamamos o método para Consultar os usuários e preencher o grid
            CarregarGrid();
        }
        //Criamos o método para validar o preenchimento do formulário
        private string ValidarPreenchimento()
        {
            //Criamos uma variável string para armazenar as mensagens de erro
            string strMensagem = string.Empty;

            //Iniciamos um bloco Try/Catch para "pegarmos" qualquer erro (Excessão) durante o processo do bloco try
            try
            {
                //Verificamos se o usuário foi preenchido
                if (txtUsuario.Text == string.Empty)
                {
                    //Atribuímos a mensagem de erro
                    strMensagem = "Usuário em branco.\n";
                }
                else
                {
                    //Atribuímos o código do usuário selecionado, (0 para um usuário novo) a uma variável auxiliar
                    int intAux = oUsuario.intCodigo;
                    //zeramos o código e o nome para garantirmos a consulta pelo usuário
                    oUsuario.intCodigo = 0;
                    oUsuario.strNome = string.Empty;
                    //Atribuímos o usuário digitado ao atributo da classe
                    oUsuario.strUsuario = txtUsuario.Text;
                    //Chamamos o método para consultar o usuário
                    oUsuario.Consultar();
                    //Verificamos se o usuário retornado é diferente do usuário selecionado (0 para um usuário novo)
                    if (oUsuario.intCodigo != 0 && oUsuario.intCodigo != intAux)
                    {
                        //Atribuímos a mensagem de erro
                        strMensagem += "Usuário indisponível.\n";
                    }
                    //retornamos o código do usuário selecionado ao atributo da classe (0 para um usuário novo)
                    oUsuario.intCodigo = intAux;
                }
                //Verificamos se o nome está preenchido
                if (txtNome.Text == string.Empty)
                {
                    //Atribuímos a mensagem de erro
                    strMensagem += "Nome em branco.\n";
                }
                //Verificamos se a senha está preenchida
                if (txtSenha.Text == string.Empty)
                {
                    //Atribuímos a mensagem de erro
                    strMensagem += "Senha em branco.\n";
                }
                //Verificamos se a senha e a confirmação conferem
                else if (txtSenha.Text != txtConfirmacao.Text)
                {
                    //Atribuímos a mensagem de erro
                    strMensagem += "Senha e confirmação não conferem.\n";
                }
            }
            //Caso ocorra algum erro de processamento, "pegamos" o erro
            catch (Exception ex)
            {
                //Mostramos o erro para o usuário
                MessageBox.Show("Erro-->" + ex.Message, "CRM Senac",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Retornamos a mensagem de erro
            return strMensagem;
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
                    //Retornamos o cursor para o TextBox usuário
                    txtUsuario.Focus();
                }
                //Caso não exista dados na mensagem
                else
                {
                    //Chamamos o método para armazenarmos os dados preenchidos no formulário
                    PreencherClasse();
                    //Chamamos o método para efetuar a gravação dos dados no banco de dados
                    oUsuario.Gravar();
                    //Exibimos a mensagem de sucesso ao usuário
                    MessageBox.Show("Usuário gravado com sucesso.", "CRM Senac",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Chamamos o método para limpar os campos do formulário
                    LimparCampos();
                    //Chamamos o método para consultar os usuários e atualizar o grid
                    CarregarGrid();
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
    }
}
