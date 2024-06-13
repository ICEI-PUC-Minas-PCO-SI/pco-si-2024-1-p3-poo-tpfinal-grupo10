using System.Threading;

namespace UrnasBR
{
    public partial class Form1 : Form
    {
        //Onde est� Form1 � a tela de menu principal
        Thread MenuPrincipal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroEleicoes_Click(object sender, EventArgs e)
        {
            CadastroEleicoes tela = new CadastroEleicoes();
            this.Close();
            MenuPrincipal = new Thread(abrirCadastroEleicoes);
            MenuPrincipal.SetApartmentState(ApartmentState.STA);
            MenuPrincipal.Start();
        }

        private void btnCadastroPartido_Click(object sender, EventArgs e)
        {
            CadastroPartido tela = new CadastroPartido();
            this.Close();
            MenuPrincipal = new Thread(abrirCadastroPartido);
            MenuPrincipal.SetApartmentState(ApartmentState.STA);
            MenuPrincipal.Start();
        }

        private void btnCadastroCandidato_Click(object sender, EventArgs e)
        {
            cadastroCandidato tela = new cadastroCandidato();
            this.Close();
            MenuPrincipal = new Thread(abrirCadastroCandidato);
            MenuPrincipal.SetApartmentState(ApartmentState.STA);
            MenuPrincipal.Start();
        }

        private void btnInserirVotos_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarEleicoes_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarPartidos_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarCandidatos_Click(object sender, EventArgs e)
        {

        }

        //Este trecho s�o as chamadas para abrir as telas do menu
        private void abrirCadastroPartido(object obj)
        {
            Application.Run(new CadastroPartido());
        }

        private void abrirCadastroCandidato(object obj)
        {
            Application.Run(new cadastroCandidato());
        }
        
        private void abrirCadastroEleicoes(object obj)
        {
            Application.Run(new CadastroEleicoes());
        }
        /*
        private void abrirCadastroPartido(object obj)
        {
            Application.Run(new CadastroPartido());
        }

        private void abrirCadastroPartido(object obj)
        {
            Application.Run(new CadastroPartido());
        }
        */
    }
}