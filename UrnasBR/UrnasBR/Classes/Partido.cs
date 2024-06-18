using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnasBR;

namespace UrnasBR
{
    public class Partido
    {
        private int id;
        private string nomePartido;
        private string siglaPartido;
        private string nomePresidente;

        public Partido()
        {

        }

        public Partido(int _id,string _nomePartido, string _siglaPartido, string _nomePresidente)
        {
            this.id = _id;
            this.nomePartido = _nomePartido;
            this.siglaPartido = _siglaPartido;
            this.nomePresidente = _nomePresidente;
        }

        public void setPartido(int _id, string _nomePartido, string _siglaPartido, string _nomePresidente)
        {
            this.id = _id;
            this.nomePartido = _nomePartido;
            this.siglaPartido = _siglaPartido;
            this.nomePresidente = _nomePresidente;
        }

        public int getId()
        {
            return id;
        }

        public string getNomePartido()
        {
            return nomePartido;
        }

        public string getSigla()
        {
            return siglaPartido;
        }

        public string getPresidente()
        {
            return nomePresidente;
        }
    }
}
