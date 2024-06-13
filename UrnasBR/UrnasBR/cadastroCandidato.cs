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
    public partial class cadastroCandidato : Form
    {
        Thread CadastroCandidato;
        public cadastroCandidato()
        {
            InitializeComponent();
        }

        private void btnCadastrarCandidato_Click(object sender, EventArgs e)
        {
            
        }

        

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            CadastroCandidato = new Thread(abrirMenuPrincipal);
            CadastroCandidato.SetApartmentState(ApartmentState.STA);
            CadastroCandidato.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
