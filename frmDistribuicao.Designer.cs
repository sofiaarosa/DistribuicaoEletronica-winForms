namespace Distribuição_Eletrônica
{
    partial class frmDistribuicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistribuicao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDistribui = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnTeoria = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblKs = new System.Windows.Forms.Label();
            this.lblLs = new System.Windows.Forms.Label();
            this.lblLp = new System.Windows.Forms.Label();
            this.lblMs = new System.Windows.Forms.Label();
            this.lblMd = new System.Windows.Forms.Label();
            this.lblMp = new System.Windows.Forms.Label();
            this.lblNp = new System.Windows.Forms.Label();
            this.lblNd = new System.Windows.Forms.Label();
            this.lblNf = new System.Windows.Forms.Label();
            this.lblNs = new System.Windows.Forms.Label();
            this.lblOs = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblPs = new System.Windows.Forms.Label();
            this.lblPp = new System.Windows.Forms.Label();
            this.lblPd = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblQs = new System.Windows.Forms.Label();
            this.lblQp = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNumeroAtomico = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAtomico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número Atômico do Elemento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Máx: 118 prótons";
            // 
            // btnDistribui
            // 
            this.btnDistribui.BackColor = System.Drawing.Color.White;
            this.btnDistribui.Location = new System.Drawing.Point(216, 162);
            this.btnDistribui.Name = "btnDistribui";
            this.btnDistribui.Size = new System.Drawing.Size(60, 36);
            this.btnDistribui.TabIndex = 1;
            this.btnDistribui.Text = "&Distribuir";
            this.btnDistribui.UseVisualStyleBackColor = false;
            this.btnDistribui.Click += new System.EventHandler(this.btnDistribui_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("LEMON MILK", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 85);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distribuição Eletrônica";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(13, 301);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(83, 21);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnTeoria
            // 
            this.btnTeoria.Location = new System.Drawing.Point(102, 301);
            this.btnTeoria.Name = "btnTeoria";
            this.btnTeoria.Size = new System.Drawing.Size(83, 21);
            this.btnTeoria.TabIndex = 3;
            this.btnTeoria.Text = "Ver &Teoria";
            this.btnTeoria.UseVisualStyleBackColor = true;
            this.btnTeoria.Click += new System.EventHandler(this.btnTeoria_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(191, 301);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 21);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblKs
            // 
            this.lblKs.AutoSize = true;
            this.lblKs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKs.Location = new System.Drawing.Point(308, 133);
            this.lblKs.Name = "lblKs";
            this.lblKs.Size = new System.Drawing.Size(20, 15);
            this.lblKs.TabIndex = 6;
            this.lblKs.Text = "1s";
            this.lblKs.Visible = false;
            // 
            // lblLs
            // 
            this.lblLs.AutoSize = true;
            this.lblLs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLs.Location = new System.Drawing.Point(356, 133);
            this.lblLs.Name = "lblLs";
            this.lblLs.Size = new System.Drawing.Size(20, 15);
            this.lblLs.TabIndex = 7;
            this.lblLs.Text = "2s";
            this.lblLs.Visible = false;
            // 
            // lblLp
            // 
            this.lblLp.AutoSize = true;
            this.lblLp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLp.Location = new System.Drawing.Point(356, 209);
            this.lblLp.Name = "lblLp";
            this.lblLp.Size = new System.Drawing.Size(21, 15);
            this.lblLp.TabIndex = 8;
            this.lblLp.Text = "2p";
            this.lblLp.Visible = false;
            // 
            // lblMs
            // 
            this.lblMs.AutoSize = true;
            this.lblMs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMs.Location = new System.Drawing.Point(407, 133);
            this.lblMs.Name = "lblMs";
            this.lblMs.Size = new System.Drawing.Size(20, 15);
            this.lblMs.TabIndex = 9;
            this.lblMs.Text = "3s";
            this.lblMs.Visible = false;
            // 
            // lblMd
            // 
            this.lblMd.AutoSize = true;
            this.lblMd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMd.Location = new System.Drawing.Point(416, 260);
            this.lblMd.Name = "lblMd";
            this.lblMd.Size = new System.Drawing.Size(21, 15);
            this.lblMd.TabIndex = 10;
            this.lblMd.Text = "3d";
            this.lblMd.Visible = false;
            // 
            // lblMp
            // 
            this.lblMp.AutoSize = true;
            this.lblMp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMp.Location = new System.Drawing.Point(407, 209);
            this.lblMp.Name = "lblMp";
            this.lblMp.Size = new System.Drawing.Size(21, 15);
            this.lblMp.TabIndex = 11;
            this.lblMp.Text = "3p";
            this.lblMp.Visible = false;
            // 
            // lblNp
            // 
            this.lblNp.AutoSize = true;
            this.lblNp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNp.Location = new System.Drawing.Point(453, 133);
            this.lblNp.Name = "lblNp";
            this.lblNp.Size = new System.Drawing.Size(21, 15);
            this.lblNp.TabIndex = 12;
            this.lblNp.Text = "4p";
            this.lblNp.Visible = false;
            // 
            // lblNd
            // 
            this.lblNd.AutoSize = true;
            this.lblNd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNd.Location = new System.Drawing.Point(453, 209);
            this.lblNd.Name = "lblNd";
            this.lblNd.Size = new System.Drawing.Size(21, 15);
            this.lblNd.TabIndex = 13;
            this.lblNd.Text = "4d";
            this.lblNd.Visible = false;
            // 
            // lblNf
            // 
            this.lblNf.AutoSize = true;
            this.lblNf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNf.Location = new System.Drawing.Point(464, 260);
            this.lblNf.Name = "lblNf";
            this.lblNf.Size = new System.Drawing.Size(18, 15);
            this.lblNf.TabIndex = 14;
            this.lblNf.Text = "4f";
            this.lblNf.Visible = false;
            // 
            // lblNs
            // 
            this.lblNs.AutoSize = true;
            this.lblNs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNs.Location = new System.Drawing.Point(464, 92);
            this.lblNs.Name = "lblNs";
            this.lblNs.Size = new System.Drawing.Size(20, 15);
            this.lblNs.TabIndex = 15;
            this.lblNs.Text = "4s";
            this.lblNs.Visible = false;
            // 
            // lblOs
            // 
            this.lblOs.AutoSize = true;
            this.lblOs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOs.Location = new System.Drawing.Point(511, 92);
            this.lblOs.Name = "lblOs";
            this.lblOs.Size = new System.Drawing.Size(20, 15);
            this.lblOs.TabIndex = 16;
            this.lblOs.Text = "5s";
            this.lblOs.Visible = false;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOp.Location = new System.Drawing.Point(498, 133);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(21, 15);
            this.lblOp.TabIndex = 17;
            this.lblOp.Text = "5p";
            this.lblOp.Visible = false;
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOd.Location = new System.Drawing.Point(498, 209);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(21, 15);
            this.lblOd.TabIndex = 18;
            this.lblOd.Text = "5d";
            this.lblOd.Visible = false;
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOf.Location = new System.Drawing.Point(511, 260);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(18, 15);
            this.lblOf.TabIndex = 19;
            this.lblOf.Text = "5f";
            this.lblOf.Visible = false;
            // 
            // lblPs
            // 
            this.lblPs.AutoSize = true;
            this.lblPs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPs.Location = new System.Drawing.Point(545, 133);
            this.lblPs.Name = "lblPs";
            this.lblPs.Size = new System.Drawing.Size(20, 15);
            this.lblPs.TabIndex = 20;
            this.lblPs.Text = "6s";
            this.lblPs.Visible = false;
            // 
            // lblPp
            // 
            this.lblPp.AutoSize = true;
            this.lblPp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPp.Location = new System.Drawing.Point(545, 209);
            this.lblPp.Name = "lblPp";
            this.lblPp.Size = new System.Drawing.Size(21, 15);
            this.lblPp.TabIndex = 21;
            this.lblPp.Text = "6p";
            this.lblPp.Visible = false;
            // 
            // lblPd
            // 
            this.lblPd.AutoSize = true;
            this.lblPd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPd.Location = new System.Drawing.Point(551, 260);
            this.lblPd.Name = "lblPd";
            this.lblPd.Size = new System.Drawing.Size(21, 15);
            this.lblPd.TabIndex = 22;
            this.lblPd.Text = "6d";
            this.lblPd.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Location = new System.Drawing.Point(594, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(2, 15);
            this.label20.TabIndex = 23;
            this.label20.Visible = false;
            // 
            // lblQs
            // 
            this.lblQs.AutoSize = true;
            this.lblQs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQs.Location = new System.Drawing.Point(594, 133);
            this.lblQs.Name = "lblQs";
            this.lblQs.Size = new System.Drawing.Size(20, 15);
            this.lblQs.TabIndex = 24;
            this.lblQs.Text = "7s";
            this.lblQs.Visible = false;
            // 
            // lblQp
            // 
            this.lblQp.AutoSize = true;
            this.lblQp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQp.Location = new System.Drawing.Point(593, 209);
            this.lblQp.Name = "lblQp";
            this.lblQp.Size = new System.Drawing.Size(21, 15);
            this.lblQp.TabIndex = 25;
            this.lblQp.Text = "7p";
            this.lblQp.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(15, 226);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(261, 72);
            this.lblResult.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(83, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Distribuição escrita:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudNumeroAtomico
            // 
            this.nudNumeroAtomico.Location = new System.Drawing.Point(85, 169);
            this.nudNumeroAtomico.Maximum = new decimal(new int[] {
            118,
            0,
            0,
            0});
            this.nudNumeroAtomico.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumeroAtomico.Name = "nudNumeroAtomico";
            this.nudNumeroAtomico.Size = new System.Drawing.Size(120, 20);
            this.nudNumeroAtomico.TabIndex = 28;
            this.nudNumeroAtomico.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmDistribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 361);
            this.Controls.Add(this.nudNumeroAtomico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblQp);
            this.Controls.Add(this.lblQs);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblPd);
            this.Controls.Add(this.lblPp);
            this.Controls.Add(this.lblPs);
            this.Controls.Add(this.lblOf);
            this.Controls.Add(this.lblOd);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblOs);
            this.Controls.Add(this.lblNs);
            this.Controls.Add(this.lblNf);
            this.Controls.Add(this.lblNd);
            this.Controls.Add(this.lblNp);
            this.Controls.Add(this.lblMp);
            this.Controls.Add(this.lblMd);
            this.Controls.Add(this.lblMs);
            this.Controls.Add(this.lblLp);
            this.Controls.Add(this.lblLs);
            this.Controls.Add(this.lblKs);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTeoria);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDistribui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDistribuicao";
            this.Text = "Distribuição Eletrônica";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroAtomico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDistribui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnTeoria;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblKs;
        private System.Windows.Forms.Label lblLs;
        private System.Windows.Forms.Label lblLp;
        private System.Windows.Forms.Label lblMs;
        private System.Windows.Forms.Label lblMd;
        private System.Windows.Forms.Label lblMp;
        private System.Windows.Forms.Label lblNp;
        private System.Windows.Forms.Label lblNd;
        private System.Windows.Forms.Label lblNf;
        private System.Windows.Forms.Label lblNs;
        private System.Windows.Forms.Label lblOs;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblPs;
        private System.Windows.Forms.Label lblPp;
        private System.Windows.Forms.Label lblPd;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblQs;
        private System.Windows.Forms.Label lblQp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudNumeroAtomico;
    }
}

