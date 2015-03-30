using System.Collections.Generic;

namespace GrupoPlennus.Domain.Listas
{
    public class DocumentosComplementares
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<DocumentosComplementares> Lista()
        {
            return new List<DocumentosComplementares>
            {
                new DocumentosComplementares{Id=1,Descricao="Água e Esgoto, Energia Elétrica, Telefone"},
                new DocumentosComplementares{Id=2,Descricao="Previdência, Consóricio, segura, Plano de Saúde"},
                new DocumentosComplementares{Id=3,Descricao="Não Apresentou Documentos"},
                new DocumentosComplementares{Id=4,Descricao="Fatura Cartão, Extrato C/C"},
                new DocumentosComplementares{Id=5,Descricao="TV a cabo, Internet, Assin. Revistas e jornais"}
            };
        }
    }
}
