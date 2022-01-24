namespace Consumo
{
    partial class FrmConsumo
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDistância = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.btnCalcularConsumo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(28, 75);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distância";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(12, 117);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(86, 13);
            this.lblConsumo.TabIndex = 3;
            this.lblConsumo.Text = "Consumo (Km/L)";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(246, 78);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(35, 13);
            this.lblLitros.TabIndex = 4;
            this.lblLitros.Text = "Litros:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(95, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(315, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtDistância
            // 
            this.txtDistância.Location = new System.Drawing.Point(95, 75);
            this.txtDistância.Name = "txtDistância";
            this.txtDistância.Size = new System.Drawing.Size(145, 20);
            this.txtDistância.TabIndex = 6;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(287, 75);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(151, 20);
            this.txtLitros.TabIndex = 7;
            
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(95, 117);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(120, 20);
            this.txtConsumo.TabIndex = 8;
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Location = new System.Drawing.Point(62, 159);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(124, 46);
            this.btnLimparDados.TabIndex = 9;
            this.btnLimparDados.Text = "Limpar Dados";
            this.btnLimparDados.UseVisualStyleBackColor = true;
            // 
            // btnCalcularConsumo
            // 
            this.btnCalcularConsumo.Location = new System.Drawing.Point(249, 159);
            this.btnCalcularConsumo.Name = "btnCalcularConsumo";
            this.btnCalcularConsumo.Size = new System.Drawing.Size(121, 46);
            this.btnCalcularConsumo.TabIndex = 10;
            this.btnCalcularConsumo.Text = "Clacular Consumo";
            this.btnCalcularConsumo.UseVisualStyleBackColor = true;
            this.btnCalcularConsumo.Click += new System.EventHandler(this.btnCalcularConsumo_Click);
            // 
            // FrmConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 213);
            this.Controls.Add(this.btnCalcularConsumo);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtDistância);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmConsumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDistância;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.Button btnCalcularConsumo;
    }
}

