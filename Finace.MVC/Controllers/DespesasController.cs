using AutoMapper;
using Finace.MVC.ViewModels;
using Finance.Application.Interface;
using Finance.Domain.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finace.MVC.Controllers
{
    public class DespesasController : Controller
    {

        private readonly IDespesasAppService _despesasAppService;
        private readonly ICategoriaDespesasAppService _catDespesasAppService;

        public DespesasController(IDespesasAppService despesasAppService, ICategoriaDespesasAppService catDespesasAppService)
        {
            _despesasAppService = despesasAppService;
            _catDespesasAppService = catDespesasAppService;
        }



        public ActionResult Index(string filtroDescricao, int page = 1)
        {
            var despesasVM = Mapper.Map<IEnumerable<Despesas>, IEnumerable<DespesasVM>>(_despesasAppService.GetAll().ToList());


        
            //var query = _despesasAppService.GetAll().AsQueryable();

            //if (!string.IsNullOrWhiteSpace(filtroDescricao))
            //{
            //    query = query.Where(x => x.Descricao.Contains(filtroDescricao));
            //}


            var total = _despesasAppService.GetAll().Sum(x => x.Valor);
            ViewBag.Total = total;
            return View(despesasVM.ToPagedList(page, 10));
        }

        public ActionResult Details(int id)
        {
            var despesas = _despesasAppService.GetById(id);
            var despesasVM = Mapper.Map<Despesas, DespesasVM>(despesas);

            return View(despesasVM);
        }

        public ActionResult Create()
        {
            ViewBag.CategoriaDespesaId = new SelectList(_catDespesasAppService.GetAll(), "CategoriaDespesaId", "DescricaoCategoriaDespesa");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesasVMCadastrar despesas)
        {
            if (ModelState.IsValid)
            {
                var despesasDomain = Mapper.Map<DespesasVMCadastrar, Despesas>(despesas);
                _despesasAppService.Add(despesasDomain);
                return RedirectToAction("Index");

            }
            ViewBag.CategoriaDespesaId = new SelectList(_catDespesasAppService.GetAll(), "CategoriaDespesaId", "DescricaoCategoriaDespesa", despesas.CategoriaDespesaId);
            return View(despesas);
        }
        public ActionResult Edit(int id)
        {


            var despesas = _despesasAppService.GetById(id);


            var despesasVM = Mapper.Map<Despesas, DespesasVM>(despesas);

            ViewBag.CategoriaDespesaId = new SelectList(_catDespesasAppService.GetAll(), "CategoriaDespesaId", "DescricaoCategoriaDespesa", despesasVM.CategoriaDespesaId);
            return View(despesasVM);
        }

        [HttpPost]
        public ActionResult Edit(DespesasVM despesas)
        {


            if (ModelState.IsValid)
            {
                

                var despesasD = Mapper.Map<DespesasVM, Despesas>(despesas);
                _despesasAppService.Update(despesasD);
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaDespesaId = new SelectList(_catDespesasAppService.GetAll(), "CategoriaDespesaId", "DescricaoCategoriaDespesa", despesas.CategoriaDespesaId);
            return View(despesas);
        }

        public ActionResult Delete(int id)
        {
            var despesas = _despesasAppService.GetById(id);
            var despesasVM = Mapper.Map<Despesas, DespesasVM>(despesas);
            return View(despesasVM);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _despesasAppService.GetById(id);
            _despesasAppService.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
