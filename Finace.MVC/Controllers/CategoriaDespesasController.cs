using AutoMapper;
using Finace.MVC.ViewModels;
using Finance.Application.Interface;
using Finance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finace.MVC.Controllers
{
    public class CategoriaDespesasController : Controller
    {

        private readonly ICategoriaDespesasAppService _catDespesasAppService;

        public CategoriaDespesasController(ICategoriaDespesasAppService catDespesasAppService)
        {
            _catDespesasAppService = catDespesasAppService;
        }


        public ActionResult Index()
        {

            var categoriaDespesas = Mapper.Map<IEnumerable<CategoriaDespesas>, IEnumerable<CategoriaDespesasVM>>(_catDespesasAppService.GetAll());
            return View(categoriaDespesas);
        }

        public ActionResult Details(int id)
        {
            var categoriaDespesas = _catDespesasAppService.GetById(id);
            var categoriaDespesasVM = Mapper.Map<CategoriaDespesas, CategoriaDespesasVM>(categoriaDespesas);
            return View(categoriaDespesasVM);

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaDespesasVM catDespesas)
        {

            if (ModelState.IsValid)
            {
                var categoriaDespesasDomain = Mapper.Map<CategoriaDespesasVM, CategoriaDespesas>(catDespesas);
                _catDespesasAppService.Add(categoriaDespesasDomain);

                return RedirectToAction("Index");
            }
            return View(catDespesas);
        }



        public ActionResult Edit(int id)
        {

            var categoriaDespesas = _catDespesasAppService.GetById(id);
            var CategoriaDespesasVM = Mapper.Map<CategoriaDespesas, CategoriaDespesasVM>(categoriaDespesas);
            return View(CategoriaDespesasVM);
        }

        // POST: CategoriaDespesas/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoriaDespesasVM categoriaDespesas)
        {
            if (ModelState.IsValid)
            {
                var categoriaDespesasDomain = Mapper.Map<CategoriaDespesasVM, CategoriaDespesas>(categoriaDespesas);
                _catDespesasAppService.Update(categoriaDespesasDomain);

                return RedirectToAction("Index");
            }
            return View(categoriaDespesas);
        }
    

        // GET: CategoriaDespesas/Delete/5
        public ActionResult Delete(int id)
        {
            var categoriaDespesas = _catDespesasAppService.GetById(id);
            var categoriaDespesasVM = Mapper.Map<CategoriaDespesas, CategoriaDespesasVM>(categoriaDespesas);
            return View(categoriaDespesasVM);
        }

        // POST: CategoriaDespesas/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var categoriaDespesas = _catDespesasAppService.GetById(id);
            _catDespesasAppService.Remove(categoriaDespesas);

            return RedirectToAction("Index");
        }
    }
}
