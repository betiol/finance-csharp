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
    public class CategoriaReceitasAppService : AppServiceBase<CategoriaReceitas>, ICategoriaReceitasAppService
    {
        private readonly ICategoriaReceitasService _categoriaReceitasService;

        public CategoriaReceitasAppService(ICategoriaReceitasService categoriaReceitasService)
            :base(categoriaReceitasService)
        {
            _categoriaReceitasService = categoriaReceitasService;
        }
    }
}
