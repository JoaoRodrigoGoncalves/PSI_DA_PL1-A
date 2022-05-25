using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest
{
    public partial class Pessoa 
    {
        public Pessoa(int id, string nome, string telemovel, bool ativo, string numContribuinte, Morada morada)
        {
            Id = id;
            Nome = nome;
            Telemovel = telemovel;
            Ativo = ativo;
            NumContribuinte = numContribuinte;
            Morada = morada;
            this.Ativo = true;
        }
    }
}
