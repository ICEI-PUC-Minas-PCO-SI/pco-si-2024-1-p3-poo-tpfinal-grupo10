using System.Threading;

namespace UrnasBR
{
    public partial class Form1 : Form
    {
        //Onde está Form1 é a tela de menu principal
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
            inserirVotos tela = new inserirVotos();
            this.Close();
            MenuPrincipal = new Thread(abrirInserirVotos);
            MenuPrincipal.SetApartmentState(ApartmentState.STA);
            MenuPrincipal.Start();
        }

        private void btnVisualizarEleicoes_Click(object sender, EventArgs e)
        {
            visualizarEleicoes tela = new visualizarEleicoes();
            this.Close();
            MenuPrincipal = new Thread(abrirVisualizarEleicoes);
            MenuPrincipal.SetApartmentState(ApartmentState.STA);
            MenuPrincipal.Start();
        }

        private void btnVisualizarPartidos_Click(object sender, EventArgs e)
        {
            visualizarPartidos tela = new visualizarPartidos();
            this.Close();
            MenuPrincipal = new Thread(abrirVisualizarPartidos);
            MenuPrincipal.SetApartmentState(ApartmentState.STA);
            MenuPrincipal.Start();
        }

        private void btnVisualizarCandidatos_Click(object sender, EventArgs e)
        {
            visualizarCandidatos tela = new visualizarCandidatos();
            this.Close();
            MenuPrincipal = new Thread(abrirVisualizarCandidatos);
            MenuPrincipal.SetApartmentState(ApartmentState.STA);
            MenuPrincipal.Start();
        }

        //Este trecho são as chamadas para abrir as telas do menu
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
        
        private void abrirVisualizarPartidos(object obj)
        {
            Application.Run(new visualizarPartidos());
        }
        
        private void abrirVisualizarCandidatos(object obj)
        {
            Application.Run(new visualizarCandidatos());
        }

        private void abrirInserirVotos(object obj)
        {
            Application.Run(new inserirVotos());
        }

        private void abrirVisualizarEleicoes(object obj)
        {
            Application.Run(new visualizarEleicoes());
        }

    }
}