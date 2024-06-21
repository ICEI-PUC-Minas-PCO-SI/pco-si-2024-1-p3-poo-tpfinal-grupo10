namespace UrnasBR
{
    partial class inserirVotos
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
            this.textArquivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnVisualizarEleicoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textArquivo
            // 
            this.textArquivo.Location = new System.Drawing.Point(201, 207);
            this.textArquivo.Name = "textArquivo";
            this.textArquivo.Size = new System.Drawing.Size(350, 23);
            this.textArquivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o Arquivo";
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(557, 206);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(123, 23);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar Arquivo";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(12, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnVisualizarEleicoes
            // 
            this.btnVisualizarEleicoes.BackColor = System.Drawing.Color.Black;
            this.btnVisualizarEleicoes.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarEleicoes.Location = new System.Drawing.Point(628, 415);
            this.btnVisualizarEleicoes.Name = "btnVisualizarEleicoes";
            this.btnVisualizarEleicoes.Size = new System.Drawing.Size(149, 23);
            this.btnVisualizarEleicoes.TabIndex = 5;
            this.btnVisualizarEleicoes.Text = "Visualizar Eleições";
            this.btnVisualizarEleicoes.UseVisualStyleBackColor = false;
            this.btnVisualizarEleicoes.Click += new System.EventHandler(this.btnVisualizarEleicoes_Click);
            // 
            // inserirVotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizarEleicoes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.textArquivo);
            this.Controls.Add(this.label1);
            this.Name = "inserirVotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Votos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textArquivo;
        private Label label1;
        private Button btnSelecionar;
        private OpenFileDialog openFileDialog1;
        private Button btnVoltar;
        private Button btnVisualizarEleicoes;
    }
}