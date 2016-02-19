using Finance.Domain.Entities;
using Finance.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infra.Repositories
{
    public class ReceitasRepository : RepositoryBase<Receitas>, IReceitasRepository
    {
    }
}
