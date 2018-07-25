﻿using System;
using System.Linq;

namespace TesteProjecoes.Calc.Extensions
{
    public static class MarcoExtensions
    {
        public static void AdicionaEvento(this Marco marco, enumTipoEvento tipo)
        {
            if (marco.Eventos.Any(x => x.Tipo == tipo))
            {
                throw new Exception("Evento já existente neste marco.");
            }

            marco.Eventos.Add(tipo);
        }
        

    }
}
