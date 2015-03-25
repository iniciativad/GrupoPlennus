using AutoMapper;
using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.HabitacaoMvc.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GrupoPlennus.HabitacaoMvc.Controllers
{
    public class EntidadeMasterController : Controller
    {
        private readonly IEntidadeMasterAppService _entidadeMasterApp;
        public EntidadeMasterController(IEntidadeMasterAppService entidadeMasterApp)
        {
            _entidadeMasterApp = entidadeMasterApp;
        }
        // GET: EntidadeMaster
        public ActionResult Index()
        {
            var entidadeMasterViewModel = Mapper.Map<IEnumerable<EntidadeMaster>, IEnumerable<EntidadeMasterViewModel>>(_entidadeMasterApp.GetAll());
            return View(entidadeMasterViewModel);
        }

        // GET: EntidadeMaster/Details/5
        public ActionResult Details(int id)
        {
            var entidadeMaster = _entidadeMasterApp.GetById(id);
            var entidadeViewModel = Mapper.Map<EntidadeMaster, EntidadeMasterViewModel>(entidadeMaster);
            return View(entidadeViewModel);
        }

        // GET: EntidadeMaster/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntidadeMaster/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EntidadeMasterViewModel entidadeMaster)
        {
            if (ModelState.IsValid)
            {
                var entidadeMasterDomain = Mapper.Map<EntidadeMasterViewModel, EntidadeMaster>(entidadeMaster);
                _entidadeMasterApp.Add(entidadeMasterDomain);
                return RedirectToAction("Index");
            }
            return View(entidadeMaster);
        }

        // GET: EntidadeMaster/Edit/5
        public ActionResult Edit(int id)
        {
            var entidadeMaster = _entidadeMasterApp.GetById(id);
            var entidadeViewModel = Mapper.Map<EntidadeMaster, EntidadeMasterViewModel>(entidadeMaster);
            return View(entidadeViewModel);
        }

        // POST: EntidadeMaster/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EntidadeMasterViewModel entidadeMaster)
        {
            if (ModelState.IsValid)
            {
                var entidadeMasterDomain = Mapper.Map<EntidadeMasterViewModel, EntidadeMaster>(entidadeMaster);
                _entidadeMasterApp.Update(entidadeMasterDomain);
                return RedirectToAction("Index");
            }
            return View(entidadeMaster);
        }

        // GET: EntidadeMaster/Delete/5
        public ActionResult Delete(int id)
        {
            var entidadeMaster = _entidadeMasterApp.GetById(id);
            var entidadeViewModel = Mapper.Map<EntidadeMaster, EntidadeMasterViewModel>(entidadeMaster);
            return View(entidadeViewModel);
        }

        // POST: EntidadeMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var entidade = _entidadeMasterApp.GetById(id);
            _entidadeMasterApp.Remove(entidade);
            return RedirectToAction("Index");
        }
    }
}
