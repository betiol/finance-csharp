using Finance.Domain.Entities;
using Finance.Domain.Interfaces.Repositories;
using Finance.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Domain.Services
{
    public class ReceitasService : ServiceBase<Receitas>, IReceitasService
    {
        private readonly IReceitasRepository _receitasRepository;

        public ReceitasService(IReceitasRepository receitasRepository)
            : base(receitasRepository)
        {
            _receitasRepository = receitasRepository;
        }
    }
}
