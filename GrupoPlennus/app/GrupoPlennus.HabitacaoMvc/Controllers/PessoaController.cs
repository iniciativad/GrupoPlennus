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
        private readonly IEntidadeAppService _entidadeApp;
        private readonly IPessoaAppService _pessoaApp;
        private readonly ISexoAppService _sexoApp;
        private readonly Nacionalidade _nacionalidadeApp;
        private readonly EstadoCivil _estadoCivilApp;
        private readonly Atividade _atividadeApp;
        private readonly Naturalidade _ufApp;
        private readonly GrauInstrucao _grauInstrucaoApp;
        private readonly ResidenciaAtual _residenciaAtualApp;
        private readonly DocumentosComplementares _documentosApp;
        private readonly TipoImovel _tipoImovelApp;
        private readonly TipoVeiculo _tipoVeiculoApp;
        private readonly AplicacoesForaCaixa _aplicacoesForaCaixaApp;
        public PessoaController(IEntidadeAppService entidadeApp, IPessoaAppService pessoaApp, ISexoAppService sexoApp,
            Nacionalidade nacionalidadeApp, EstadoCivil estadoCivilApp, Atividade atividadeApp, Naturalidade ufApp, GrauInstrucao grauInstrucaoApp,
            ResidenciaAtual residenciaAtualApp, DocumentosComplementares documentosApp, TipoImovel tipoImovelApp, TipoVeiculo tipoVeiculoApp,
            AplicacoesForaCaixa aplicacoesForaCaixaApp)
        {
            _entidadeApp = entidadeApp;
            _pessoaApp = pessoaApp;
            _sexoApp = sexoApp;
            _nacionalidadeApp = nacionalidadeApp;
            _estadoCivilApp = estadoCivilApp;
            _atividadeApp = atividadeApp;
            _ufApp = ufApp;
            _grauInstrucaoApp = grauInstrucaoApp;
            _residenciaAtualApp = residenciaAtualApp;
            _documentosApp = documentosApp;
            _tipoImovelApp = tipoImovelApp;
            _tipoVeiculoApp = tipoVeiculoApp;
            _aplicacoesForaCaixaApp = aplicacoesForaCaixaApp;
        }
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
            //ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao");
            //ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao");
            //ViewBag.AtividadeId = new SelectList(_atividadeApp.Lista(), "Id", "Descricao");
            //ViewBag.NaturalidadeId = new SelectList(_ufApp.GetAll(), "Id", "Descricao");
            //ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.Lista(), "Id", "Descricao");
            //ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.Lista(), "Id", "Descricao");
            //ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.Lista(), "Id", "Descricao");
            //ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.Lista(), "Id", "Descricao");
            //ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.Lista(), "Id", "Descricao");
            //ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.Lista(), "Id", "Descricao");
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia");
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
            //ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", pessoa.NacionalidadeId);
            //ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", pessoa.EstadoCivilId);
            //ViewBag.AtividadeId = new SelectList(_atividadeApp.Lista(), "Id", "Descricao", pessoa.AtividadeId);
            //ViewBag.NaturalidadeId = new SelectList(_ufApp.GetAll(), "Id", "Descricao", pessoa.NaturalidadeId);
            //ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.Lista(), "Id", "Descricao", pessoa.GrauInstrucaoId);
            //ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.Lista(), "Id", "Descricao", pessoa.ResidenciaAtualId);
            //ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.Lista(), "Id", "Descricao",pessoa.DocumentosComplementaresId);
            //ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.Lista(), "Id", "Descricao",pessoa.TipoImovelId);
            //ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.Lista(), "Id", "Descricao",pessoa.TipoVeiculoId);
            //ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.Lista(), "Id", "Descricao",pessoa.AplicacoesForaCaixaId);
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia", pessoa.EntidadeId);
            return View(pessoa);
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            ViewBag.SexoId = new SelectList(_sexoApp.GetAll(), "Id", "Descricao", pessoaViewModel.SexoId);
            //ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", pessoaViewModel.NacionalidadeId);
            //ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", pessoaViewModel.EstadoCivilId);
            //ViewBag.AtividadeId = new SelectList(_atividadeApp.Lista(), "Id", "Descricao", pessoaViewModel.AtividadeId);
            //ViewBag.NaturalidadeId = new SelectList(_ufApp.GetAll(), "Id", "Descricao", pessoaViewModel.NaturalidadeId);
            //ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.Lista(), "Id", "Descricao", pessoaViewModel.GrauInstrucaoId);
            //ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.Lista(), "Id", "Descricao", pessoaViewModel.ResidenciaAtualId);
            //ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.Lista(), "Id", "Descricao", pessoaViewModel.DocumentosComplementaresId);
            //ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.Lista(), "Id", "Descricao", pessoaViewModel.TipoImovelId);
            //ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.Lista(), "Id", "Descricao", pessoaViewModel.TipoVeiculoId);
            //ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.Lista(), "Id", "Descricao", pessoaViewModel.AplicacoesForaCaixaId);
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia", pessoaViewModel.EntidadeId);

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
            //ViewBag.NacionalidadeId = new SelectList(_nacionalidadeApp.GetAll(), "Id", "Descricao", pessoa.NacionalidadeId);
            //ViewBag.EstadoCivilId = new SelectList(_estadoCivilApp.GetAll(), "Id", "Descricao", pessoa.EstadoCivilId);
            //ViewBag.AtividadeId = new SelectList(_atividadeApp.Lista(), "Id", "Descricao", pessoa.AtividadeId);
            //ViewBag.NaturalidadeId = new SelectList(_ufApp.GetAll(), "Id", "Descricao", pessoa.NaturalidadeId);
            //ViewBag.GrauInstrucaoId = new SelectList(_grauInstrucaoApp.Lista(), "Id", "Descricao", pessoa.GrauInstrucaoId);
            //ViewBag.ResidenciaAtualId = new SelectList(_residenciaAtualApp.Lista(), "Id", "Descricao", pessoa.ResidenciaAtualId);
            //ViewBag.DocumentosComplementaresId = new SelectList(_documentosApp.Lista(), "Id", "Descricao", pessoa.DocumentosComplementaresId);
            //ViewBag.TipoImovelId = new SelectList(_tipoImovelApp.Lista(), "Id", "Descricao", pessoa.TipoImovelId);
            //ViewBag.TipoVeiculoId = new SelectList(_tipoVeiculoApp.Lista(), "Id", "Descricao", pessoa.TipoVeiculoId);
            //ViewBag.AplicacoesForaCaixaId = new SelectList(_aplicacoesForaCaixaApp.Lista(), "Id", "Descricao", pessoa.AplicacoesForaCaixaId);
            ViewBag.EntidadeId = new SelectList(_entidadeApp.GetAll(), "Id", "NomeFantasia", pessoa.EntidadeId);
            return View(pessoa);
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
