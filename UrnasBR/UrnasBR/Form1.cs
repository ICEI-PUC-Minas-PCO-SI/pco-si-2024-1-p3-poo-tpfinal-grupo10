/*using MySql.Data.MySqlClient;
using System.Reflection.Metadata;
using System.Threading;*/

using System.Threading;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using UrnasBR.Classes.ClassesConexaoBanco;

namespace UrnasBR
{
    public partial class Form1 : Form
    {
        //Onde está Form1 é a tela de menu principal
        Thread MenuPrincipal;
        ConexaoEleicoes conexao = new ConexaoEleicoes();
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            // Defina o caminho onde o PDF será salvo
            string path = @"C:\Users\vinic\OneDrive\Área de Trabalho";

            // Cria um documento PDF
            Document document = new Document();

            try
            {
                // Cria um escritor que direciona o documento para um arquivo
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

                // Abre o documento para escrita
                document.Open();

                // Adiciona um título ao documento
                document.Add(new Paragraph("Relatório de Candidatos\n"));

                // Adiciona uma linha em branco
                document.Add(new Paragraph("\n"));

                // Adiciona uma tabela com 3 colunas
                PdfPTable table = new PdfPTable(3);
                table.AddCell("Nome do Candidato");
                table.AddCell("Partido");
                table.AddCell("Número de Votos");

                // Conexão com o banco de dados MySQL
                string connectionString = "datasource=localhost;username=root;password=;database=urnasbr";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT candidatos.id_candidato, nome_candidato, partido_candidato, votos.quant_votos FROM candidatos JOIN votos on candidatos.id_candidato = votos.id_candidato";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                table.AddCell(reader["nome_candidato"].ToString());
                                table.AddCell(conexao.conferirPartido((int)reader["partido_candidato"]));
                                table.AddCell(reader["quant_votos"].ToString());
                            }
                        }
                    }
                }

                // Adiciona a tabela ao documento
                document.Add(table);

                MessageBox.Show("PDF gerado com sucesso em " + path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
            }
            finally
            {
                // Fecha o documento
                document.Close();
            }

        }
    }
}