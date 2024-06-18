namespace UrnasBR
{
    partial class editarPartido
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
            this.btnSalvarPartido = new System.Windows.Forms.Button();
            this.siglaPartido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.presidPartido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomePartido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            btnVoltarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.BackColor = System.Drawing.Color.Black;
            btnVoltarMenu.ForeColor = System.Drawing.Color.White;
            btnVoltarMenu.Location = new System.Drawing.Point(16, 413);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new System.Drawing.Size(75, 23);
            btnVoltarMenu.TabIndex = 15;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnSalvarPartido
            // 
            this.btnSalvarPartido.BackColor = System.Drawing.Color.Black;
            this.btnSalvarPartido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarPartido.ForeColor = System.Drawing.Color.White;
            this.btnSalvarPartido.Location = new System.Drawing.Point(287, 311);
            this.btnSalvarPartido.Name = "btnSalvarPartido";
            this.btnSalvarPartido.Size = new System.Drawing.Size(220, 50);
            this.btnSalvarPartido.TabIndex = 14;
            this.btnSalvarPartido.Text = "Salvar";
            this.btnSalvarPartido.UseVisualStyleBackColor = false;
            this.btnSalvarPartido.Click += new System.EventHandler(this.btnSalvarPartido_Click);
            // 
            // siglaPartido
            // 
            this.siglaPartido.Location = new System.Drawing.Point(287, 178);
            this.siglaPartido.Name = "siglaPartido";
            this.siglaPartido.Size = new System.Drawing.Size(220, 23);
            this.siglaPartido.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sigla do partido";
            // 
            // presidPartido
            // 
            this.presidPartido.Location = new System.Drawing.Point(287, 238);
            this.presidPartido.Name = "presidPartido";
            this.presidPartido.Size = new System.Drawing.Size(220, 23);
            this.presidPartido.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Presidente do Partido";
            // 
            // nomePartido
            // 
            this.nomePartido.Location = new System.Drawing.Point(287, 114);
            this.nomePartido.Name = "nomePartido";
            this.nomePartido.Size = new System.Drawing.Size(220, 23);
            this.nomePartido.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do partido";
            // 
            // editarPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnVoltarMenu);
            this.Controls.Add(this.btnSalvarPartido);
            this.Controls.Add(this.siglaPartido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.presidPartido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomePartido);
            this.Controls.Add(this.label1);
            this.Name = "editarPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Partido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalvarPartido;
        private TextBox siglaPartido;
        private Label label3;
        private TextBox presidPartido;
        private Label label2;
        private TextBox nomePartido;
        private Label label1;
    }
}