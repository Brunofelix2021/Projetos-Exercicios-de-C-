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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        Cliente oCliente = new Cliente();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreencherForm()
        {
            txtNome.Text = oCliente.strNome;
            txtEndereco.Text = oCliente.strEndereco;
            txtNumero.Text = oCliente.strNumero;
            txtComplemento.Text = oCliente.strComplemento;
            txtBairro.Text = oCliente.strBairro;
            txtCEP.Text = oCliente.strCEP;
            txtCidade.Text = oCliente.strCidade;
            txtEstado.Text = oCliente.strEstado;
            lstTelefones.Items.Clear();
            foreach(string telefone in oCliente.Telefones)
            {
                lstTelefones.Items.Add(telefone);
            }
        }
        private void PreencherClasse()
        {
            oCliente.strCPF = txtCPF.Text;
            oCliente.strNome = txtNome.Text;
            oCliente.strEndereco = txtEndereco.Text;
            oCliente.strNumero = txtNumero.Text;
            oCliente.strComplemento = txtComplemento.Text;
            oCliente.strCEP = txtCEP.Text;
            oCliente.strBairro = txtBairro.Text;
            oCliente.strCidade = txtCidade.Text;
            oCliente.strEstado = txtEstado.Text;
            oCliente.Telefones.Clear();
            foreach(string telefone in lstTelefones.Items)
            {
                oCliente.Telefones.Add(telefone);
            }
        }
        private string ValidarPreenchimento()
        {
            string strMsg = string.Empty;
            if (txtCPF.Text == string.Empty)
            {
                strMsg = "CPF em branco.\n";
            }
            if (txtNome.Text == string.Empty)
            {
                strMsg += "Nome em branco.\n";
            }
            if (txtEndereco.Text == string.Empty)
            {
                strMsg += "Endereço em branco.\n";
            }
            if (txtNumero.Text == string.Empty)
            {
                strMsg += "Número em branco.\n";
            }
            if (txtCEP.Text == string.Empty)
            {
                strMsg += "CEP em branco.\n";
            }
            if (txtBairro.Text == string.Empty)
            {
                strMsg += "Bairro em branco.\n";
            }
            if (txtCidade.Text == string.Empty)
            {
                strMsg += "Cidade em branco.\n";
            }
            if (txtEstado.Text == string.Empty)
            {
                strMsg += "Estado em branco.\n";
            }
            return strMsg;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                string strMsgErro = ValidarPreenchimento();

                if (strMsgErro != string.Empty)
                {
                    MessageBox.Show(strMsgErro, "ERP Senac",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show(string.Format("Confirma {0} do cliente {1}?",
                                    oCliente.intCodigo == 0 ? "gravação" : "alteração",
                                    txtNome.Text),
                                    "ERP Senac", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        PreencherClasse();
                        oCliente.Gravar();
                        MessageBox.Show(string.Format("Cliente {0} com sucesso!",
                            oCliente.intCodigo == 0 ? "gravado" : "alterado"),
                            "ERP Senac",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro-->" + ex.Message, "ERP Senac",
                   MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
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
            lstTelefones.Items.Clear();
            oCliente = new Cliente();
        }

        private void btnAddTel_Click(object sender, EventArgs e)
        {
            if (txtTelefone.Text != string.Empty &&
                lstTelefones.Items.IndexOf(txtTelefone.Text)==-1)
            {
                lstTelefones.Items.Add(txtTelefone.Text);
                txtTelefone.Text = string.Empty;
            }
        }

        private void btnRemTel_Click(object sender, EventArgs e)
        {
            if (lstTelefones.SelectedIndex !=-1)
            {
                lstTelefones.Items.RemoveAt(lstTelefones.SelectedIndex);
            }
        }
    }
}
