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
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        public DateTime? DataPagamento { get; set; }
        public int CategoriaDespesaId { get; set; }
        public virtual CategoriaDespesas CategoriaDespesas { get; set; }
    }
}
