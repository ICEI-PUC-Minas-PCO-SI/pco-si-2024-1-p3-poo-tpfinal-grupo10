namespace UrnasBR
{
    partial class visualizarEleicoes
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.viewEleicoes = new System.Windows.Forms.ListView();
            this.btnVisualizarVotacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(12, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // viewEleicoes
            // 
            this.viewEleicoes.Location = new System.Drawing.Point(79, 63);
            this.viewEleicoes.Name = "viewEleicoes";
            this.viewEleicoes.Size = new System.Drawing.Size(640, 290);
            this.viewEleicoes.TabIndex = 4;
            this.viewEleicoes.UseCompatibleStateImageBehavior = false;
            this.viewEleicoes.SelectedIndexChanged += new System.EventHandler(this.viewEleicoes_SelectedIndexChanged);
            // 
            // btnVisualizarVotacao
            // 
            this.btnVisualizarVotacao.Location = new System.Drawing.Point(352, 359);
            this.btnVisualizarVotacao.Name = "btnVisualizarVotacao";
            this.btnVisualizarVotacao.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarVotacao.TabIndex = 8;
            this.btnVisualizarVotacao.Text = "Visualizar";
            this.btnVisualizarVotacao.UseVisualStyleBackColor = true;
            this.btnVisualizarVotacao.Click += new System.EventHandler(this.btnVisualizarVotacao_Click);
            // 
            // visualizarEleicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizarVotacao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.viewEleicoes);
            this.Name = "visualizarEleicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Eleicoes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVoltar;
        private ListView viewEleicoes;
        private Button btnVisualizarVotacao;
    }
}