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
            this.label1 = new System.Windows.Forms.Label();
            this.cargoEleicao = new System.Windows.Forms.ComboBox();
            this.viewCandidatos = new System.Windows.Forms.ListView();
            btnVoltarMenu = new System.Windows.Forms.Button();
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
            this.btnCadastrarEleicao.Location = new System.Drawing.Point(285, 355);
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
            this.label5.Location = new System.Drawing.Point(193, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inserir Candidato";
            // 
            // nomeEleicao
            // 
            this.nomeEleicao.Location = new System.Drawing.Point(193, 31);
            this.nomeEleicao.Name = "nomeEleicao";
            this.nomeEleicao.Size = new System.Drawing.Size(408, 23);
            this.nomeEleicao.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome Eleição";
            // 
            // selectCandidato
            // 
            this.selectCandidato.FormattingEnabled = true;
            this.selectCandidato.Location = new System.Drawing.Point(193, 139);
            this.selectCandidato.Name = "selectCandidato";
            this.selectCandidato.Size = new System.Drawing.Size(312, 23);
            this.selectCandidato.TabIndex = 16;
            // 
            // btnAddCandidato
            // 
            this.btnAddCandidato.Location = new System.Drawing.Point(511, 139);
            this.btnAddCandidato.Name = "btnAddCandidato";
            this.btnAddCandidato.Size = new System.Drawing.Size(90, 23);
            this.btnAddCandidato.TabIndex = 17;
            this.btnAddCandidato.Text = "+";
            this.btnAddCandidato.UseVisualStyleBackColor = true;
            this.btnAddCandidato.Click += new System.EventHandler(this.btnAddCandidato_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cargo";
            // 
            // cargoEleicao
            // 
            this.cargoEleicao.FormattingEnabled = true;
            this.cargoEleicao.Location = new System.Drawing.Point(193, 86);
            this.cargoEleicao.Name = "cargoEleicao";
            this.cargoEleicao.Size = new System.Drawing.Size(408, 23);
            this.cargoEleicao.TabIndex = 21;
            this.cargoEleicao.SelectedIndexChanged += new System.EventHandler(this.cargoEleicao_SelectedIndexChanged);
            // 
            // viewCandidatos
            // 
            this.viewCandidatos.Location = new System.Drawing.Point(193, 168);
            this.viewCandidatos.Name = "viewCandidatos";
            this.viewCandidatos.Size = new System.Drawing.Size(408, 181);
            this.viewCandidatos.TabIndex = 22;
            this.viewCandidatos.UseCompatibleStateImageBehavior = false;
            // 
            // CadastroEleicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewCandidatos);
            this.Controls.Add(this.cargoEleicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(btnVoltarMenu);
            this.Controls.Add(this.btnAddCandidato);
            this.Controls.Add(this.selectCandidato);
            this.Controls.Add(this.btnCadastrarEleicao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nomeEleicao);
            this.Controls.Add(this.label4);
            this.Name = "CadastroEleicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Eleições";
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
        private Label label1;
        private ComboBox cargoEleicao;
        private ListView viewCandidatos;
    }
}