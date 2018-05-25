using System;

namespace TesteProjecoes.Model
{
    public class TabelaAtributo : BaseModel
    {
        public int TabelaId { get; set; }
        public int RegistroId { get; set; }
        public int AtributoId { get; set; }
        public object Valor { get; set; }

        public TabelaAtributo()
        {

        }

        public TabelaAtributo(int registroId, int atributoId, object valor)
        {
            RegistroId = registroId;
            AtributoId = atributoId;
            Valor = valor;
        }
    }
}
