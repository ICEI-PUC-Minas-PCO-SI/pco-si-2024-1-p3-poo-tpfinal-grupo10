namespace UrnasBR
{
    partial class CadastroEleicoes
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
            System.Windows.Forms.Button btnVoltarMenu;
            this.btnCadastrarEleicao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeEleicao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectCandidato = new System.Windows.Forms.ComboBox();
            this.btnAddCandidato = new System.Windows.Forms.Button();
            this.viewCandidatos = new System.Windows.Forms.DataGridView();
            btnVoltarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.BackColor = System.Drawing.Color.Black;
            btnVoltarMenu.ForeColor = System.Drawing.Color.White;
            btnVoltarMenu.Location = new System.Drawing.Point(12, 415);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new System.Drawing.Size(75, 23);
            btnVoltarMenu.TabIndex = 19;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnCadastrarEleicao
            // 
            this.btnCadastrarEleicao.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarEleicao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarEleicao.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarEleicao.Location = new System.Drawing.Point(290, 338);
            this.btnCadastrarEleicao.Name = "btnCadastrarEleicao";
            this.btnCadastrarEleicao.Size = new System.Drawing.Size(220, 56);
            this.btnCadastrarEleicao.TabIndex = 15;
            this.btnCadastrarEleicao.Text = "Cadastrar Eleição";
            this.btnCadastrarEleicao.UseVisualStyleBackColor = false;
            this.btnCadastrarEleicao.Click += new System.EventHandler(this.btnCadastrarEleicao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inserir Candidato";
            // 
            // nomeEleicao
            // 
            this.nomeEleicao.Location = new System.Drawing.Point(290, 69);
            this.nomeEleicao.Name = "nomeEleicao";
            this.nomeEleicao.Size = new System.Drawing.Size(220, 23);
            this.nomeEleicao.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome Eleição";
            // 
            // selectCandidato
            // 
            this.selectCandidato.FormattingEnabled = true;
            this.selectCandidato.Location = new System.Drawing.Point(290, 122);
            this.selectCandidato.Name = "selectCandidato";
            this.selectCandidato.Size = new System.Drawing.Size(183, 23);
            this.selectCandidato.TabIndex = 16;
            // 
            // btnAddCandidato
            // 
            this.btnAddCandidato.Location = new System.Drawing.Point(479, 122);
            this.btnAddCandidato.Name = "btnAddCandidato";
            this.btnAddCandidato.Size = new System.Drawing.Size(31, 23);
            this.btnAddCandidato.TabIndex = 17;
            this.btnAddCandidato.Text = "+";
            this.btnAddCandidato.UseVisualStyleBackColor = true;
            // 
            // viewCandidatos
            // 
            this.viewCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewCandidatos.Location = new System.Drawing.Point(290, 151);
            this.viewCandidatos.Name = "viewCandidatos";
            this.viewCandidatos.RowTemplate.Height = 25;
            this.viewCandidatos.Size = new System.Drawing.Size(220, 181);
            this.viewCandidatos.TabIndex = 18;
            // 
            // CadastroEleicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnVoltarMenu);
            this.Controls.Add(this.viewCandidatos);
            this.Controls.Add(this.btnAddCandidato);
            this.Controls.Add(this.selectCandidato);
            this.Controls.Add(this.btnCadastrarEleicao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nomeEleicao);
            this.Controls.Add(this.label4);
            this.Name = "CadastroEleicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Eleições";
            ((System.ComponentModel.ISupportInitialize)(this.viewCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCadastrarEleicao;
        private Label label5;
        private TextBox nomeEleicao;
        private Label label4;
        private ComboBox selectCandidato;
        private Button btnAddCandidato;
        private DataGridView viewCandidatos;
    }
}