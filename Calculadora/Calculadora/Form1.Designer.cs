namespace Calculadora
{
    partial class frmCalculdora
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
            this.lblNúmero1 = new System.Windows.Forms.Label();
            this.lblNúmero2 = new System.Windows.Forms.Label();
            this.lblOperação = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtOperacao = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnSubitrair = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.nudNumero1 = new System.Windows.Forms.NumericUpDown();
            this.nudNumero2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNúmero1
            // 
            this.lblNúmero1.AutoSize = true;
            this.lblNúmero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmero1.Location = new System.Drawing.Point(22, 23);
            this.lblNúmero1.Name = "lblNúmero1";
            this.lblNúmero1.Size = new System.Drawing.Size(86, 20);
            this.lblNúmero1.TabIndex = 0;
            this.lblNúmero1.Text = "Número 1";
            // 
            // lblNúmero2
            // 
            this.lblNúmero2.AutoSize = true;
            this.lblNúmero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmero2.Location = new System.Drawing.Point(22, 58);
            this.lblNúmero2.Name = "lblNúmero2";
            this.lblNúmero2.Size = new System.Drawing.Size(86, 20);
            this.lblNúmero2.TabIndex = 1;
            this.lblNúmero2.Text = "Número 2";
            // 
            // lblOperação
            // 
            this.lblOperação.AutoSize = true;
            this.lblOperação.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperação.Location = new System.Drawing.Point(22, 90);
            this.lblOperação.Name = "lblOperação";
            this.lblOperação.Size = new System.Drawing.Size(87, 20);
            this.lblOperação.TabIndex = 2;
            this.lblOperação.Text = "Operação";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(22, 126);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(91, 20);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // txtOperacao
            // 
            this.txtOperacao.Location = new System.Drawing.Point(127, 92);
            this.txtOperacao.Name = "txtOperacao";
            this.txtOperacao.ReadOnly = true;
            this.txtOperacao.Size = new System.Drawing.Size(158, 20);
            this.txtOperacao.TabIndex = 4;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(127, 126);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(158, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(12, 188);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(51, 43);
            this.btnSomar.TabIndex = 6;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnSubitrair
            // 
            this.btnSubitrair.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubitrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubitrair.Location = new System.Drawing.Point(87, 188);
            this.btnSubitrair.Name = "btnSubitrair";
            this.btnSubitrair.Size = new System.Drawing.Size(51, 43);
            this.btnSubitrair.TabIndex = 7;
            this.btnSubitrair.Text = "-";
            this.btnSubitrair.UseVisualStyleBackColor = false;
            this.btnSubitrair.Click += new System.EventHandler(this.btnSubitrair_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(166, 188);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(51, 43);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(245, 188);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(51, 43);
            this.btnDividir.TabIndex = 9;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparDados.Location = new System.Drawing.Point(12, 283);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(112, 49);
            this.btnLimparDados.TabIndex = 10;
            this.btnLimparDados.Text = "Limpar Dados";
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(183, 283);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(113, 49);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // nudNumero1
            // 
            this.nudNumero1.DecimalPlaces = 5;
            this.nudNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero1.Location = new System.Drawing.Point(127, 22);
            this.nudNumero1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudNumero1.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudNumero1.Name = "nudNumero1";
            this.nudNumero1.Size = new System.Drawing.Size(158, 26);
            this.nudNumero1.TabIndex = 12;
            // 
            // nudNumero2
            // 
            this.nudNumero2.DecimalPlaces = 5;
            this.nudNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumero2.Location = new System.Drawing.Point(127, 58);
            this.nudNumero2.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudNumero2.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.nudNumero2.Name = "nudNumero2";
            this.nudNumero2.Size = new System.Drawing.Size(158, 26);
            this.nudNumero2.TabIndex = 13;
            // 
            // frmCalculdora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 344);
            this.Controls.Add(this.nudNumero2);
            this.Controls.Add(this.nudNumero1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubitrair);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtOperacao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOperação);
            this.Controls.Add(this.lblNúmero2);
            this.Controls.Add(this.lblNúmero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCalculdora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumero2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNúmero1;
        private System.Windows.Forms.Label lblNúmero2;
        private System.Windows.Forms.Label lblOperação;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtOperacao;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnSubitrair;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown nudNumero1;
        private System.Windows.Forms.NumericUpDown nudNumero2;
    }
}

