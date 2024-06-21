using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnasBR.Classes.ClassesConexaoBanco
{
    public class ConexaoCandidatos : conexaoBanco
    {
        MySqlConnection ConexaoBanco;

        private string data_source = "datasource=localhost;username=root;password=;database=urnasbr";
        public void AbrirConexao()
        {
            ConexaoBanco = new MySqlConnection(data_source);
            ConexaoBanco.Open();
        }

        public void FecharConexao()
        {
            ConexaoBanco.Close();
        }
        public void Inserir(string _nomeCandidato, string _cpfCandidato, string _natuCandidato, string _partCandidato, string _cargoCandidato)
        {
            string sql = $"INSERT INTO candidatos(nome_candidato,cpf_candidato,naturalidade_candidato,partido_candidato,cargo_candidato)VALUES('{_nomeCandidato}','{_cpfCandidato}','{_natuCandidato}',{conferirPartido(_partCandidato)},{conferirCargo(_cargoCandidato)})";
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            comando.ExecuteReader();
            FecharConexao();
        }

        //Busca para comboBox de partidos
        public void Buscar(ComboBox _comboBox)
        {
            AbrirConexao();
            string sql = $"SELECT * FROM partidos;";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                _comboBox.Items.Add(reader.GetString(1));
            }
            FecharConexao();
        }

        //Busca para a listagem de candidatos
        public void Buscar(ListView _view)
        {
            AbrirConexao();
            string sql = $"SELECT * FROM candidatos;";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();
            _view.Items.Clear();

            //Este é o trecho de leitura no banco de dados
            while (reader.Read())
            {
                string[] row =
                {
                    reader.GetInt32(0).ToString(),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetInt32(4).ToString(),
                    reader.GetInt32(5).ToString()
                };

                row[4] = conferirPartido(reader.GetInt32(4));
                row[5] = conferirCargo(reader.GetInt32(5));

                var linha_lista = new ListViewItem(row);
                _view.Items.Add(linha_lista);
            }
            FecharConexao();
        }

        public void BuscarCandidatosEleicao(ListView _view, Eleicoes eleicao)
        {
            AbrirConexao();
            string sql = $"select candidatos.id_candidato,nome_candidato,partido_candidato,votos.quant_votos from candidatos join votos on candidatos.id_candidato = votos.id_candidato where votos.id_eleicao = {eleicao.getId()};";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();
            _view.Items.Clear();

            //Este é o trecho de leitura no banco de dados
            while (reader.Read())
            {
                string[] row =
                {
                    reader.GetInt32(0).ToString(),
                    reader.GetString(1),
                    reader.GetInt32(2).ToString(),
                    reader.GetInt32(3).ToString()
                };

                row[2] = conferirPartido(reader.GetInt32(2));

                var linha_lista = new ListViewItem(row);
                _view.Items.Add(linha_lista);
            }
            FecharConexao();
        }

        //Esta função busca os dados do candidato eleito
        public void BuscarDadosEleicao(TextBox _nomeCandidato, TextBox _partidoCandidato, TextBox _quantVotos, Eleicoes _eleicao)
        {
            AbrirConexao();
            string sql = $"SELECT id_candidato, quant_votos FROM votos v INNER JOIN (SELECT MAX(quant_votos) AS maior_votos FROM votos) mv ON v.quant_votos = mv.maior_votos where id_eleicao = {_eleicao.getId()};";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                _nomeCandidato.Text = verificarCandidato(reader.GetInt32(0), ref _partidoCandidato);
                _quantVotos.Text = reader.GetInt32(1).ToString();
            }

            FecharConexao();
        }

        public void BuscarDadosEleicao(Eleicoes _eleicao, TextBox[] _campos)
        {
            AbrirConexao();
            string sql = $"select quant_votos from votos where id_eleicao = {_eleicao.getId()} and id_candidato between 1 and 2;";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                _campos[i].Text = reader.GetInt32(0).ToString();
                i++;
            }

            FecharConexao();
        }






        public void Editar(Candidato candidato, string _nomeCandidato, string _cpfCandidato, string _natuCandidato, string _partCandidato, string _cargoCandidato)
        {
            string sql = $"UPDATE candidatos SET nome_candidato = '{_nomeCandidato}',cpf_candidato = '{_cpfCandidato}',naturalidade_candidato = '{_natuCandidato}',partido_candidato = {conferirPartido(_partCandidato)},cargo_candidato = {conferirCargo(_cargoCandidato)} WHERE id_candidato = {candidato.getId()};";
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            comando.ExecuteReader();
            FecharConexao();
        }
        public void Excluir(Candidato candidato)
        {
            AbrirConexao();
            string sql = $"DELETE FROM candidatos WHERE id_candidato = {candidato.getId()};";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            comando.ExecuteReader();
            FecharConexao();
        }

        //Estas funçoes servem para retornar o id de cada coluna
        private int conferirPartido(string _partido)
        {
            string sql = $"SELECT * FROM partidos WHERE nome_partido = '{_partido}';";
            AbrirConexao();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    FecharConexao();
                    return id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return 0;
        }
        private int conferirCargo(string _cargo)
        {
            string sql = $"SELECT id_cargo FROM cargos WHERE descricao_cargo = '{_cargo}';";
            AbrirConexao();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int cargo = reader.GetInt32(0);
                    return cargo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return 0;
        }

        //Estas funçoes servem para retornar o nome de cada coluna
        private string conferirPartido(int _partido)
        {
            string sql = $"SELECT nome_partido FROM partidos WHERE id = {_partido};";
            AbrirConexao();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string nome = reader.GetString(0);
                    FecharConexao();
                    return nome;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return "-";
        }
        private string conferirCargo(int _cargo)
        {
            string sql = $"SELECT descricao_cargo FROM cargos WHERE id_cargo = {_cargo};";
            AbrirConexao();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string cargo = reader.GetString(0);
                    FecharConexao();
                    return cargo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexao();
            }

            return "-";
        }

        private string verificarCandidato(int _idCandidato, ref TextBox _partidoCandidato)
        {
            AbrirConexao();
            string sql = $"select nome_candidato,partido_candidato from candidatos where id_candidato = {_idCandidato};";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                _partidoCandidato.Text = conferirPartido(reader.GetInt32(1));
                return reader.GetString(0);
            }
            FecharConexao();
            return "Não encontrado";

        }
    }

}