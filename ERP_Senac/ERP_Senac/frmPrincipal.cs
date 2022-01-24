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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        DateTime dttLogin;
        private void AbrirForm(Form pForm)
        {
            bool blnExiste = false;
            foreach (Form filho in this.MdiChildren)
            {
                if (filho.Name == pForm.Name)
                {
                    blnExiste = true;
                    break;
                }
            }
            if (!blnExiste)
            {
                pForm.MdiParent = this;
                pForm.Show();
            }
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios ofrmUsuarios = new frmUsuarios();
            AbrirForm(ofrmUsuarios);
        }

        private void mnuSaida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?",
                "ERP Senac", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + Global.strNomeUsuario;
            tmrPrincipal.Enabled = true;
            dttLogin = DateTime.Now;
        }

        private void tmrPrincipal_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now.Subtract(dttLogin);
            lblTempo.Text = string.Format("{0}:{1}:{2}",
                ts.Hours.ToString("00"),
                ts.Minutes.ToString("00"),
                ts.Seconds.ToString("00"));
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            frmClientes ofrmClientes = new frmClientes();
            AbrirForm(ofrmClientes);
        }
    }
}
