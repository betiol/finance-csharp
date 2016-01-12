using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Entities
{
    public class Despesas
    {

        public int DespesaId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Recebido { get; set; }
        public DateTime DataPagamento { get; set; }
        public virtual IEnumerable<CategoriaDespesas> CategoriaDespesas { get; set; }
    }
}
