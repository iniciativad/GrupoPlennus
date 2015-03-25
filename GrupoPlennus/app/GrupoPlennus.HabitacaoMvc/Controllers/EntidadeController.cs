using AutoMapper;
using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;

using GrupoPlennus.HabitacaoMvc.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GrupoPlennus.HabitacaoMvc.Controllers
{
    public class EntidadeController : Controller
    {
        private readonly IEntidadeAppService _entidadeApp;
        private readonly IEntidadeMasterAppService _entidadeMasterApp;
        private readonly IEntidadeTiposAppService _entidadeTiposApp;

        public EntidadeController(IEntidadeAppService entidadeApp, IEntidadeMasterAppService entidadeMasterApp,IEntidadeTiposAppService entidadeTiposApp)
        {
            _entidadeApp = entidadeApp;
            _entidadeMasterApp = entidadeMasterApp;
            _entidadeTiposApp = entidadeTiposApp;
            
        }
        // GET: Entidade
        public ActionResult Index()
        {
            var entidadeViewModel = Mapper.Map<IEnumerable<Entidade>,IEnumerable<EntidadeViewModel>>(_entidadeApp.GetAll());
            return View(entidadeViewModel);
        }

        // GET: Entidade/Details/5
        public ActionResult Details(int id)
        {
            var entidade = _entidadeApp.GetById(id);
            var entidadeViewModel = Mapper.Map<Entidade, EntidadeViewModel>(entidade);
            return View(entidadeViewModel);
        }

        // GET: Entidade/Create
        public ActionResult Create()
        {
            ViewBag.EntidadeMasterId = new SelectList(_entidadeMasterApp.GetAll(), "Id", "NomeFantasia");
            ViewBag.TipoEntidadeId = new SelectList(_entidadeTiposApp.GetAll(), "Id", "Descricao");
            return View();
        }

        // POST: Entidade/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntidadeViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                var entidadeDomain = Mapper.Map<EntidadeViewModel, Entidade>(entidade);
               
                _entidadeApp.Add(entidadeDomain);
                return RedirectToAction("Index");
            }
            ViewBag.EntidadeMasterId = new SelectList(_entidadeMasterApp.GetAll(), "Id", "NomeFantasia", entidade.EntidadeMasterId);
            ViewBag.TipoEntidadeId = new SelectList(_entidadeTiposApp.GetAll(), "Id", "Descricao", entidade.EntidadeTiposId);
            return View(entidade);
        }

        // GET: Entidade/Edit/5
        public ActionResult Edit(int id)
        {
            var entidade = _entidadeApp.GetById(id);          
            var entidadeViewModel = Mapper.Map<Entidade, EntidadeViewModel>(entidade);
            ViewBag.EntidadeMasterId = new SelectList(_entidadeMasterApp.GetAll(), "Id", "NomeFantasia", entidadeViewModel.EntidadeMasterId);
            ViewBag.EntidadeTipoId = new SelectList(_entidadeTiposApp.GetAll(), "Id", "Descricao", entidadeViewModel.EntidadeTiposId);

            return View(entidadeViewModel);
        }

        // POST: Entidade/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EntidadeViewModel entidade)
        {
           
            if (ModelState.IsValid)
            {
                var entidadeDomain = Mapper.Map<EntidadeViewModel, Entidade>(entidade);
                _entidadeApp.Update(entidadeDomain);
                return RedirectToAction("Index");
            }
            ViewBag.EntidadeMasterId = new SelectList(_entidadeMasterApp.GetAll(), "Id", "NomeFantasia", entidade.EntidadeMasterId);
            ViewBag.EntidadeTipoId = new SelectList(_entidadeTiposApp.GetAll(), "Id", "Descricao", entidade.EntidadeTiposId);
            return View(entidade);
        }

        // GET: Entidade/Delete/5
        public ActionResult Delete(int id)
        {
            var entidade = _entidadeApp.GetById(id);
            var entidadeViewModel = Mapper.Map<Entidade, EntidadeViewModel>(entidade);
            return View(entidadeViewModel);
        }

        // POST: Entidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var entidade = _entidadeApp.GetById(id);
            _entidadeApp.Remove(entidade);
            return RedirectToAction("Index");
        }
    }
}
