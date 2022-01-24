using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula10_SimulacaoVenda_DataGridView_
{
    public partial class Form1 : Form
    {
        decimal total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           

            Object[] linha = {
                                 txtNomeProduto.Text,
                             Convert.ToDecimal(txtValor.Text)
                             };

            //ADICIONAR LINHAS(ROWS) AO DATAGRIDVIEW
            dgvProduto.Rows.Add(linha);

            //SOMANDO O VALOR DO PRODUTO AO TOTAL
            total = total + Convert.ToDecimal(txtValor.Text);
            txtTotal.Text = total.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

       
            //VERIFICA SE ALGUM REGISTRO ESTA SELECIONADO
            if (dgvProduto.CurrentRow.Selected)
            {

                //ACESSANDO O VALOR DE UMA COLUNA
                decimal valorSelecionado =
                    Convert.ToDecimal(
                        dgvProduto.CurrentRow.Cells[1].Value
                    );

                total = total - valorSelecionado;
                txtTotal.Text = total.ToString();

                //REMOVENDO LINHAS(ROWS) DO DATAGRIDVIEW
                dgvProduto.Rows.RemoveAt(
                    dgvProduto.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Selecione uma linha");
            }

           
                
        }
    }
}
