using Finance.Application.Interface;
using Finance.Domain.Entities;
using Finance.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Application
{
    public class DespesasAppService : AppServiceBase<Despesas>, IDespesasAppService
    {
        private readonly IDespesasService _despesasService;

        public DespesasAppService(IDespesasService despesasService)
        :base(despesasService)
        {
            _despesasService = despesasService;
        }
    }
}
