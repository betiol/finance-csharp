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
    public class CategoriaDespesasService : ServiceBase<CategoriaDespesas>, ICategoriaDespesasService
    {
        public readonly ICategoriaDespesasRepository _categoriaDespesasRepository;
        public CategoriaDespesasService(ICategoriaDespesasRepository categoriaDespesasRepository)
            :base(categoriaDespesasRepository)
        {
            _categoriaDespesasRepository = categoriaDespesasRepository;
        }
    }
}
