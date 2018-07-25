using System.Collections.Generic;

namespace TesteProjecoes.Calc.Extensions
{
    public static class EventoExtensions
    {
        public static void Add(this IList<Evento> list, enumTipoEvento tipoEvento)
        {
            list.Add(new Evento(tipoEvento));
        }
    }
}
