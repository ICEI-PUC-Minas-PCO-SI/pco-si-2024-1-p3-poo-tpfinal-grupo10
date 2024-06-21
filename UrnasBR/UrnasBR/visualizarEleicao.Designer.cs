namespace UrnasBR.Classes
{
    partial class visualizarEleicao
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
            this.eleito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Partido = new System.Windows.Forms.Label();
            this.partidoEleito = new System.Windows.Forms.TextBox();
            this.votosEleito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.votosNulos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.votosBrancos = new System.Windows.Forms.TextBox();
            this.viewCandidatos = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eleito
            // 
            this.eleito.Enabled = false;
            this.eleito.Location = new System.Drawing.Point(149, 63);
            this.eleito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eleito.Name = "eleito";
            this.eleito.Size = new System.Drawing.Size(181, 27);
            this.eleito.TabIndex = 0;
            this.eleito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Candidato Eleito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Votos Recebidos";
            // 
            // Partido
            // 
            this.Partido.AutoSize = true;
            this.Partido.Location = new System.Drawing.Point(434, 39);
            this.Partido.Name = "Partido";
            this.Partido.Size = new System.Drawing.Size(56, 20);
            this.Partido.TabIndex = 5;
            this.Partido.Text = "Partido";
            // 
            // partidoEleito
            // 
            this.partidoEleito.Enabled = false;
            this.partidoEleito.Location = new System.Drawing.Point(369, 63);
            this.partidoEleito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.partidoEleito.Name = "partidoEleito";
            this.partidoEleito.Size = new System.Drawing.Size(181, 27);
            this.partidoEleito.TabIndex = 4;
            this.partidoEleito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // votosEleito
            // 
            this.votosEleito.Enabled = false;
            this.votosEleito.Location = new System.Drawing.Point(584, 63);
            this.votosEleito.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.votosEleito.Name = "votosEleito";
            this.votosEleito.Size = new System.Drawing.Size(181, 27);
            this.votosEleito.TabIndex = 6;
            this.votosEleito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Votos Nulos";
            // 
            // votosNulos
            // 
            this.votosNulos.Enabled = false;
            this.votosNulos.Location = new System.Drawing.Point(249, 160);
            this.votosNulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.votosNulos.Name = "votosNulos";
            this.votosNulos.Size = new System.Drawing.Size(181, 27);
            this.votosNulos.TabIndex = 7;
            this.votosNulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Votos em Branco";
            // 
            // votosBrancos
            // 
            this.votosBrancos.Enabled = false;
            this.votosBrancos.Location = new System.Drawing.Point(482, 160);
            this.votosBrancos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.votosBrancos.Name = "votosBrancos";
            this.votosBrancos.Size = new System.Drawing.Size(181, 27);
            this.votosBrancos.TabIndex = 9;
            this.votosBrancos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewCandidatos
            // 
            this.viewCandidatos.Location = new System.Drawing.Point(149, 281);
            this.viewCandidatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewCandidatos.Name = "viewCandidatos";
            this.viewCandidatos.Size = new System.Drawing.Size(617, 232);
            this.viewCandidatos.TabIndex = 11;
            this.viewCandidatos.UseCompatibleStateImageBehavior = false;
            this.viewCandidatos.SelectedIndexChanged += new System.EventHandler(this.viewCandidatos_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Candidatos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(14, 553);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 31);
            this.btnVoltar.TabIndex = 13;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // visualizarEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viewCandidatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.votosBrancos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.votosNulos);
            this.Controls.Add(this.votosEleito);
            this.Controls.Add(this.Partido);
            this.Controls.Add(this.partidoEleito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eleito);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "visualizarEleicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Eleicao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox eleito;
        private Label label1;
        private Label label2;
        private Label Partido;
        private TextBox partidoEleito;
        private TextBox votosEleito;
        private Label label3;
        private TextBox votosNulos;
        private Label label4;
        private TextBox votosBrancos;
        private ListView viewCandidatos;
        private Label label5;
        private Button btnVoltar;
    }
}