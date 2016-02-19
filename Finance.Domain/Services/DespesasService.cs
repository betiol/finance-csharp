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
    public class DespesasService : ServiceBase<Despesas>, IDespesasService
    {
        private readonly IDespesaRepository _despesasRepository;
        public DespesasService(IDespesaRepository despesasRepository)
            :base(despesasRepository)
        {
            _despesasRepository = despesasRepository;
        }
    }
}
