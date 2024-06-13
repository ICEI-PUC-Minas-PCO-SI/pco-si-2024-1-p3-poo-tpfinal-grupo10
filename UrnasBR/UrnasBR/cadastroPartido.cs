using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UrnasBR
{
    public partial class CadastroPartido : Form
    {
        Thread cadastroPartido;
        public CadastroPartido()
        {
            InitializeComponent();
        }

        private void CadastroPartido_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarPartido_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            cadastroPartido = new Thread(abrirMenuPrincipal);
            cadastroPartido.SetApartmentState(ApartmentState.STA);
            cadastroPartido.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
