using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces;
using GrupoPlennus.Domain.Interfaces.Services;

namespace GrupoPlennus.Domain.Services
{
   public class DocumentosComplementaresService :ServiceBase<DocumentosComplementares>,IDocumentosComplementaresService
    {
        private readonly IDocumentosComplementaresRepository _docsRepository;
        public DocumentosComplementaresService(IDocumentosComplementaresRepository docsRepository)
            :base(docsRepository)
        {
            _docsRepository = docsRepository;
        }
    }
}
