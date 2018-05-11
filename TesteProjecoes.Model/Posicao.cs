using System;

namespace TesteProjecoes.Model
{
    public class Posicao : BaseModelWithAttr
    {
        public string Nome { get; set; }
        public int CentroCustoId { get; set; }
        public int QtdHoras { get; set; }
        public bool IsPool => QtdHoras > 0;

        #region ctor
        public Posicao()
        {

        }

        public Posicao(int id, string nome, int centroCustoId) : this(id, nome, centroCustoId, 0)
        {

        }

        public Posicao(int id, string nome, int centroCustoId, int qtdHoras)
        {
            Id = id;
            Nome = nome;
            CentroCustoId = centroCustoId;
            QtdHoras = qtdHoras;
        }

        #endregion
    }
}
