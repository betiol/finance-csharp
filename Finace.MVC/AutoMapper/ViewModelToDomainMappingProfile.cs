using AutoMapper;
using Finace.MVC.ViewModels;
using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finace.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {

            #region Despesas/DespesasVM/CategoriaDespesas
            Mapper.CreateMap<Despesas, DespesasVM>();
            Mapper.CreateMap<CategoriaDespesas, CategoriaDespesasVM>();
            Mapper.CreateMap<DespesasVM, CategoriaDespesasVM>();
            Mapper.CreateMap<DespesasVMAlterar, Despesas>();
            Mapper.CreateMap<DespesasVMCadastrar, Despesas>();
            Mapper.CreateMap<Despesas, DespesasVMCadastrar>();
            Mapper.CreateMap<Despesas, DespesasVMAlterar>();
            Mapper.CreateMap<Despesas, DespesasVMAlterar>();

            #endregion

            #region Receitas/ReceitasVM/CategoriaReceitas
            Mapper.CreateMap<Receitas, ReceitasVM>();
            Mapper.CreateMap<CategoriaReceitas, CategoriaReceitasVM>();
            Mapper.CreateMap<ReceitasVM, CategoriaReceitasVM>();
            Mapper.CreateMap<ReceitasVMAlterar, Receitas>()
             .ForMember(x => x.Descricao, y => y.MapFrom(p => p.Descricao))
             .ForMember(x => x.Valor, y => y.MapFrom(p => p.Valor));
            Mapper.CreateMap<ReceitasVMCadastrar, Receitas>();
            #endregion
        }
    }
}