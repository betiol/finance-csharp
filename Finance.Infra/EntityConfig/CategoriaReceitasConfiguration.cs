﻿using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Infra.EntityConfig
{
    public class CategoriaReceitasConfiguration : EntityTypeConfiguration<CategoriaDespesas>
    {
        public CategoriaReceitasConfiguration()
        {
            HasKey(c => c.CategoriaDespesaId);

            Property(c => c.DescricaoCategoriaDespesa)
                .IsRequired()
                .HasMaxLength(150);


        }
    }
}
