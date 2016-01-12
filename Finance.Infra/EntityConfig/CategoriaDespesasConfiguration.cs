using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infra.EntityConfig
{
    public class CategoriaDespesasConfiguration : EntityTypeConfiguration<CategoriaReceitas>
    {
        public CategoriaDespesasConfiguration()
        {
            HasKey(c => c.CategoriaReceitasId);

            Property(c => c.DescricaoCategoriaReceitas)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
