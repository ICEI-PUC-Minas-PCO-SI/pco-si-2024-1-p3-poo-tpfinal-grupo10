namespace UrnasBR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastroEleicoes = new System.Windows.Forms.Button();
            this.btnCadastroPartido = new System.Windows.Forms.Button();
            this.btnCadastroCandidato = new System.Windows.Forms.Button();
            this.btnInserirVotos = new System.Windows.Forms.Button();
            this.btnVisualizarEleicoes = new System.Windows.Forms.Button();
            this.btnVisualizarPartidos = new System.Windows.Forms.Button();
            this.btnVisualizarCandidatos = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnCadastroEleicoes
            // 
            this.btnCadastroEleicoes.BackColor = System.Drawing.Color.Black;
            this.btnCadastroEleicoes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroEleicoes.ForeColor = System.Drawing.Color.White;
            this.btnCadastroEleicoes.Location = new System.Drawing.Point(22, 65);
            this.btnCadastroEleicoes.Name = "btnCadastroEleicoes";
            this.btnCadastroEleicoes.Size = new System.Drawing.Size(223, 58);
            this.btnCadastroEleicoes.TabIndex = 0;
            this.btnCadastroEleicoes.Text = "Cadastrar Eleições";
            this.btnCadastroEleicoes.UseVisualStyleBackColor = false;
            this.btnCadastroEleicoes.Click += new System.EventHandler(this.btnCadastroEleicoes_Click);
            // 
            // btnCadastroPartido
            // 
            this.btnCadastroPartido.BackColor = System.Drawing.Color.Black;
            this.btnCadastroPartido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroPartido.ForeColor = System.Drawing.Color.White;
            this.btnCadastroPartido.Location = new System.Drawing.Point(660, 65);
            this.btnCadastroPartido.Name = "btnCadastroPartido";
            this.btnCadastroPartido.Size = new System.Drawing.Size(223, 58);
            this.btnCadastroPartido.TabIndex = 1;
            this.btnCadastroPartido.Text = "Cadastrar Partido";
            this.btnCadastroPartido.UseVisualStyleBackColor = false;
            this.btnCadastroPartido.Click += new System.EventHandler(this.btnCadastroPartido_Click);
            // 
            // btnCadastroCandidato
            // 
            this.btnCadastroCandidato.BackColor = System.Drawing.Color.Black;
            this.btnCadastroCandidato.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastroCandidato.ForeColor = System.Drawing.Color.White;
            this.btnCadastroCandidato.Location = new System.Drawing.Point(319, 65);
            this.btnCadastroCandidato.Name = "btnCadastroCandidato";
            this.btnCadastroCandidato.Size = new System.Drawing.Size(223, 58);
            this.btnCadastroCandidato.TabIndex = 2;
            this.btnCadastroCandidato.Text = "Cadastrar Candidato";
            this.btnCadastroCandidato.UseVisualStyleBackColor = false;
            this.btnCadastroCandidato.Click += new System.EventHandler(this.btnCadastroCandidato_Click);
            // 
            // btnInserirVotos
            // 
            this.btnInserirVotos.BackColor = System.Drawing.Color.Black;
            this.btnInserirVotos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserirVotos.ForeColor = System.Drawing.Color.White;
            this.btnInserirVotos.Location = new System.Drawing.Point(660, 246);
            this.btnInserirVotos.Name = "btnInserirVotos";
            this.btnInserirVotos.Size = new System.Drawing.Size(223, 119);
            this.btnInserirVotos.TabIndex = 3;
            this.btnInserirVotos.Text = "Inserir Votos";
            this.btnInserirVotos.UseVisualStyleBackColor = false;
            this.btnInserirVotos.Click += new System.EventHandler(this.btnInserirVotos_Click);
            // 
            // btnVisualizarEleicoes
            // 
            this.btnVisualizarEleicoes.BackColor = System.Drawing.Color.Black;
            this.btnVisualizarEleicoes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarEleicoes.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarEleicoes.Location = new System.Drawing.Point(22, 148);
            this.btnVisualizarEleicoes.Name = "btnVisualizarEleicoes";
            this.btnVisualizarEleicoes.Size = new System.Drawing.Size(223, 58);
            this.btnVisualizarEleicoes.TabIndex = 4;
            this.btnVisualizarEleicoes.Text = "Visualizar Eleições";
            this.btnVisualizarEleicoes.UseVisualStyleBackColor = false;
            this.btnVisualizarEleicoes.Click += new System.EventHandler(this.btnVisualizarEleicoes_Click);
            // 
            // btnVisualizarPartidos
            // 
            this.btnVisualizarPartidos.BackColor = System.Drawing.Color.Black;
            this.btnVisualizarPartidos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarPartidos.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarPartidos.Location = new System.Drawing.Point(660, 148);
            this.btnVisualizarPartidos.Name = "btnVisualizarPartidos";
            this.btnVisualizarPartidos.Size = new System.Drawing.Size(223, 58);
            this.btnVisualizarPartidos.TabIndex = 5;
            this.btnVisualizarPartidos.Text = "Visualizar Partidos";
            this.btnVisualizarPartidos.UseVisualStyleBackColor = false;
            this.btnVisualizarPartidos.Click += new System.EventHandler(this.btnVisualizarPartidos_Click);
            // 
            // btnVisualizarCandidatos
            // 
            this.btnVisualizarCandidatos.BackColor = System.Drawing.Color.Black;
            this.btnVisualizarCandidatos.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarCandidatos.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarCandidatos.Location = new System.Drawing.Point(319, 144);
            this.btnVisualizarCandidatos.Name = "btnVisualizarCandidatos";
            this.btnVisualizarCandidatos.Size = new System.Drawing.Size(223, 62);
            this.btnVisualizarCandidatos.TabIndex = 6;
            this.btnVisualizarCandidatos.Text = "Visualizar Candidatos";
            this.btnVisualizarCandidatos.UseVisualStyleBackColor = false;
            this.btnVisualizarCandidatos.Click += new System.EventHandler(this.btnVisualizarCandidatos_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Black;
            this.btnRelatorio.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(22, 246);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(520, 119);
            this.btnRelatorio.TabIndex = 7;
            this.btnRelatorio.Text = "Relatório Eleições";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 412);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnVisualizarCandidatos);
            this.Controls.Add(this.btnVisualizarPartidos);
            this.Controls.Add(this.btnVisualizarEleicoes);
            this.Controls.Add(this.btnInserirVotos);
            this.Controls.Add(this.btnCadastroCandidato);
            this.Controls.Add(this.btnCadastroPartido);
            this.Controls.Add(this.btnCadastroEleicoes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCadastroEleicoes;
        private Button btnCadastroPartido;
        private Button btnCadastroCandidato;
        private Button btnInserirVotos;
        private Button btnVisualizarEleicoes;
        private Button btnVisualizarPartidos;
        private Button btnVisualizarCandidatos;
        private Button btnRelatorio;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}