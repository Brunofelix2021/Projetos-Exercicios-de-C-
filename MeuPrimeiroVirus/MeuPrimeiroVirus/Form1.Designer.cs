namespace MeuPrimeiroVirus
{
    partial class frmVirus
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
            this.btnVírus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVírus
            // 
            this.btnVírus.Location = new System.Drawing.Point(2, 1);
            this.btnVírus.Name = "btnVírus";
            this.btnVírus.Size = new System.Drawing.Size(134, 51);
            this.btnVírus.TabIndex = 0;
            this.btnVírus.TabStop = false;
            this.btnVírus.Text = "Fechar";
            this.btnVírus.UseVisualStyleBackColor = true;
            this.btnVírus.Click += new System.EventHandler(this.btnVírus_Click);
            this.btnVírus.MouseEnter += new System.EventHandler(this.btnVírus_MouseEnter);
            this.btnVírus.MouseHover += new System.EventHandler(this.btnVírus_MouseHover);
            // 
            // frmVirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 53);
            this.ControlBox = false;
            this.Controls.Add(this.btnVírus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmVirus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "##Vírus##";
            this.MouseHover += new System.EventHandler(this.frmVirus_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVírus;
    }
}

