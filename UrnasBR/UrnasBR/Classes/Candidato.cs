using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrnasBR.Classes
{
    public class Candidato
    {
        private int idCandidato;
        private string nomeCandidato;
        private string cpfCandidato;
        private string natuCandidato;
        private string partido;
        private string cargo;

        public Candidato()
        {

        }

        public Candidato(int _idCandidato, string _nomeCandidato,string _cpfCandidato,string _natuCandidato, string _partido, string _cargo)
        {                                                        
            this.idCandidato = _idCandidato;
            this.nomeCandidato = _nomeCandidato;
            this.cpfCandidato = _cpfCandidato;
            this.natuCandidato = _natuCandidato;
            this.partido = _partido;
            this.cargo = _cargo;
        }

        public void setCandidato(int _idCandidato, string _nomeCandidato, string _cpfCandidato, string _natuCandidato, string _partido, string _cargo)
        {
            this.idCandidato = _idCandidato;
            this.nomeCandidato = _nomeCandidato;
            this.cpfCandidato = _cpfCandidato;
            this.natuCandidato = _natuCandidato;
            this.partido = _partido;
            this.cargo = _cargo;
        }

        public int getId()
        {
            return idCandidato;
        }

        public string getNome()
        {
            return nomeCandidato;
        }

        public string getCpf()
        {
            return cpfCandidato;
        }

        public string getNatu()
        {
            return natuCandidato;
        }

        public string getPartido()
        {
            return partido;
        }

        public string getCargo()
        {
            return cargo;
        }
    }
}
