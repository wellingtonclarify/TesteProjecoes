namespace TesteProjecoes.Calc
{
    public class Evento
    {
        public enumTipoEvento Tipo { get; private set; }
        public string Motivo { get; set; }

        public Evento(enumTipoEvento tipo)
        {
            Tipo = tipo;
        }
    }

    public enum enumTipoEvento
    {
        Admissao = 1,
        Demissao = 2,
        AlteraQtdPool = 3,
        SubirCargo = 4
    }
}