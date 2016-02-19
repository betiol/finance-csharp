using System;
using Finance.Domain.Entities;
using Finance.Infra.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Finance.Infra.Contexto
{
    public class FinanceApplication : DbContext
    {
        public FinanceApplication()
			:base("FinaceContext1")
        {

        }

		public DbSet<Despesas> Despesas { get; set; }
		public DbSet<Receitas> Receitas { get; set; }
		public DbSet<CategoriaDespesas> CategoriaDespesas { get; set; }
		public DbSet<CategoriaReceitas> CategoriaReceitas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new DespesasConfiguration());
            modelBuilder.Configurations.Add(new CategoriaReceitasConfiguration());
            modelBuilder.Configurations.Add(new CategoriaDespesasConfiguration());
            modelBuilder.Configurations.Add(new ReceitasConfiguration());

        }
    }
}
