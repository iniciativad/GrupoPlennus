using AutoMapper;
using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;

using GrupoPlennus.HabitacaoMvc.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace GrupoPlennus.HabitacaoMvc.Controllers
{
    public class PessoaController : Controller
    {
        #region contrutor
        private readonly IEntidadeAppService _entidadeApp;
        private readonly IPessoaAppService _pessoaApp;
        private readonly ISexoAppService _sexoApp;
        private readonly INacionalidadeAppService _nacionalidadeApp;
        private readonly IEstadoCivilAppService _estadoCivilApp;
        private readonly IAtividadeAppService _atividadeApp;
        private readonly INaturalidadeAppService _naturalidadeApp;
        private readonly IGrauInstrucaoAppService _grauInstrucaoApp;
        private readonly IResidenciaAtualAppService _residenciaAtualApp;
        private readonly IDocumentosComplementaresAppService _documentosApp;
        private readonly ITipoImovelAppService _tipoImovelApp;
        private readonly ITipoVeiculoAppService _tipoVeiculoApp;
        private readonly IAplicacoesForaCaixaAppService _aplicacoesForaCaixaApp;
        private readonly IDependenteAppService _depApp;
        private readonly IFaixaSalarialAppService _faixaSalarialApp;
        private readonly IRendaAppService _rendaApp;
        public PessoaController(IEntidadeAppService entidadeApp, IPessoaAppService pessoaApp, 
            ISexoAppService sexoApp, INacionalidadeAppService nacionalidadeApp, 
            IEstadoCivilAppService estadoCivilApp, IAtividadeAppService atividadeApp,
            INaturalidadeAppService naturalidadeApp, IGrauInstrucaoAppService grauInstrucaoApp,
            IResidenciaAtualAppService residenciaAtualApp, IDocumentosComplementaresAppService documentosApp,
            ITipoImovelAppService tipoImovelApp, ITipoVeiculoAppService tipoVeiculoApp,
            IAplicacoesForaCaixaAppService aplicacoesForaCaixaApp, IDependenteAppService depApp, 
            IFaixaSalarialAppService faixaSalarialApp, IRendaAppService rendaApp)
        {
            _entidadeApp = entidadeApp;
            _pessoaApp = pessoaApp;
            _sexoApp = sexoApp;
            _nacionalidadeApp = nacionalidadeApp;
            _estadoCivilApp = estadoCivilApp;
            _atividadeApp = atividadeApp;
            _naturalidadeApp = naturalidadeApp;
            _grauInstrucaoApp = grauInstrucaoApp;
            _residenciaAtualApp = residenciaAtualApp;
            _documentosApp = documentosApp;
            _tipoImovelApp = tipoImovelApp;
            _tipoVeiculoApp = tipoVeiculoApp;
            _aplicacoesForaCaixaApp = aplicacoesForaCaixaApp;
            _depApp = depApp;
            _faixaSalarialApp = faixaSalarialApp;
            _rendaApp = rendaApp;
        }
        #endregion

        // GET: Pessoa
        public ActionResult Index()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaApp.GetAll());
            return View(pessoaViewModel);
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            return View(pessoaViewModel);
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao");
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao");
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao");
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao");
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao");
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao");
            ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.GetAll(), "Id", "Descricao");
            ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.GetAll(), "Id", "Descricao");
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao");
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao");
            ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.GetAll(), "Id", "Descricao");
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia");
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao");
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao");
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDoamin = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaApp.Add(pessoaDoamin);
                return RedirectToAction("Index");
            }
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", pessoa.SexoId);
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", pessoa.NacionalidadeId);
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", pessoa.EstadoCivilId);
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao", pessoa.AtividadeId);
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao", pessoa.NaturalidadeId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", pessoa.GrauInstrucaoId);
            ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.GetAll(), "Id", "Descricao", pessoa.ResidenciaAtualId);
            ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.GetAll(), "Id", "Descricao", pessoa.DocumentosComplementaresId);
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao", pessoa.TipoImovelId);
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao", pessoa.TipoVeiculoId);
            ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.GetAll(), "Id", "Descricao", pessoa.AplicacoesForaCaixaId);
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia", pessoa.EntidadeId);
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao",pessoa.FaixaSalarialId);
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao",pessoa.FaixaSalarialId);
            return View(pessoa);
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);

            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", pessoaViewModel.SexoId);
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", pessoaViewModel.NacionalidadeId);
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", pessoaViewModel.EstadoCivilId);
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao", pessoaViewModel.AtividadeId);
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao", pessoaViewModel.NaturalidadeId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", pessoaViewModel.GrauInstrucaoId);
            ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.GetAll(), "Id", "Descricao", pessoaViewModel.ResidenciaAtualId);
            ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.GetAll(), "Id", "Descricao", pessoaViewModel.DocumentosComplementaresId);
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao", pessoaViewModel.TipoImovelId);
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao", pessoaViewModel.TipoVeiculoId);
            ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.GetAll(), "Id", "Descricao", pessoaViewModel.AplicacoesForaCaixaId);
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia", pessoaViewModel.EntidadeId);
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao", pessoaViewModel.FaixaSalarialId);
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao", pessoaViewModel.FaixaSalarialId);

            return View(pessoaViewModel);
        }

        // POST: Pessoa/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaApp.Update(pessoaDomain);
                return RedirectToAction("Index");
            }
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", pessoa.SexoId);
            ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", pessoa.NacionalidadeId);
            ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", pessoa.EstadoCivilId);
            ViewBag.AtividadeId = new SelectList(_atividadeApp.GetAll(), "Id", "Descricao", pessoa.AtividadeId);
            ViewBag.NaturalidadeId = new SelectList(_naturalidadeApp.GetAll(), "Id", "Descricao", pessoa.NaturalidadeId);
            ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.GetAll(), "Id", "Descricao", pessoa.GrauInstrucaoId);
            ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.GetAll(), "Id", "Descricao", pessoa.ResidenciaAtualId);
            ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.GetAll(), "Id", "Descricao", pessoa.DocumentosComplementaresId);
            ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.GetAll(), "Id", "Descricao", pessoa.TipoImovelId);
            ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.GetAll(), "Id", "Descricao", pessoa.TipoVeiculoId);
            ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.GetAll(), "Id", "Descricao", pessoa.AplicacoesForaCaixaId);
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia", pessoa.EntidadeId);
            ViewBag.FaixaSalarialId = new SelectList(_faixaSalarialApp.GetAll(), "Id", "Descricao", pessoa.FaixaSalarialId);
            ViewBag.RendaId = new SelectList(_rendaApp.GetAll(), "Id", "Descricao", pessoa.FaixaSalarialId);
            return View(pessoa);
        }

        //Dependente
       
        public ActionResult Dependente(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            TempData["Pessoa"] = pessoa;
            TempData["PessoaId"] = pessoa.Id;
            return RedirectToAction("Index", "Dependente");
        }

        public ActionResult Conjuge(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            TempData["Pessoa"] = pessoa;
            TempData["PessoaId"] = pessoa.Id;
            return RedirectToAction("Index", "Conjuge");
        }
        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            return View(pessoaViewModel);
        }

        // POST: Pessoa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            _pessoaApp.Remove(pessoa);
            return RedirectToAction("Index");
        }
    }
}
