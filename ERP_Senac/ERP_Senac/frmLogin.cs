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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsg = string.Empty;
                Usuario oUsuario = new Usuario();
                oUsuario.strLogin = txtUsuario.Text;
                oUsuario.Consultar();
                if (oUsuario.intCodigo == 0)
                {
                    strMsg = "Usuário inválido.";
                }
                else if (oUsuario.strSenha != txtSenha.Text)
                {
                    strMsg = "Senha inválida.";
                }
                else if (!oUsuario.blnAtivo)
                {
                    strMsg = "Usuário Inativo.";
                }
                if (strMsg != string.Empty)
                {
                    MessageBox.Show(strMsg, "ERP Senac", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show(string.Format("Bem vindo {0}", oUsuario.strNome),
                        "ERP Senac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    Global.intCodigoUsuario = oUsuario.intCodigo;
                    Global.strNomeUsuario = oUsuario.strNome;
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro-->" + ex.Message, "ERP Senac",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
