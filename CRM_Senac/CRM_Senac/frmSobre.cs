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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }
        //Criamos o evento Load (clicando 2x no cabeçalho do formulário)
        private void frmSobre_Load(object sender, EventArgs e)
        {
            //Atribuímos o texto aos labels
            lblTexto.Text = "This program is free software; you can redistribute it and/or ";
            lblTexto.Text += "modify it under the terms of the GNU General Public License as ";
            lblTexto.Text += "published by the Free Software Foundation; either version 2 of the ";
            lblTexto.Text += "License, or (at your option) any later version.";
            lblTexto.Text += "This program is distributed in the hope that it will be useful, ";
            lblTexto.Text += "but WITHOUT ANY WARRANTY; without even the implied warranty of ";
            lblTexto.Text += "MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  ";
            lblTexto.Text += "See the GNU General Public License for more details. ";
            lblTexto.Text += "You should have received a copy of the GNU General Public License ";
            lblTexto.Text += "along with this program; if not, write to the Free Software ";
            lblTexto.Text += "Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.";

            lblAplicacao.Text = "CRM Senac Versão 1.0\n";
            lblAplicacao.Text += "Serviço Nacional do Comércio\n";
            lblAplicacao.Text += "Curso Técnico de Informática - TI 47";
            
        }

        //Criamos o evento Click do botão cancelar (Clicando 2x sobre o componente)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Fechamos o formulário de clientes
            this.Close();
        }
    }
}
