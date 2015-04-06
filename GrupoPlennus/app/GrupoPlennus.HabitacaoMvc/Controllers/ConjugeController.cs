using AutoMapper;
using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;

using GrupoPlennus.HabitacaoMvc.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GrupoPlennus.HabitacaoMvc.Controllers
{
    public class ConjugeController : Controller
    {
        private readonly IConjugeAppService _conjugeApp;
        private readonly ISexoAppService _sexoApp;
        private readonly INacionalidadeAppService _nacionalidadeApp;
        private readonly IEstadoCivilAppService _estadoCivilApp;
        private readonly IAtividadeAppService _atividadeApp;
        private readonly INaturalidadeAppService _naturalidadeApp;
        private readonly IGrauInstrucaoAppService _grauInstrucaoApp;
       
        
        private readonly ITipoImovelAppService _tipoImovelApp;
        private readonly ITipoVeiculoAppService _tipoVeiculoApp;
        
        
        private readonly IFaixaSalarialAppService _faixaSalarialApp;
        private readonly IRendaAppService _rendaApp;
        public ConjugeController(IConjugeAppService conjugeApp, ISexoAppService sexoApp, INacionalidadeAppService nacionalidadeApp,
            IEstadoCivilAppService estadoCivilApp, IAtividadeAppService atividadeApp,
            INaturalidadeAppService naturalidadeApp, IGrauInstrucaoAppService grauInstrucaoApp,
           
            ITipoImovelAppService tipoImovelApp, ITipoVeiculoAppService tipoVeiculoApp,
            
            IFaixaSalarialAppService faixaSalarialApp, IRendaAppService rendaApp)
        {
            _conjugeApp = conjugeApp;
            _sexoApp = sexoApp;
            _nacionalidadeApp = nacionalidadeApp;
            _estadoCivilApp = estadoCivilApp;
            _atividadeApp = atividadeApp;
            _naturalidadeApp = naturalidadeApp;
            _grauInstrucaoApp = grauInstrucaoApp;
            _tipoImovelApp = tipoImovelApp;
            _tipoVeiculoApp = tipoVeiculoApp; 
            _faixaSalarialApp = faixaSalarialApp;
            _rendaApp = rendaApp;
        }
        // GET: Conjuge
        public ActionResult Index()
        {
            if (TempData["Pessoa"] != null)
            {
                //Necessário TypeCasting pra tipos complexos.                
                var pessoa = TempData["Pessoa"] as Pessoa;

                var conjuge = _conjugeApp.BuscaPorResponsavel(pessoa.Id);
                var conjugeViewModel = Mapper.Map<IEnumerable<Conjuge>, IEnumerable<ConjugeViewModel>>(conjuge);



                return View(conjugeViewModel);
            }
            return RedirectToAction("Index", "Pessoa");
        }

        // GET: Conjuge/Details/5
        public ActionResult Details(int id)
        {
            var conjuge = _conjugeApp.GetById(id);
            var conjugeViewModel = Mapper.Map<Conjuge, ConjugeViewModel>(conjuge);
            return View(conjugeViewModel);
        }

        // GET: Conjuge/Create
        public ActionResult Create(int id)
        {


            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao");
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao");
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao");
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao");
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao");
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao");
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao");
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao");            
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao");
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao");
            ViewBag.PessoaId = id;
            return View();
        }

        // POST: Conjuge/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ConjugeViewModel conjuge)
        {
            if (ModelState.IsValid)
            {
                var conjugeDoamin = Mapper.Map<ConjugeViewModel, Conjuge>(conjuge);
                _conjugeApp.Add(conjugeDoamin);
                return RedirectToAction("Index");
            }
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", conjuge.SexoId);
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", conjuge.NacionalidadeId);
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", conjuge.EstadoCivilId);
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao", conjuge.AtividadeId);
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao", conjuge.NaturalidadeId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", conjuge.GrauInstrucaoId);
            
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao", conjuge.TipoImovelId);
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao", conjuge.TipoVeiculoId);
            
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao", conjuge.FaixaSalarialId);
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao", conjuge.FaixaSalarialId);
            return View(conjuge);
        }

        // GET: Conjuge/Edit/5
        public ActionResult Edit(int id)
        {
            var conjuge = _conjugeApp.GetById(id);
            var conjugeViewModel = Mapper.Map<Conjuge, ConjugeViewModel>(conjuge);

            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", conjugeViewModel.SexoId);
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", conjugeViewModel.NacionalidadeId);
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", conjugeViewModel.EstadoCivilId);
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao", conjugeViewModel.AtividadeId);
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao", conjugeViewModel.NaturalidadeId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", conjugeViewModel.GrauInstrucaoId);
            
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao", conjugeViewModel.TipoImovelId);
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao", conjugeViewModel.TipoVeiculoId);
            
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao", conjugeViewModel.FaixaSalarialId);
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao", conjugeViewModel.FaixaSalarialId);

            return View(conjugeViewModel);
        }

        // POST: Conjuge/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ConjugeViewModel conjuge)
        {
            if (ModelState.IsValid)
            {
                var conjugeDomain = Mapper.Map<ConjugeViewModel, Conjuge>(conjuge);
                _conjugeApp.Update(conjugeDomain);
                return RedirectToAction("Index");
            }
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", conjuge.SexoId);
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", conjuge.NacionalidadeId);
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", conjuge.EstadoCivilId);
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao", conjuge.AtividadeId);
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao", conjuge.NaturalidadeId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", conjuge.GrauInstrucaoId);
            
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao", conjuge.TipoImovelId);
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao", conjuge.TipoVeiculoId);
            
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao", conjuge.FaixaSalarialId);
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao", conjuge.FaixaSalarialId);
            return View(conjuge);
        }

        // GET: Conjuge/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Conjuge/Delete/5
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

        public ActionResult ConjugePorResponsavel(int id)
        {
            var conjuge = _conjugeApp.BuscaPorResponsavel(id).FirstOrDefault();
            var conjugeViewModel = Mapper.Map<Conjuge, ConjugeViewModel>(conjuge);
            return PartialView(conjugeViewModel);
        }
    }
}
