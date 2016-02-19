using AutoMapper;
using Finace.MVC.ViewModels;
using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Finace.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {

            #region Despesas/DespesasVM/CategoriaDespesas
            Mapper.CreateMap<DespesasVM, Despesas>()
                .ForMember(x => x.DataPagamento, y => y.MapFrom(x => x.DataPagamento))
                .ForMember(x => x.DataVencimento, y => y.MapFrom(x => x.DataVencimento));
            


            Mapper.CreateMap<CategoriaDespesasVM, CategoriaDespesas>();
            Mapper.CreateMap<CategoriaDespesasVM, Despesas>();
            Mapper.CreateMap<DespesasVMAlterar, Despesas>();
            Mapper.CreateMap<DespesasVMCadastrar, Despesas>();

            #endregion

            #region Receitas/ReceitasVM/CategoriaReceitas
            Mapper.CreateMap<ReceitasVM, Receitas>();
            Mapper.CreateMap<CategoriaReceitasVM, CategoriaReceitas>();
            Mapper.CreateMap<CategoriaReceitasVM, ReceitasVM>();
            Mapper.CreateMap<Receitas, ReceitasVMCadastrar>();
            Mapper.CreateMap<Receitas, ReceitasVMAlterar>();
            #endregion
        }
    }
}