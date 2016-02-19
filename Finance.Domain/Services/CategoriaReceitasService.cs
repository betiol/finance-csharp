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
    public class CategoriaReceitasService : ServiceBase<CategoriaReceitas>, ICategoriaReceitasService
    {
        public readonly ICategoriaReceitasRepository _categoriaReceitasRepository;
        public CategoriaReceitasService(ICategoriaReceitasRepository categoriaReceitasRepository)
            :base(categoriaReceitasRepository)
        {
            _categoriaReceitasRepository = categoriaReceitasRepository;
        }
    }
}
