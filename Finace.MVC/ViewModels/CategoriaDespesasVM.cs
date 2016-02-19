using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finace.MVC.ViewModels
{
    public class CategoriaDespesasVM
    {
         [Key]
        public int CategoriaDespesaId { get; set; }

        public string DescricaoCategoriaDespesa { get; set; }

        public virtual IEnumerable<DespesasVM> Despesas { get; set; }
    }
}