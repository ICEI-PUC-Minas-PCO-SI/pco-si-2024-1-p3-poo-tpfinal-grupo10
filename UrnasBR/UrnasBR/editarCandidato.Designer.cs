﻿namespace UrnasBR
{
    partial class editarCandidato
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
            System.Windows.Forms.Button btnVoltar;
            this.selectCargo = new System.Windows.Forms.ComboBox();
            this.selectPartido = new System.Windows.Forms.ComboBox();
            this.btnEditarCandidato = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.naturCandidato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cpfCandidato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeCandidato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = System.Drawing.Color.Black;
            btnVoltar.ForeColor = System.Drawing.Color.White;
            btnVoltar.Location = new System.Drawing.Point(28, 409);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new System.Drawing.Size(75, 23);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // selectCargo
            // 
            this.selectCargo.FormattingEnabled = true;
            this.selectCargo.Items.AddRange(new object[] {
            "Presidente",
            "Governador",
            "Prefeito",
            "Deputado Estadual",
            "Deputado Federal",
            "Vereador"});
            this.selectCargo.Location = new System.Drawing.Point(303, 288);
            this.selectCargo.Name = "selectCargo";
            this.selectCargo.Size = new System.Drawing.Size(220, 23);
            this.selectCargo.TabIndex = 25;
            // 
            // selectPartido
            // 
            this.selectPartido.FormattingEnabled = true;
            this.selectPartido.Location = new System.Drawing.Point(303, 223);
            this.selectPartido.Name = "selectPartido";
            this.selectPartido.Size = new System.Drawing.Size(220, 23);
            this.selectPartido.TabIndex = 24;
            // 
            // btnEditarCandidato
            // 
            this.btnEditarCandidato.BackColor = System.Drawing.Color.Black;
            this.btnEditarCandidato.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCandidato.ForeColor = System.Drawing.Color.White;
            this.btnEditarCandidato.Location = new System.Drawing.Point(303, 331);
            this.btnEditarCandidato.Name = "btnEditarCandidato";
            this.btnEditarCandidato.Size = new System.Drawing.Size(220, 56);
            this.btnEditarCandidato.TabIndex = 22;
            this.btnEditarCandidato.Text = "Editar Candidato";
            this.btnEditarCandidato.UseVisualStyleBackColor = false;
            this.btnEditarCandidato.Click += new System.EventHandler(this.btnEditarCandidato_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cargo Político";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Partido";
            // 
            // naturCandidato
            // 
            this.naturCandidato.Location = new System.Drawing.Point(303, 166);
            this.naturCandidato.Name = "naturCandidato";
            this.naturCandidato.Size = new System.Drawing.Size(220, 23);
            this.naturCandidato.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Naturalidade";
            // 
            // cpfCandidato
            // 
            this.cpfCandidato.Location = new System.Drawing.Point(303, 106);
            this.cpfCandidato.Name = "cpfCandidato";
            this.cpfCandidato.PlaceholderText = "Somente numeros";
            this.cpfCandidato.Size = new System.Drawing.Size(220, 23);
            this.cpfCandidato.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "CPF";
            // 
            // nomeCandidato
            // 
            this.nomeCandidato.Location = new System.Drawing.Point(303, 47);
            this.nomeCandidato.Name = "nomeCandidato";
            this.nomeCandidato.Size = new System.Drawing.Size(220, 23);
            this.nomeCandidato.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // editarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectCargo);
            this.Controls.Add(this.selectPartido);
            this.Controls.Add(btnVoltar);
            this.Controls.Add(this.btnEditarCandidato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.naturCandidato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpfCandidato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeCandidato);
            this.Controls.Add(this.label1);
            this.Name = "editarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Candidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox selectCargo;
        private ComboBox selectPartido;
        private Button btnEditarCandidato;
        private Label label5;
        private Label label4;
        private TextBox naturCandidato;
        private Label label3;
        private TextBox cpfCandidato;
        private Label label2;
        private TextBox nomeCandidato;
        private Label label1;
    }
}