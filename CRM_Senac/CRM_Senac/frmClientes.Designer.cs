namespace CRM_Senac
{
    partial class frmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstTelefone = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(45, 11);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 1;
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(45, 37);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(317, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(63, 63);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(221, 20);
            this.txtEndereco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(315, 63);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(47, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(81, 89);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(281, 20);
            this.txtComplemento.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(44, 115);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(223, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bairro";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(308, 115);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(54, 20);
            this.txtCEP.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CEP";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(44, 141);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(235, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(331, 141);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(31, 20);
            this.txtEstado.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estado";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(59, 167);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Telefone";
            // 
            // lstTelefone
            // 
            this.lstTelefone.FormattingEnabled = true;
            this.lstTelefone.Location = new System.Drawing.Point(7, 193);
            this.lstTelefone.Name = "lstTelefone";
            this.lstTelefone.Size = new System.Drawing.Size(152, 160);
            this.lstTelefone.TabIndex = 20;
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::CRM_Senac.Properties.Resources.Minus_16;
            this.btnRemover.Location = new System.Drawing.Point(165, 196);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(25, 25);
            this.btnRemover.TabIndex = 25;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::CRM_Senac.Properties.Resources.add_16;
            this.btnAdicionar.Location = new System.Drawing.Point(165, 163);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(25, 25);
            this.btnAdicionar.TabIndex = 24;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::CRM_Senac.Properties.Resources.eraser;
            this.btnLimpar.Location = new System.Drawing.Point(246, 290);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(57, 63);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::CRM_Senac.Properties.Resources.FloppyDisks;
            this.btnGravar.Location = new System.Drawing.Point(305, 290);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(57, 63);
            this.btnGravar.TabIndex = 22;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CRM_Senac.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(187, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 63);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 361);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lstTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM Senac - Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstTelefone;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
    }
}