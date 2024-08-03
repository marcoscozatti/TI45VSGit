namespace TI45VSGit
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
            this.txValor1 = new System.Windows.Forms.TextBox();
            this.txValor2 = new System.Windows.Forms.TextBox();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lbValor2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txValor1
            // 
            this.txValor1.Location = new System.Drawing.Point(124, 45);
            this.txValor1.Name = "txValor1";
            this.txValor1.Size = new System.Drawing.Size(244, 20);
            this.txValor1.TabIndex = 0;
            // 
            // txValor2
            // 
            this.txValor2.Location = new System.Drawing.Point(124, 82);
            this.txValor2.Name = "txValor2";
            this.txValor2.Size = new System.Drawing.Size(244, 20);
            this.txValor2.TabIndex = 1;
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(47, 45);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(40, 13);
            this.lblValor1.TabIndex = 2;
            this.lblValor1.Text = "Valor 1";
            // 
            // lbValor2
            // 
            this.lbValor2.AutoSize = true;
            this.lbValor2.Location = new System.Drawing.Point(47, 82);
            this.lbValor2.Name = "lbValor2";
            this.lbValor2.Size = new System.Drawing.Size(40, 13);
            this.lbValor2.TabIndex = 3;
            this.lbValor2.Text = "Valor 2";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(47, 118);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(121, 117);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(16, 13);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "...";
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(50, 151);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(131, 151);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 23);
            this.btnSubtracao.TabIndex = 7;
            this.btnSubtracao.Text = "Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(212, 151);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplicacao.TabIndex = 8;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(293, 151);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 23);
            this.btnDivisao.TabIndex = 9;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 226);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.txValor2);
            this.Controls.Add(this.txValor1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txValor1;
        private System.Windows.Forms.TextBox txValor2;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lbValor2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
    }
}

