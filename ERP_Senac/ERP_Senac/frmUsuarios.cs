using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Senac
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        Usuario oUsuario = new Usuario();
        private void CarregarGrid()
        {
            try
            {
                grdUsuarios.DataSource = oUsuario.Consultar();
                //Ocultando colunas
                grdUsuarios.Columns[0].Visible = false;
                grdUsuarios.Columns[3].Visible = false;
                grdUsuarios.Columns[4].Visible = false;
                //Alterando cabeçalho
                grdUsuarios.Columns[1].HeaderText = "Login";
                grdUsuarios.Columns[2].HeaderText = "Nome";
                //Alterando largura
                grdUsuarios.Columns[1].Width = 200;
                grdUsuarios.Columns[2].Width = 400;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "ERP Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            oUsuario = new Usuario();

            if (rdbLogin.Checked)
            {
                oUsuario.strLogin = txtPesquisa.Text;
            }
            else
            {
                oUsuario.strNome = txtPesquisa.Text;
            }
            CarregarGrid();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void PreencherForm()
        {
            txtLogin.Text = oUsuario.strLogin;
            txtNome.Text = oUsuario.strNome;
            txtSenha.Text = oUsuario.strSenha;
            txtConfirmacao.Text = oUsuario.strSenha;
            rdbAtivo.Checked = oUsuario.blnAtivo;
            rdbInativo.Checked = !oUsuario.blnAtivo;
        }
        private void PreencherClasse()
        {
            oUsuario.strLogin = txtLogin.Text;
            oUsuario.strNome = txtNome.Text;
            oUsuario.strSenha = txtSenha.Text;
            oUsuario.blnAtivo = rdbAtivo.Checked;
        }

        private void grdUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                oUsuario.intCodigo = Convert.ToInt32(grdUsuarios.SelectedCells[0].Value);
                oUsuario.Consultar();
                PreencherForm();
                btnGravar.Text = "Alterar Usuário";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "ERP Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsgErro = ValidarPreenchimento();
                if (strMsgErro == string.Empty)
                {
                    if (MessageBox.Show(string.Format("Confirma {0} do usuário {1}?",
                                oUsuario.intCodigo == 0 ? "gravação" : "alteração",
                                txtLogin.Text),
                                "ERP Senac", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        PreencherClasse();
                        oUsuario.Gravar();
                        MessageBox.Show(string.Format("Usuário {0} com sucesso!",
                            oUsuario.intCodigo == 0 ? "gravado" : "alterado"),
                            "ERP Senac",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                        CarregarGrid();
                    } 
                }
                else
                {
                    MessageBox.Show(strMsgErro, "ERP Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "ERP Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            txtPesquisa.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmacao.Text = string.Empty;
            rdbAtivo.Checked = true;
            rdbNome.Checked = true;
            oUsuario = new Usuario();
            btnGravar.Text = "Gravar Usuário";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private string ValidarPreenchimento()
        {
            string strMsg = string.Empty;
            try
            {
                if (txtLogin.Text.Trim()==string.Empty)
                {
                    strMsg = "Login em branco.\n";
                }
                else
                {
                    int intAux = oUsuario.intCodigo;
                    oUsuario.intCodigo = 0;
                    oUsuario.strLogin = txtLogin.Text;
                    oUsuario.Consultar();
                    if (oUsuario.intCodigo != 0 && 
                        (intAux != oUsuario.intCodigo))
                    {
                        strMsg += "Login indisponível.\n";
                    }
                    oUsuario.intCodigo = intAux;
                }
                if (txtNome.Text.Trim()==string.Empty)
                {
                    strMsg += "Nome em branco.\n";
                }
                if (txtSenha.Text.Trim()==string.Empty)
                {
                    strMsg += "Senha em branco.\n";
                }
                else if (txtSenha.Text != txtConfirmacao.Text)
                {
                    strMsg += "Senha e confirmação não conferem.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro-->" + ex.Message, "ERP Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return strMsg;
        }

    }
}
