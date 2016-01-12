﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Entities
{
    public class Receitas
    {

        public int ReceitaId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDoRecebimento { get; set; }
        public bool Recebido { get; set; }
        public virtual IEnumerable<CategoriaReceitas> CategoriaReceitas { get; set; }

        
    }
}
