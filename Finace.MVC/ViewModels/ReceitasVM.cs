using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finace.MVC.ViewModels
{
    public class ReceitasVM
    {
        [Key]
        public int ReceitaId { get; set; }
        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }

        [Range(typeof(decimal), "0", "9999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Recebimento")]
        public DateTime DataDoRecebimento { get; set; }
        public bool Recebido { get; set; }
        public int CategoriaReceitasId { get; set; }
        public virtual CategoriaReceitasVM CategoriaReceitas { get; set; }


    }

    public class ReceitasVMCadastrar
    {
        [Key]
        public int ReceitaId { get; set; }
        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Range(typeof(decimal), "0", "9999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Recebimento")]
        public DateTime DataDoRecebimento { get; set; }
        public bool Recebido { get; set; }
        public int CategoriaReceitasId { get; set; }
        public virtual CategoriaReceitasVM CategoriaReceitas { get; set; }
    }

    public class ReceitasVMAlterar
    {
        [Key]
        public int ReceitaId { get; set; }
        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(250, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }

        [Range(typeof(decimal), "0", "9999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Recebimento")]
        public DateTime DataDoRecebimento { get; set; }
        public bool Recebido { get; set; }
        public int CategoriaReceitasId { get; set; }
        public virtual CategoriaReceitasVM CategoriaReceitas { get; set; }
    }
}