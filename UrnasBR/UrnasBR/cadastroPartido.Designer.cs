namespace UrnasBR
{
    partial class CadastroPartido
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrarPartido = new System.Windows.Forms.Button();
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
            btnVoltarMenu.TabIndex = 7;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do partido";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 23);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Presidente do Partido";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(283, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 23);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sigla do partido";
            // 
            // btnCadastrarPartido
            // 
            this.btnCadastrarPartido.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarPartido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarPartido.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarPartido.Location = new System.Drawing.Point(283, 313);
            this.btnCadastrarPartido.Name = "btnCadastrarPartido";
            this.btnCadastrarPartido.Size = new System.Drawing.Size(220, 50);
            this.btnCadastrarPartido.TabIndex = 6;
            this.btnCadastrarPartido.Text = "Cadastrar Partido";
            this.btnCadastrarPartido.UseVisualStyleBackColor = false;
            this.btnCadastrarPartido.Click += new System.EventHandler(this.btnCadastrarPartido_Click);
            // 
            // CadastroPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnVoltarMenu);
            this.Controls.Add(this.btnCadastrarPartido);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CadastroPartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Partido";
            this.Load += new System.EventHandler(this.CadastroPartido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button btnCadastrarPartido;
    }
}