using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnasBR
{
    public partial class CadastroEleicoes : Form
    {
        Thread cadastroEleicao;
        public CadastroEleicoes()
        {
            InitializeComponent();
        }

        private void btnCadastrarEleicao_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            cadastroEleicao = new Thread(abrirMenuPrincipal);
            cadastroEleicao.SetApartmentState(ApartmentState.STA);
            cadastroEleicao.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }

        
    }
}
