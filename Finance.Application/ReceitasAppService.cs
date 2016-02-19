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
    public class ReceitasAppService : AppServiceBase<Receitas>, IReceitasAppService
    {
        private readonly IReceitasService _receitasService;

        public ReceitasAppService(IReceitasService receitasService)
            :base(receitasService)
        {
            _receitasService = receitasService;
        }
    }
}
