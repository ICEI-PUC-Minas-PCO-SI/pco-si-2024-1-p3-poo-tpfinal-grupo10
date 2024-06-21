namespace UrnasBR
{
    partial class visualizarPartidos
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
            this.components = new System.ComponentModel.Container();
            this.viewPartidos = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExcluirMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditarPartido = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPartidos
            // 
            this.viewPartidos.ContextMenuStrip = this.contextMenuStrip1;
            this.viewPartidos.Location = new System.Drawing.Point(117, 71);
            this.viewPartidos.Name = "viewPartidos";
            this.viewPartidos.Size = new System.Drawing.Size(580, 290);
            this.viewPartidos.TabIndex = 0;
            this.viewPartidos.UseCompatibleStateImageBehavior = false;
            this.viewPartidos.SelectedIndexChanged += new System.EventHandler(this.viewPartidos_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExcluirMouse});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 26);
            // 
            // ExcluirMouse
            // 
            this.ExcluirMouse.Name = "ExcluirMouse";
            this.ExcluirMouse.Size = new System.Drawing.Size(150, 22);
            this.ExcluirMouse.Text = "Excluir Partido";
            this.ExcluirMouse.Click += new System.EventHandler(this.ExcluirMouse_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(240, 367);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.Location = new System.Drawing.Point(12, 415);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEditarPartido
            // 
            this.btnEditarPartido.Location = new System.Drawing.Point(487, 367);
            this.btnEditarPartido.Name = "btnEditarPartido";
            this.btnEditarPartido.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPartido.TabIndex = 3;
            this.btnEditarPartido.Text = "Editar";
            this.btnEditarPartido.UseVisualStyleBackColor = true;
            this.btnEditarPartido.Click += new System.EventHandler(this.btnEditarPartido_Click);
            // 
            // visualizarPartidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditarPartido);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.viewPartidos);
            this.Name = "visualizarPartidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Partidos";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView viewPartidos;
        private Button btnExcluir;
        private Button btnVoltar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ExcluirMouse;
        private Button btnEditarPartido;
    }
}