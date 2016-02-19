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
    public class CategoriaDespesasAppService : AppServiceBase<CategoriaDespesas>, ICategoriaDespesasAppService
    {
        private readonly ICategoriaDespesasService _catdespesasService;

        public CategoriaDespesasAppService(ICategoriaDespesasService catDespesasService)
            :base(catDespesasService)
        {
            _catdespesasService = catDespesasService;
        }
    }
}
