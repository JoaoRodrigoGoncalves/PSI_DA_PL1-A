﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestGest
{
    public partial class Pessoa 
    {
        public Pessoa()
        {
            this.Morada = new Morada();
        }
    }
}