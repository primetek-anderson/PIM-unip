﻿namespace View.cadastros
{
    partial class FrmCarros
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblRenavam = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblAdicionais = new System.Windows.Forms.Label();
            this.cbCombustivel = new System.Windows.Forms.CheckedListBox();
            this.cbAlugado = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnSalvarCarro = new System.Windows.Forms.Button();
            this.btnExcluirCarro = new System.Windows.Forms.Button();
            this.chModeloVeiculo = new System.Windows.Forms.CheckedListBox();
            this.dbCarros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dbCarros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(152, 37);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(34, 13);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(154, 71);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(154, 101);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano";
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Location = new System.Drawing.Point(585, 64);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(53, 13);
            this.lblRenavam.TabIndex = 5;
            this.lblRenavam.Text = "Renavam";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(583, 30);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(23, 13);
            this.lblCor.TabIndex = 4;
            this.lblCor.Text = "Cor";
            // 
            // lblAdicionais
            // 
            this.lblAdicionais.AutoSize = true;
            this.lblAdicionais.Location = new System.Drawing.Point(585, 94);
            this.lblAdicionais.Name = "lblAdicionais";
            this.lblAdicionais.Size = new System.Drawing.Size(55, 13);
            this.lblAdicionais.TabIndex = 6;
            this.lblAdicionais.Text = "Adicionais";
            // 
            // cbCombustivel
            // 
            this.cbCombustivel.BackColor = System.Drawing.SystemColors.Control;
            this.cbCombustivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbCombustivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCombustivel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbCombustivel.FormattingEnabled = true;
            this.cbCombustivel.Items.AddRange(new object[] {
            "Álcool",
            "Diesel",
            "Flex",
            "Gasolina"});
            this.cbCombustivel.Location = new System.Drawing.Point(209, 131);
            this.cbCombustivel.Name = "cbCombustivel";
            this.cbCombustivel.Size = new System.Drawing.Size(82, 64);
            this.cbCombustivel.TabIndex = 11;
            // 
            // cbAlugado
            // 
            this.cbAlugado.AutoSize = true;
            this.cbAlugado.Enabled = false;
            this.cbAlugado.Location = new System.Drawing.Point(585, 124);
            this.cbAlugado.Name = "cbAlugado";
            this.cbAlugado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbAlugado.Size = new System.Drawing.Size(65, 17);
            this.cbAlugado.TabIndex = 12;
            this.cbAlugado.Text = "Alugado";
            this.cbAlugado.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(209, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(653, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(653, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(653, 87);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            // 
            // btnSalvarCarro
            // 
            this.btnSalvarCarro.FlatAppearance.BorderSize = 0;
            this.btnSalvarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarCarro.Location = new System.Drawing.Point(597, 157);
            this.btnSalvarCarro.Name = "btnSalvarCarro";
            this.btnSalvarCarro.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarCarro.TabIndex = 19;
            this.btnSalvarCarro.Text = "Salvar";
            this.btnSalvarCarro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCarro
            // 
            this.btnExcluirCarro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCarro.Location = new System.Drawing.Point(701, 157);
            this.btnExcluirCarro.Name = "btnExcluirCarro";
            this.btnExcluirCarro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirCarro.TabIndex = 20;
            this.btnExcluirCarro.Text = "Excluir";
            this.btnExcluirCarro.UseVisualStyleBackColor = true;
            // 
            // chModeloVeiculo
            // 
            this.chModeloVeiculo.BackColor = System.Drawing.SystemColors.Control;
            this.chModeloVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chModeloVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chModeloVeiculo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.chModeloVeiculo.FormattingEnabled = true;
            this.chModeloVeiculo.Items.AddRange(new object[] {
            "Passeio",
            "Caminhão",
            "Van"});
            this.chModeloVeiculo.Location = new System.Drawing.Point(323, 131);
            this.chModeloVeiculo.Name = "chModeloVeiculo";
            this.chModeloVeiculo.Size = new System.Drawing.Size(95, 48);
            this.chModeloVeiculo.TabIndex = 21;
            // 
            // dbCarros
            // 
            this.dbCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbCarros.Location = new System.Drawing.Point(65, 246);
            this.dbCarros.Name = "dbCarros";
            this.dbCarros.Size = new System.Drawing.Size(957, 382);
            this.dbCarros.TabIndex = 22;
            // 
            // FrmCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 672);
            this.Controls.Add(this.dbCarros);
            this.Controls.Add(this.chModeloVeiculo);
            this.Controls.Add(this.btnExcluirCarro);
            this.Controls.Add(this.btnSalvarCarro);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbAlugado);
            this.Controls.Add(this.cbCombustivel);
            this.Controls.Add(this.lblAdicionais);
            this.Controls.Add(this.lblRenavam);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblPlaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCarros";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCarros";
            ((System.ComponentModel.ISupportInitialize)(this.dbCarros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblRenavam;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.Label lblAdicionais;
        private System.Windows.Forms.CheckedListBox cbCombustivel;
        private System.Windows.Forms.CheckBox cbAlugado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnSalvarCarro;
        private System.Windows.Forms.Button btnExcluirCarro;
        private System.Windows.Forms.CheckedListBox chModeloVeiculo;
        private System.Windows.Forms.DataGridView dbCarros;
    }
}