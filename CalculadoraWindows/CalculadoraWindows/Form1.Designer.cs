namespace CalculadoraWindows
{
    partial class FrnCalculadora
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrnCalculadora));
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMr = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnInverterSinal = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btndecimal = new System.Windows.Forms.Button();
            this.btnMc = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblVisor = new System.Windows.Forms.Label();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMMinus
            // 
            this.btnMMinus.BackgroundImage = global::CalculadoraWindows.Properties.Resources.m_minus;
            this.btnMMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMMinus.Location = new System.Drawing.Point(2, 86);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(75, 44);
            this.btnMMinus.TabIndex = 0;
            this.btnMMinus.TabStop = false;
            this.btnMMinus.UseVisualStyleBackColor = true;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackgroundImage = global::CalculadoraWindows.Properties.Resources.m_plus;
            this.btnMPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMPlus.Location = new System.Drawing.Point(83, 86);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(75, 44);
            this.btnMPlus.TabIndex = 1;
            this.btnMPlus.TabStop = false;
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMr
            // 
            this.btnMr.BackgroundImage = global::CalculadoraWindows.Properties.Resources.mr;
            this.btnMr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMr.Location = new System.Drawing.Point(164, 86);
            this.btnMr.Name = "btnMr";
            this.btnMr.Size = new System.Drawing.Size(75, 44);
            this.btnMr.TabIndex = 2;
            this.btnMr.TabStop = false;
            this.btnMr.UseVisualStyleBackColor = true;
            this.btnMr.Click += new System.EventHandler(this.btnMr_Click);
            // 
            // btnC
            // 
            this.btnC.BackgroundImage = global::CalculadoraWindows.Properties.Resources.C;
            this.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnC.Location = new System.Drawing.Point(2, 136);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 44);
            this.btnC.TabIndex = 3;
            this.btnC.TabStop = false;
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnBS
            // 
            this.btnBS.BackgroundImage = global::CalculadoraWindows.Properties.Resources.BS;
            this.btnBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBS.Location = new System.Drawing.Point(83, 136);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(75, 44);
            this.btnBS.TabIndex = 4;
            this.btnBS.TabStop = false;
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackgroundImage = global::CalculadoraWindows.Properties.Resources.Dividir;
            this.btnDividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDividir.Location = new System.Drawing.Point(164, 136);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 44);
            this.btnDividir.TabIndex = 5;
            this.btnDividir.TabStop = false;
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = global::CalculadoraWindows.Properties.Resources._7;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn7.Location = new System.Drawing.Point(2, 186);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 44);
            this.btn7.TabIndex = 6;
            this.btn7.TabStop = false;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = global::CalculadoraWindows.Properties.Resources._8;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn8.Location = new System.Drawing.Point(83, 186);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 44);
            this.btn8.TabIndex = 7;
            this.btn8.TabStop = false;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnInverterSinal
            // 
            this.btnInverterSinal.BackgroundImage = global::CalculadoraWindows.Properties.Resources.Alterar_Sinal;
            this.btnInverterSinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInverterSinal.Location = new System.Drawing.Point(2, 339);
            this.btnInverterSinal.Name = "btnInverterSinal";
            this.btnInverterSinal.Size = new System.Drawing.Size(75, 63);
            this.btnInverterSinal.TabIndex = 8;
            this.btnInverterSinal.TabStop = false;
            this.btnInverterSinal.UseVisualStyleBackColor = true;
            this.btnInverterSinal.Click += new System.EventHandler(this.btnInverterSinal_Click);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = global::CalculadoraWindows.Properties.Resources._4;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.Location = new System.Drawing.Point(2, 236);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 44);
            this.btn4.TabIndex = 9;
            this.btn4.TabStop = false;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = global::CalculadoraWindows.Properties.Resources._1;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Location = new System.Drawing.Point(2, 289);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 44);
            this.btn1.TabIndex = 10;
            this.btn1.TabStop = false;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = global::CalculadoraWindows.Properties.Resources._5;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn5.Location = new System.Drawing.Point(83, 236);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 44);
            this.btn5.TabIndex = 11;
            this.btn5.TabStop = false;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = global::CalculadoraWindows.Properties.Resources._9;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn9.Location = new System.Drawing.Point(164, 186);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 44);
            this.btn9.TabIndex = 12;
            this.btn9.TabStop = false;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.BackgroundImage = global::CalculadoraWindows.Properties.Resources._0;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn0.Location = new System.Drawing.Point(83, 338);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 64);
            this.btn0.TabIndex = 13;
            this.btn0.TabStop = false;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = global::CalculadoraWindows.Properties.Resources._2;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2.Location = new System.Drawing.Point(83, 288);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 44);
            this.btn2.TabIndex = 14;
            this.btn2.TabStop = false;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = global::CalculadoraWindows.Properties.Resources._6;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn6.Location = new System.Drawing.Point(164, 236);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 44);
            this.btn6.TabIndex = 15;
            this.btn6.TabStop = false;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = global::CalculadoraWindows.Properties.Resources._3;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.Location = new System.Drawing.Point(164, 288);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 44);
            this.btn3.TabIndex = 16;
            this.btn3.TabStop = false;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btndecimal
            // 
            this.btndecimal.BackgroundImage = global::CalculadoraWindows.Properties.Resources.ponto;
            this.btndecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndecimal.Location = new System.Drawing.Point(167, 338);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(72, 64);
            this.btndecimal.TabIndex = 17;
            this.btndecimal.TabStop = false;
            this.btndecimal.UseVisualStyleBackColor = true;
            this.btndecimal.Click += new System.EventHandler(this.btndecimal_Click);
            // 
            // btnMc
            // 
            this.btnMc.BackgroundImage = global::CalculadoraWindows.Properties.Resources.mc;
            this.btnMc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMc.Location = new System.Drawing.Point(245, 86);
            this.btnMc.Name = "btnMc";
            this.btnMc.Size = new System.Drawing.Size(75, 44);
            this.btnMc.TabIndex = 18;
            this.btnMc.TabStop = false;
            this.btnMc.UseVisualStyleBackColor = true;
            this.btnMc.Click += new System.EventHandler(this.btnMc_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackgroundImage = global::CalculadoraWindows.Properties.Resources.Multiplicar;
            this.btnMultiplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMultiplicar.Location = new System.Drawing.Point(245, 133);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 44);
            this.btnMultiplicar.TabIndex = 19;
            this.btnMultiplicar.TabStop = false;
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackgroundImage = global::CalculadoraWindows.Properties.Resources.subtrair;
            this.btnSubtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSubtrair.Location = new System.Drawing.Point(245, 183);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 44);
            this.btnSubtrair.TabIndex = 20;
            this.btnSubtrair.TabStop = false;
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackgroundImage = global::CalculadoraWindows.Properties.Resources.Somar;
            this.btnSomar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSomar.Location = new System.Drawing.Point(245, 236);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 47);
            this.btnSomar.TabIndex = 21;
            this.btnSomar.TabStop = false;
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackgroundImage = global::CalculadoraWindows.Properties.Resources.igual;
            this.btnIgual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIgual.Location = new System.Drawing.Point(248, 288);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(72, 114);
            this.btnIgual.TabIndex = 22;
            this.btnIgual.TabStop = false;
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblVisor
            // 
            this.lblVisor.BackColor = System.Drawing.Color.White;
            this.lblVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(2, 0);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Size = new System.Drawing.Size(318, 83);
            this.lblVisor.TabIndex = 23;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblMemoria
            // 
            this.lblMemoria.BackColor = System.Drawing.Color.White;
            this.lblMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoria.Location = new System.Drawing.Point(2, 46);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(49, 35);
            this.lblMemoria.TabIndex = 24;
            this.lblMemoria.Text = "M";
            this.lblMemoria.Visible = false;
            // 
            // lblOperacao
            // 
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacao.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblOperacao.Location = new System.Drawing.Point(6, 0);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(314, 30);
            this.lblOperacao.TabIndex = 25;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrnCalculadora
            // 
            this.AcceptButton = this.btnIgual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnC;
            this.ClientSize = new System.Drawing.Size(324, 400);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.lblMemoria);
            this.Controls.Add(this.lblVisor);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnMc);
            this.Controls.Add(this.btndecimal);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnInverterSinal);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMr);
            this.Controls.Add(this.btnMPlus);
            this.Controls.Add(this.btnMMinus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrnCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Senac";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrnCalculadora_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMr;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnInverterSinal;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btndecimal;
        private System.Windows.Forms.Button btnMc;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}

