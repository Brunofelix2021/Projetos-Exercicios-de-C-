namespace EstruturasRepeticao
{
    partial class frmRepeticao
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
            this.btnEnquantoFaca = new System.Windows.Forms.Button();
            this.btnFacaEnquanto = new System.Windows.Forms.Button();
            this.btnParaAteFaca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnquantoFaca
            // 
            this.btnEnquantoFaca.Location = new System.Drawing.Point(12, 12);
            this.btnEnquantoFaca.Name = "btnEnquantoFaca";
            this.btnEnquantoFaca.Size = new System.Drawing.Size(94, 38);
            this.btnEnquantoFaca.TabIndex = 0;
            this.btnEnquantoFaca.Text = "While";
            this.btnEnquantoFaca.UseVisualStyleBackColor = true;
            this.btnEnquantoFaca.Click += new System.EventHandler(this.btnEnquantoFaca_Click);
            // 
            // btnFacaEnquanto
            // 
            this.btnFacaEnquanto.Location = new System.Drawing.Point(122, 12);
            this.btnFacaEnquanto.Name = "btnFacaEnquanto";
            this.btnFacaEnquanto.Size = new System.Drawing.Size(92, 38);
            this.btnFacaEnquanto.TabIndex = 1;
            this.btnFacaEnquanto.Text = "Do/While";
            this.btnFacaEnquanto.UseVisualStyleBackColor = true;
            this.btnFacaEnquanto.Click += new System.EventHandler(this.btnFacaEnquanto_Click);
            // 
            // btnParaAteFaca
            // 
            this.btnParaAteFaca.Location = new System.Drawing.Point(231, 12);
            this.btnParaAteFaca.Name = "btnParaAteFaca";
            this.btnParaAteFaca.Size = new System.Drawing.Size(101, 38);
            this.btnParaAteFaca.TabIndex = 2;
            this.btnParaAteFaca.Text = "For";
            this.btnParaAteFaca.UseVisualStyleBackColor = true;
            this.btnParaAteFaca.Click += new System.EventHandler(this.btnParaAteFaca_Click);
            // 
            // frmRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 63);
            this.Controls.Add(this.btnParaAteFaca);
            this.Controls.Add(this.btnFacaEnquanto);
            this.Controls.Add(this.btnEnquantoFaca);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estruturas de repetição";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnquantoFaca;
        private System.Windows.Forms.Button btnFacaEnquanto;
        private System.Windows.Forms.Button btnParaAteFaca;
    }
}

