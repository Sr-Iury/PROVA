namespace Prova
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.luc = new System.Windows.Forms.TextBox();
            this.ip1 = new System.Windows.Forms.TextBox();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.ip3 = new System.Windows.Forms.TextBox();
            this.v = new System.Windows.Forms.TextBox();
            this.AB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vdd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LI = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UNIDADE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR DE VENDA: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "LUCRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ICMS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CONFINS:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "PIS: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "DESCRIÇÃO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(350, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CADASTRO DE PRODUTO";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(194, 85);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(100, 20);
            this.A.TabIndex = 9;
            // 
            // luc
            // 
            this.luc.Location = new System.Drawing.Point(182, 283);
            this.luc.Name = "luc";
            this.luc.Size = new System.Drawing.Size(100, 20);
            this.luc.TabIndex = 10;
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(178, 227);
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(100, 20);
            this.ip1.TabIndex = 11;
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(520, 251);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(100, 20);
            this.ip2.TabIndex = 12;
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(487, 174);
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(100, 20);
            this.ip3.TabIndex = 13;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(182, 171);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(47, 20);
            this.v.TabIndex = 14;
            this.v.TextChanged += new System.EventHandler(this.v_TextChanged);
            // 
            // AB
            // 
            this.AB.Location = new System.Drawing.Point(214, 127);
            this.AB.Name = "AB";
            this.AB.Size = new System.Drawing.Size(100, 20);
            this.AB.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(136, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "VALOR: ";
            // 
            // vdd
            // 
            this.vdd.AutoSize = true;
            this.vdd.Location = new System.Drawing.Point(241, 337);
            this.vdd.Name = "vdd";
            this.vdd.Size = new System.Drawing.Size(0, 13);
            this.vdd.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LI
            // 
            this.LI.FormattingEnabled = true;
            this.LI.Items.AddRange(new object[] {
            "UN",
            "LT",
            "KL"});
            this.LI.Location = new System.Drawing.Point(520, 85);
            this.LI.Name = "LI";
            this.LI.Size = new System.Drawing.Size(140, 21);
            this.LI.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AB);
            this.Controls.Add(this.v);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.luc);
            this.Controls.Add(this.A);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox luc;
        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.TextBox ip2;
        private System.Windows.Forms.TextBox ip3;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.TextBox AB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label vdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox LI;
    }
}

