﻿namespace SimuladorPistaDeCorrida.WinApp
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pbxPistaCorrida = new System.Windows.Forms.PictureBox();
            this.pbxCao1 = new System.Windows.Forms.PictureBox();
            this.pbxCao2 = new System.Windows.Forms.PictureBox();
            this.pbxCao3 = new System.Windows.Forms.PictureBox();
            this.pbxCao4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtJoao = new System.Windows.Forms.RadioButton();
            this.rbtBeto = new System.Windows.Forms.RadioButton();
            this.rbtAlfredo = new System.Windows.Forms.RadioButton();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblApostas = new System.Windows.Forms.Label();
            this.txtJoão = new System.Windows.Forms.TextBox();
            this.txtBeto = new System.Windows.Forms.TextBox();
            this.txtAlfredo = new System.Windows.Forms.TextBox();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.lblNomeApostador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericValor = new System.Windows.Forms.NumericUpDown();
            this.numericCao = new System.Windows.Forms.NumericUpDown();
            this.lblJoao = new System.Windows.Forms.Label();
            this.lblBeto = new System.Windows.Forms.Label();
            this.lblAlfredo = new System.Windows.Forms.Label();
            this.lblBalcaoApostas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPistaCorrida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCao)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPistaCorrida
            // 
            this.pbxPistaCorrida.Image = ((System.Drawing.Image)(resources.GetObject("pbxPistaCorrida.Image")));
            this.pbxPistaCorrida.InitialImage = null;
            this.pbxPistaCorrida.Location = new System.Drawing.Point(26, 12);
            this.pbxPistaCorrida.Name = "pbxPistaCorrida";
            this.pbxPistaCorrida.Size = new System.Drawing.Size(636, 209);
            this.pbxPistaCorrida.TabIndex = 0;
            this.pbxPistaCorrida.TabStop = false;
            // 
            // pbxCao1
            // 
            this.pbxCao1.AccessibleName = "Cachorro 1";
            this.pbxCao1.Image = ((System.Drawing.Image)(resources.GetObject("pbxCao1.Image")));
            this.pbxCao1.Location = new System.Drawing.Point(62, 23);
            this.pbxCao1.Name = "pbxCao1";
            this.pbxCao1.Size = new System.Drawing.Size(79, 22);
            this.pbxCao1.TabIndex = 1;
            this.pbxCao1.TabStop = false;
            // 
            // pbxCao2
            // 
            this.pbxCao2.AccessibleName = "Cachorro 2";
            this.pbxCao2.Image = ((System.Drawing.Image)(resources.GetObject("pbxCao2.Image")));
            this.pbxCao2.Location = new System.Drawing.Point(62, 71);
            this.pbxCao2.Name = "pbxCao2";
            this.pbxCao2.Size = new System.Drawing.Size(79, 22);
            this.pbxCao2.TabIndex = 2;
            this.pbxCao2.TabStop = false;
            // 
            // pbxCao3
            // 
            this.pbxCao3.AccessibleName = "Cachorro 3";
            this.pbxCao3.Image = ((System.Drawing.Image)(resources.GetObject("pbxCao3.Image")));
            this.pbxCao3.Location = new System.Drawing.Point(62, 128);
            this.pbxCao3.Name = "pbxCao3";
            this.pbxCao3.Size = new System.Drawing.Size(79, 22);
            this.pbxCao3.TabIndex = 3;
            this.pbxCao3.TabStop = false;
            // 
            // pbxCao4
            // 
            this.pbxCao4.AccessibleName = "Cachorro 4";
            this.pbxCao4.Image = ((System.Drawing.Image)(resources.GetObject("pbxCao4.Image")));
            this.pbxCao4.Location = new System.Drawing.Point(62, 179);
            this.pbxCao4.Name = "pbxCao4";
            this.pbxCao4.Size = new System.Drawing.Size(79, 22);
            this.pbxCao4.TabIndex = 4;
            this.pbxCao4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aposta Mínima: 5 Reais ";
            // 
            // rbtJoao
            // 
            this.rbtJoao.AutoSize = true;
            this.rbtJoao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtJoao.Location = new System.Drawing.Point(26, 320);
            this.rbtJoao.Name = "rbtJoao";
            this.rbtJoao.Size = new System.Drawing.Size(14, 13);
            this.rbtJoao.TabIndex = 7;
            this.rbtJoao.TabStop = true;
            this.rbtJoao.UseVisualStyleBackColor = true;
            this.rbtJoao.CheckedChanged += new System.EventHandler(this.rbtJoao_CheckedChanged);
            // 
            // rbtBeto
            // 
            this.rbtBeto.AutoSize = true;
            this.rbtBeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBeto.Location = new System.Drawing.Point(26, 355);
            this.rbtBeto.Name = "rbtBeto";
            this.rbtBeto.Size = new System.Drawing.Size(14, 13);
            this.rbtBeto.TabIndex = 8;
            this.rbtBeto.TabStop = true;
            this.rbtBeto.UseVisualStyleBackColor = true;
            this.rbtBeto.CheckedChanged += new System.EventHandler(this.rbtBeto_CheckedChanged);
            // 
            // rbtAlfredo
            // 
            this.rbtAlfredo.AutoSize = true;
            this.rbtAlfredo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAlfredo.Location = new System.Drawing.Point(26, 388);
            this.rbtAlfredo.Name = "rbtAlfredo";
            this.rbtAlfredo.Size = new System.Drawing.Size(14, 13);
            this.rbtAlfredo.TabIndex = 9;
            this.rbtAlfredo.TabStop = true;
            this.rbtAlfredo.UseVisualStyleBackColor = true;
            this.rbtAlfredo.CheckedChanged += new System.EventHandler(this.rbtAlfredo_CheckedChanged);
            // 
            // btnApostar
            // 
            this.btnApostar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApostar.Location = new System.Drawing.Point(26, 462);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(102, 37);
            this.btnApostar.TabIndex = 10;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblApostas
            // 
            this.lblApostas.AutoSize = true;
            this.lblApostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApostas.Location = new System.Drawing.Point(345, 280);
            this.lblApostas.Name = "lblApostas";
            this.lblApostas.Size = new System.Drawing.Size(65, 16);
            this.lblApostas.TabIndex = 11;
            this.lblApostas.Text = "Apostas";
            // 
            // txtJoão
            // 
            this.txtJoão.Enabled = false;
            this.txtJoão.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJoão.Location = new System.Drawing.Point(348, 320);
            this.txtJoão.Name = "txtJoão";
            this.txtJoão.Size = new System.Drawing.Size(270, 22);
            this.txtJoão.TabIndex = 12;
            // 
            // txtBeto
            // 
            this.txtBeto.Enabled = false;
            this.txtBeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeto.Location = new System.Drawing.Point(348, 355);
            this.txtBeto.Name = "txtBeto";
            this.txtBeto.Size = new System.Drawing.Size(270, 22);
            this.txtBeto.TabIndex = 13;
            // 
            // txtAlfredo
            // 
            this.txtAlfredo.Enabled = false;
            this.txtAlfredo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlfredo.Location = new System.Drawing.Point(348, 389);
            this.txtAlfredo.Name = "txtAlfredo";
            this.txtAlfredo.Size = new System.Drawing.Size(270, 22);
            this.txtAlfredo.TabIndex = 14;
            // 
            // btnCorrer
            // 
            this.btnCorrer.Enabled = false;
            this.btnCorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrer.Location = new System.Drawing.Point(516, 462);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(102, 37);
            this.btnCorrer.TabIndex = 15;
            this.btnCorrer.Text = "Corram!";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // lblNomeApostador
            // 
            this.lblNomeApostador.AutoSize = true;
            this.lblNomeApostador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeApostador.Location = new System.Drawing.Point(23, 438);
            this.lblNomeApostador.Name = "lblNomeApostador";
            this.lblNomeApostador.Size = new System.Drawing.Size(108, 16);
            this.lblNomeApostador.TabIndex = 16;
            this.lblNomeApostador.Text = "NomeApostador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "reais no cão número";
            // 
            // numericValor
            // 
            this.numericValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericValor.Location = new System.Drawing.Point(198, 472);
            this.numericValor.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericValor.Name = "numericValor";
            this.numericValor.Size = new System.Drawing.Size(51, 22);
            this.numericValor.TabIndex = 18;
            this.numericValor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericCao
            // 
            this.numericCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCao.Location = new System.Drawing.Point(391, 472);
            this.numericCao.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericCao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericCao.Name = "numericCao";
            this.numericCao.Size = new System.Drawing.Size(51, 22);
            this.numericCao.TabIndex = 19;
            this.numericCao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblJoao
            // 
            this.lblJoao.AutoSize = true;
            this.lblJoao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoao.Location = new System.Drawing.Point(46, 320);
            this.lblJoao.Name = "lblJoao";
            this.lblJoao.Size = new System.Drawing.Size(42, 16);
            this.lblJoao.TabIndex = 20;
            this.lblJoao.Text = "João ";
            // 
            // lblBeto
            // 
            this.lblBeto.AutoSize = true;
            this.lblBeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeto.Location = new System.Drawing.Point(46, 353);
            this.lblBeto.Name = "lblBeto";
            this.lblBeto.Size = new System.Drawing.Size(36, 16);
            this.lblBeto.TabIndex = 21;
            this.lblBeto.Text = "Beto";
            // 
            // lblAlfredo
            // 
            this.lblAlfredo.AutoSize = true;
            this.lblAlfredo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlfredo.Location = new System.Drawing.Point(46, 385);
            this.lblAlfredo.Name = "lblAlfredo";
            this.lblAlfredo.Size = new System.Drawing.Size(51, 16);
            this.lblAlfredo.TabIndex = 22;
            this.lblAlfredo.Text = "Alfredo";
            // 
            // lblBalcaoApostas
            // 
            this.lblBalcaoApostas.AutoSize = true;
            this.lblBalcaoApostas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalcaoApostas.Location = new System.Drawing.Point(42, 243);
            this.lblBalcaoApostas.Name = "lblBalcaoApostas";
            this.lblBalcaoApostas.Size = new System.Drawing.Size(140, 16);
            this.lblBalcaoApostas.TabIndex = 5;
            this.lblBalcaoApostas.Text = "Balcão de Apostas";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 511);
            this.Controls.Add(this.lblAlfredo);
            this.Controls.Add(this.lblBeto);
            this.Controls.Add(this.lblJoao);
            this.Controls.Add(this.numericCao);
            this.Controls.Add(this.numericValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeApostador);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.txtAlfredo);
            this.Controls.Add(this.txtBeto);
            this.Controls.Add(this.txtJoão);
            this.Controls.Add(this.lblApostas);
            this.Controls.Add(this.btnApostar);
            this.Controls.Add(this.rbtAlfredo);
            this.Controls.Add(this.rbtBeto);
            this.Controls.Add(this.rbtJoao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBalcaoApostas);
            this.Controls.Add(this.pbxCao4);
            this.Controls.Add(this.pbxCao3);
            this.Controls.Add(this.pbxCao2);
            this.Controls.Add(this.pbxCao1);
            this.Controls.Add(this.pbxPistaCorrida);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 550);
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulação Pista de Corrida";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPistaCorrida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCao4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPistaCorrida;
        private System.Windows.Forms.PictureBox pbxCao1;
        private System.Windows.Forms.PictureBox pbxCao2;
        private System.Windows.Forms.PictureBox pbxCao3;
        private System.Windows.Forms.PictureBox pbxCao4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtJoao;
        private System.Windows.Forms.RadioButton rbtBeto;
        private System.Windows.Forms.RadioButton rbtAlfredo;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.Label lblApostas;
        private System.Windows.Forms.TextBox txtJoão;
        private System.Windows.Forms.TextBox txtBeto;
        private System.Windows.Forms.TextBox txtAlfredo;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Label lblNomeApostador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericValor;
        private System.Windows.Forms.NumericUpDown numericCao;
        private System.Windows.Forms.Label lblJoao;
        private System.Windows.Forms.Label lblBeto;
        private System.Windows.Forms.Label lblAlfredo;
        private System.Windows.Forms.Label lblBalcaoApostas;
        private System.Windows.Forms.Timer timer1;
    }
}

