using System.Collections.Generic;

namespace TesteProjecoes.Model
{
    public class Regra : BaseModel
    {
        public string Formula { get; set; }
        public IList<Criterio> Criterios { get; set; }

        #region ctor
        public Regra()
        {

        }

        public Regra(int id, string formula)
        {
            Id = id;
            Formula = formula;
        }
        #endregion
    }
}
