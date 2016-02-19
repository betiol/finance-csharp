using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infra.EntityConfig
{
    public class DespesasConfiguration : EntityTypeConfiguration<Despesas>
    {
        public DespesasConfiguration()
        {
            HasKey(c => c.DespesaId);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);

        }
    }
}
