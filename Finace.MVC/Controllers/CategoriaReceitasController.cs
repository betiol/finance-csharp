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
    public class CategoriaReceitasController : Controller
    {
        private readonly ICategoriaReceitasAppService _categoriaReceitasService;


        public CategoriaReceitasController(ICategoriaReceitasAppService categoriaReceitasService)
        {
            _categoriaReceitasService = categoriaReceitasService;
        }

        public ActionResult Index()
        {
            var categoriaReceitas = Mapper.Map<IEnumerable<CategoriaReceitas>, IEnumerable<CategoriaReceitasVM>>(_categoriaReceitasService.GetAll());
            return View(categoriaReceitas);
        }

        public ActionResult Details(int id)
        {
            var categoriaReceitas = _categoriaReceitasService.GetById(id);
            var categoriaReceitasVM = Mapper.Map<CategoriaReceitas, CategoriaReceitasVM>(categoriaReceitas);
            return View(categoriaReceitasVM);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriaReceitasVM categoriaReceitas)
        {
            if(ModelState.IsValid)
            {
                var categoriaReceitasDomain = Mapper.Map<CategoriaReceitasVM, CategoriaReceitas>(categoriaReceitas);
                _categoriaReceitasService.Add(categoriaReceitasDomain);

                return RedirectToAction("Index");
            }
            return View(categoriaReceitas);
        }

        public ActionResult Edit(int id)
        {
            var categoriaReceitas = _categoriaReceitasService.GetById(id);
            var categoriaReceitasVM = Mapper.Map<CategoriaReceitas, CategoriaReceitasVM>(categoriaReceitas);
            return View(categoriaReceitasVM);
        }

        [HttpPost]
        public ActionResult Edit(CategoriaReceitasVM categoriaReceitas)
        {
          if(ModelState.IsValid)
            {
                var categoriaReceitasDomain = Mapper.Map<CategoriaReceitasVM, CategoriaReceitas>(categoriaReceitas);
                _categoriaReceitasService.Update(categoriaReceitasDomain);

                return RedirectToAction("Index");
            }
            return View(categoriaReceitas);
        }

        public ActionResult Delete(int id)
        {
            var categoriaReceitas = _categoriaReceitasService.GetById(id);
            var categoriaReceitasVM = Mapper.Map<CategoriaReceitas, CategoriaReceitasVM>(categoriaReceitas);
            return View(categoriaReceitasVM);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var categoriaReceitas = _categoriaReceitasService.GetById(id);
            _categoriaReceitasService.Remove(categoriaReceitas);

            return RedirectToAction("Index");
        }
    }
}
