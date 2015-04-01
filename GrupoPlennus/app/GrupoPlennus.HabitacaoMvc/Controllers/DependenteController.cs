using AutoMapper;
using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;

using GrupoPlennus.HabitacaoMvc.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GrupoPlennus.HabitacaoMvc.Controllers
{
    public class DependenteController : Controller
    {
        private readonly IDependenteAppService _depApp;
        private readonly ISexoAppService _sexoApp;
        private readonly IGrauInstrucaoAppService _grauInstrucaoApp;
        public DependenteController(IDependenteAppService depApp, ISexoAppService sexoApp, IGrauInstrucaoAppService grauInstrucaoApp)
        {
            _depApp = depApp;
            _grauInstrucaoApp = grauInstrucaoApp;
            _sexoApp = sexoApp;
        }
        // GET: Dependente
        public ActionResult Index()
        {
            if (TempData["Pessoa"] != null)
            {
                //Necessário TypeCasting pra tipos complexos.                
                var pessoa = TempData["Pessoa"] as Pessoa;

                var dependentes = _depApp.BuscaPorResponsavel(pessoa.Id);
                var dependentesViewModel = Mapper.Map<IEnumerable<Dependente>, IEnumerable<DependenteViewModel>>(dependentes);



                return View(dependentesViewModel);
            }
            return RedirectToAction("Index", "Pessoa");


        }

        // GET: Dependente/Details/5
        public ActionResult Details(int id)
        {

            var dependente = _depApp.GetById(id);
            var dependenteViewModel = Mapper.Map<Dependente, DependenteViewModel>(dependente);
            return View(dependenteViewModel);
        }

        // GET: Dependente/Create
        public ActionResult Create(int id)
        {
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao");
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao");
            ViewBag.PessoaId = id;
            return View();
        }

        // POST: Dependente/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DependenteViewModel dependente, int PessoaId)
        {
            if (ModelState.IsValid)
            {
                var dependenteDomain = Mapper.Map<DependenteViewModel, Dependente>(dependente);
                dependenteDomain.PessoaId = PessoaId;
                _depApp.Add(dependenteDomain);
                return RedirectToAction("Index", "Dependente", new { id = PessoaId });
            }
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", dependente.SexoId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", dependente.GrauInstrucaoId);
            return View(dependente);
        }

        // GET: Dependente/Edit/5
        public ActionResult Edit(int id)
        {
            var dependente = _depApp.GetById(id);
            var dependenteViewModel = Mapper.Map<Dependente, DependenteViewModel>(dependente);

            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", dependenteViewModel.SexoId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", dependenteViewModel.GrauInstrucaoId);


            return View(dependenteViewModel);
        }

        // POST: Dependente/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DependenteViewModel dependente)
        {
            if (ModelState.IsValid)
            {
                var dependenteDomain = Mapper.Map<DependenteViewModel, Dependente>(dependente);
                _depApp.Update(dependenteDomain);
                return RedirectToAction("Index");
            }
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", dependente.SexoId);
          
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", dependente.GrauInstrucaoId);
           
            return View(dependente);
        }

        // GET: Dependente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dependente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
