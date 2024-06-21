using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnasBR.Classes.ClassesConexaoBanco
{
    public class ConexaoEleicoes:conexaoBanco
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
        public void Inserir(string _nomeEleicao,string _cargoEleicao, int[]_candidato)
        {
            string sql = $"INSERT INTO eleicoes(nome_eleicao,id_cargo)VALUES('{_nomeEleicao}',{conferirCargo(_cargoEleicao)});";
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            comando.ExecuteReader();
            FecharConexao();
            InserirTabelaVotos(_nomeEleicao,conferirCargo(_cargoEleicao),_candidato);
        }

        //Esta função é pra adicionar os candidatos na tabela de votos
        private void InserirTabelaVotos(string _nomeEleicao,int _cargoEleicao, int[]_candidato)
        {
            for(int i = 0; i < _candidato.Length; i++)
            {
                string sql = $"INSERT INTO votos(id_eleicao,id_candidato)VALUES({ConferirEleicao(_nomeEleicao)},{_candidato[i]});";
                AbrirConexao();
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
                comando.ExecuteReader();
                FecharConexao();
            }
        }

        public void InserirVotos(int _idEleicao,int _id_candidato,int _quantVotos)
        {
            string sql = $"UPDATE votos set quant_votos = {_quantVotos} where id_eleicao = {_idEleicao} and id_candidato = {_id_candidato}";
            AbrirConexao();
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            comando.ExecuteReader();
            FecharConexao();
        }

        public void Buscar(ListView _view,string candidato)
        {
            AbrirConexao();
            string sql = $"SELECT id_candidato,nome_candidato,partido_candidato FROM candidatos where nome_candidato = '{candidato}';";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();

            //Este é o trecho de leitura no banco de dados
            while (reader.Read())
            {
                string[] row =
                {
                    reader.GetInt32(0).ToString(),
                    reader.GetString(1),
                    reader.GetInt32(2).ToString(),
                };

                row[2] = conferirPartido(reader.GetInt32(2));

                var linha_lista = new ListViewItem(row);
                _view.Items.Add(linha_lista);
            }
            FecharConexao();
        }

        //Busca para a combo box de cargos
        public void Buscar(ComboBox _comboBox)
        {
            AbrirConexao();
            string sql = $"SELECT * FROM cargos;";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                _comboBox.Items.Add(reader.GetString(1));
            }
            FecharConexao();
        }

        public void Buscar(ComboBox _comboBox, string cargo)
        {
            AbrirConexao();
            string sql = $"select id_candidato,nome_candidato,partido_candidato from candidatos where cargo_candidato = (select id_cargo from cargos where descricao_cargo = '{cargo}');";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                _comboBox.Items.Add(reader.GetString(1));
            }
            FecharConexao();
        }

        public void Buscar(ListView _view)
        {
            AbrirConexao();
            string sql = $"select * from eleicoes;";
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
                };

                row[2] = conferirCargo(reader.GetInt32(2));

                var linha_lista = new ListViewItem(row);
                _view.Items.Add(linha_lista);
            }
            FecharConexao();
        }

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

        private string conferirCargo(int _cargo)
        {
            string sql = $"SELECT descricao_cargo FROM cargos WHERE id_cargo = '{_cargo}';";
            AbrirConexao();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string cargo = reader.GetString(0);
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

            return "";
        }

        private int ConferirEleicao(string _nomeEleicao)
        {
            string sql = $"SELECT id_eleicao FROM eleicoes WHERE nome_eleicao = '{_nomeEleicao}';";
            AbrirConexao();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
                MySqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int eleicao = reader.GetInt32(0);
                    return eleicao;
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

        public void Editar()
        {

        }
        public void Excluir()
        {

        }
    }
}
