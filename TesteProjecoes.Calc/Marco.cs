using System;
using System.Collections.Generic;

namespace TesteProjecoes.Calc
{
    public class Marco
    {
        public DateTime Referencia { get; set; }
        public IList<Evento> Eventos { get; set; }

        #region ctor
        public Marco()
        {
            Eventos = new List<Evento>();
        }

        public Marco(DateTime referencia) : this()
        {
            Referencia = referencia;
        }
        #endregion
    }
}
