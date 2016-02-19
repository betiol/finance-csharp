using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Finace.MVC.ViewModels
{
    public class DespesasVM
    {
        [Key]
        public int DespesaId { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Vencimento")]
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Pagamento")]
        public DateTime DataPagamento { get; set; }
        public int CategoriaDespesaId { get; set; }
        public virtual CategoriaDespesasVM CategoriaDespesas { get; set; }

    }

    public class DespesasVMCadastrar
    {
        [Key]
        public int DespesaId { get; set; }
    
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Vencimento")]
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Pagamento")]
        public DateTime? DataPagamento { get; set; }
        public int CategoriaDespesaId { get; set; }
        public virtual CategoriaDespesasVM CategoriaDespesas { get; set; }

    }

    public class DespesasVMAlterar
    {
        public int DespesaId { get; set; }

        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Vencimento")]
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}")]
        [Display(Name = "Data de Pagamento")]
        public DateTime? DataPagamento { get; set; }
        public int CategoriaDespesaId { get; set; }
        public virtual CategoriaDespesasVM CategoriaDespesas { get; set; }


    }
}