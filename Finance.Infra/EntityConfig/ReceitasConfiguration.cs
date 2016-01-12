using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace Finance.Infra.EntityConfig
{
    public class ReceitasConfiguration : EntityTypeConfiguration<Receitas>
    {
        public ReceitasConfiguration()
        {
            HasKey(c => c.ReceitaId);

            Property(c => c.Descricao)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.DataDoRecebimento)
                .IsRequired();

            Property(c => c.Recebido)
                .IsRequired();
        }
    }
}
