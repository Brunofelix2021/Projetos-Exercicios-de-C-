namespace TrocarLugares
{
    partial class frmTrocarLugares
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtInfo1 = new System.Windows.Forms.TextBox();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Location = new System.Drawing.Point(12, 44);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(31, 13);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Info1";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(12, 68);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(30, 13);
            this.lblInfo2.TabIndex = 1;
            this.lblInfo2.Text = "info2";
            // 
            // txtInfo1
            // 
            this.txtInfo1.Location = new System.Drawing.Point(49, 42);
            this.txtInfo1.Name = "txtInfo1";
            this.txtInfo1.Size = new System.Drawing.Size(116, 20);
            this.txtInfo1.TabIndex = 2;
            // 
            // txtInfo2
            // 
            this.txtInfo2.Location = new System.Drawing.Point(49, 68);
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.Size = new System.Drawing.Size(116, 20);
            this.txtInfo2.TabIndex = 3;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Location = new System.Drawing.Point(188, 44);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(84, 44);
            this.btnTrocar.TabIndex = 4;
            this.btnTrocar.Text = "Trocar";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // frmTrocarLugares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.txtInfo2);
            this.Controls.Add(this.txtInfo1);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTrocarLugares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrocarLugares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtInfo1;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.Button btnTrocar;
    }
}

