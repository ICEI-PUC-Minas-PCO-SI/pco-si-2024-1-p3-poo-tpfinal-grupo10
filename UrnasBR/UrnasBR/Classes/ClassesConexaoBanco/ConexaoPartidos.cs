using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UrnasBR.Classes.ClassesConexaoBanco
{
    public class ConexaoPartidos:conexaoBanco
    {
        MySqlConnection ConexaoBanco;

        private string data_source = "datasource=localhost;username=root;password=;database=urnasbr";
        private void AbrirConexao()
        {
            ConexaoBanco = new MySqlConnection(data_source);
            ConexaoBanco.Open();
        }
        public void FecharConexao()
        {
            ConexaoBanco.Close();
        }
        public void Inserir(string _nomeTabela, string _nomeColuna1, string _nomeColuna2, string _nomeColuna3, string _nomePartido, string _siglaPartido, string _presidPartido)
        {
            AbrirConexao();
            string sql = $"INSERT INTO {_nomeTabela}({_nomeColuna1},{_nomeColuna2},{_nomeColuna3})VALUES('{_nomePartido}','{_siglaPartido}','{_presidPartido}')";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            comando.ExecuteReader();
            FecharConexao();
        }

        public void Buscar(ListView _view)
        {
            AbrirConexao();
            string sql = $"SELECT * FROM partidos;";
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
                    reader.GetString(3)
                };
                var linha_lista = new ListViewItem(row);
                _view.Items.Add(linha_lista);
            }
            FecharConexao();
        }

        public void Excluir(Partido partido)
        {
            AbrirConexao();
            string sql = $"DELETE FROM partidos WHERE id = {partido.getId()};";
            MySqlCommand comando = new MySqlCommand(sql, ConexaoBanco);
            comando.ExecuteReader();
            FecharConexao();
        }
    }
}
