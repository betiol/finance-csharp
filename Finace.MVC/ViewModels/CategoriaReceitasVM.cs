using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finace.MVC.ViewModels
{
    public class CategoriaReceitasVM
    {

  
        [Key]
        public int CategoriaReceitasId { get; set; }
        [Display(Name = "Descrição de Categoria")]
        public string DescricaoCategoriaReceitas { get; set; }
        public virtual IEnumerable<ReceitasVM> Receitas { get; set; }

    }
}