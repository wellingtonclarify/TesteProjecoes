using System;

namespace TesteProjecoes.Model
{
    public class CentroCusto : BaseModelWithAttr
    {
        public string Nome { get; set; }

        #region ctor
        public CentroCusto()
        {

        }

        public CentroCusto(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        #endregion
    }
}
