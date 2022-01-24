namespace CRM_Senac
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblAplicacao = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.pctCRM = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCRM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAplicacao
            // 
            this.lblAplicacao.Location = new System.Drawing.Point(13, 9);
            this.lblAplicacao.Name = "lblAplicacao";
            this.lblAplicacao.Size = new System.Drawing.Size(213, 111);
            this.lblAplicacao.TabIndex = 0;
            this.lblAplicacao.Text = "label1";
            this.lblAplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTexto
            // 
            this.lblTexto.Location = new System.Drawing.Point(13, 123);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(244, 196);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "label2";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctCRM
            // 
            this.pctCRM.Image = global::CRM_Senac.Properties.Resources.CRM_software;
            this.pctCRM.Location = new System.Drawing.Point(232, 57);
            this.pctCRM.Name = "pctCRM";
            this.pctCRM.Size = new System.Drawing.Size(92, 63);
            this.pctCRM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctCRM.TabIndex = 24;
            this.pctCRM.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::CRM_Senac.Properties.Resources.Logo_Code_Black;
            this.pctLogo.Location = new System.Drawing.Point(232, 9);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(92, 42);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 23;
            this.pctLogo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::CRM_Senac.Properties.Resources.delete;
            this.btnCancelar.Location = new System.Drawing.Point(265, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 63);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 328);
            this.Controls.Add(this.pctCRM);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblAplicacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM Senac - Sobre";
            this.Load += new System.EventHandler(this.frmSobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCRM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAplicacao;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctCRM;
    }
}