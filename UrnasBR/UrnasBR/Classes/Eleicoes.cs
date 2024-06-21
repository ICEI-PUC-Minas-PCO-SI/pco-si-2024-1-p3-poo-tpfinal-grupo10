using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnasBR
{
    public class Eleicoes
    {
        private int idEleicao;
        private string nomeEleicao;
        private string cargo;

        public void setEleicoes(int _idEleicao,string _nomeEleicao,string _cargoEleicao)
        {
            this.idEleicao = _idEleicao;
            this.nomeEleicao = _nomeEleicao;
            this.cargo = _cargoEleicao;
        }

        public int getId()
        {
            return idEleicao;
        }

        public string getNomeEleicao()
        {
            return nomeEleicao;
        }

        public string getCargo()
        {
            return cargo;
        }

    }
}
