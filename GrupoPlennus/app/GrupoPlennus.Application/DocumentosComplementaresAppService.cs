using GrupoPlennus.Application.Interfaces;
using GrupoPlennus.Domain.Entities;
using GrupoPlennus.Domain.Interfaces.Services;
namespace GrupoPlennus.Application
{
   public class DocumentosComplementaresAppService :AppServiceBase<DocumentosComplementares>,IDocumentosComplementaresAppService
    {
        private readonly IDocumentosComplementaresService _docsService;
        public DocumentosComplementaresAppService(IDocumentosComplementaresService docsService)
            :base(docsService)
        {
            _docsService = docsService;
        }
    }
}
