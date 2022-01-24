namespace ContadorX2
{
    partial class Form1
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
            this.nudinicio = new System.Windows.Forms.NumericUpDown();
            this.nudTermino = new System.Windows.Forms.NumericUpDown();
            this.NudMultiplo = new System.Windows.Forms.NumericUpDown();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtContar = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblTermino = new System.Windows.Forms.Label();
            this.lblMultiploDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudinicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTermino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMultiplo)).BeginInit();
            this.SuspendLayout();
            // 
            // nudinicio
            // 
            this.nudinicio.Location = new System.Drawing.Point(82, 16);
            this.nudinicio.Name = "nudinicio";
            this.nudinicio.Size = new System.Drawing.Size(62, 20);
            this.nudinicio.TabIndex = 0;
            // 
            // nudTermino
            // 
            this.nudTermino.Location = new System.Drawing.Point(224, 14);
            this.nudTermino.Name = "nudTermino";
            this.nudTermino.Size = new System.Drawing.Size(61, 20);
            this.nudTermino.TabIndex = 1;
            // 
            // NudMultiplo
            // 
            this.NudMultiplo.Location = new System.Drawing.Point(376, 14);
            this.NudMultiplo.Name = "NudMultiplo";
            this.NudMultiplo.Size = new System.Drawing.Size(81, 20);
            this.NudMultiplo.TabIndex = 2;
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(11, 155);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(445, 55);
            this.btnContar.TabIndex = 3;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // txtContar
            // 
            this.txtContar.Location = new System.Drawing.Point(12, 58);
            this.txtContar.Multiline = true;
            this.txtContar.Name = "txtContar";
            this.txtContar.Size = new System.Drawing.Size(445, 91);
            this.txtContar.TabIndex = 4;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(22, 18);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 5;
            this.lblInicio.Text = "Início";
            // 
            // lblTermino
            // 
            this.lblTermino.AutoSize = true;
            this.lblTermino.Location = new System.Drawing.Point(162, 18);
            this.lblTermino.Name = "lblTermino";
            this.lblTermino.Size = new System.Drawing.Size(45, 13);
            this.lblTermino.TabIndex = 6;
            this.lblTermino.Text = "Término";
            // 
            // lblMultiploDe
            // 
            this.lblMultiploDe.AutoSize = true;
            this.lblMultiploDe.Location = new System.Drawing.Point(303, 18);
            this.lblMultiploDe.Name = "lblMultiploDe";
            this.lblMultiploDe.Size = new System.Drawing.Size(61, 13);
            this.lblMultiploDe.TabIndex = 7;
            this.lblMultiploDe.Text = "Múltiplo de:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 222);
            this.Controls.Add(this.lblMultiploDe);
            this.Controls.Add(this.lblTermino);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.txtContar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.NudMultiplo);
            this.Controls.Add(this.nudTermino);
            this.Controls.Add(this.nudinicio);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudinicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTermino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMultiplo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudinicio;
        private System.Windows.Forms.NumericUpDown nudTermino;
        private System.Windows.Forms.NumericUpDown NudMultiplo;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtContar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblTermino;
        private System.Windows.Forms.Label lblMultiploDe;
    }
}

