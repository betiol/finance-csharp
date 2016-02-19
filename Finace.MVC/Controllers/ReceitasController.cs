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
    public class ReceitasController : Controller
    {

        private readonly IReceitasAppService _receitasApp;
        private readonly ICategoriaReceitasAppService _catReceitasApp;

        public ReceitasController(IReceitasAppService receitasApp, ICategoriaReceitasAppService catReceitasApp)
        {
            _receitasApp = receitasApp;
            _catReceitasApp = catReceitasApp;

        }

        //public ActionResult Filtrar(Receitas filtroReceitas)
        //{
        //    var query = filtroReceitas


        //}

        public ActionResult Index(string filtro)
        {


            var receitasVM = Mapper.Map<IEnumerable<Receitas>, IEnumerable<ReceitasVM>>(_receitasApp.GetAll().ToList());
            return View(receitasVM);
        }

        public ActionResult Details(int id)
        {
            var receitas = _receitasApp.GetById(id);
            var receitasVM = Mapper.Map<Receitas, ReceitasVM>(receitas);
            return View(receitasVM);
        }

        public ActionResult Create()
        {
            ViewBag.CategoriaReceitasId = new SelectList(_catReceitasApp.GetAll(), "CategoriaReceitasId", "DescricaoCategoriaReceitas");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ReceitasVMCadastrar receitas)
        {
            if (ModelState.IsValid)
            {
                var receitasDomain = Mapper.Map<ReceitasVMCadastrar, Receitas>(receitas);
                _receitasApp.Add(receitasDomain);
                return RedirectToAction("Index");

            }
            ViewBag.CategoriaReceitasId = new SelectList(_catReceitasApp.GetAll(), "CategoriaReceitasId", "DescricaoCategoriaReceitas", receitas.CategoriaReceitasId);
            return View(receitas);
        }

        public ActionResult Edit(int id)
        {
            var receitas = _receitasApp.GetById(id);
            var receitasVM = Mapper.Map<Receitas, ReceitasVMAlterar>(receitas);
            ViewBag.CategoriaReceitasId = new SelectList(_catReceitasApp.GetAll(), "CategoriaReceitasId", "DescricaoCategoriaReceitas", receitas.CategoriaReceitasId);
            return View(receitasVM);
        }

        [HttpPost]
        public ActionResult Edit(ReceitasVMAlterar receitas)
        {
            if (ModelState.IsValid)
            {
                var receitasDomain = Mapper.Map<ReceitasVMAlterar, Receitas>(receitas);
                _receitasApp.Update(receitasDomain);
                return RedirectToAction("Index");
            }
            ViewBag.CategoriaReceitasId = new SelectList(_catReceitasApp.GetAll(), "CategoriaReceitasId", "DescricaoCategoriaReceitas", receitas.CategoriaReceitasId);
            return View(receitas);
        }

        public ActionResult Delete(int id)
        {
            var cliente = _receitasApp.GetById(id);
            var clienteVM = Mapper.Map<Receitas, ReceitasVM>(cliente);
            return View(clienteVM);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _receitasApp.GetById(id);
            _receitasApp.Remove(cliente);

            return RedirectToAction("Index");
        }
    }
}
