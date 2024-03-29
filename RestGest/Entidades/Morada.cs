﻿using System;

namespace RestGest
{
    public partial class Morada
    {
        public Morada()
        {

        }

        public Morada(string rua, string cidade, string cp, string pais)
        {
            this.Rua = rua;
            this.Cidade = cidade;
            this.Codigo_Postal = cp;
            this.Pais = pais;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1} {2}, {3}", this.Rua, this.Codigo_Postal, this.Cidade, this.Pais);
        }
    }
}
