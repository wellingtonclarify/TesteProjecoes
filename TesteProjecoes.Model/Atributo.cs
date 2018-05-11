namespace TesteProjecoes.Model
{
    public class Atributo : BaseModel
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int TabelaId { get; set; }
        public int TipoId { get; set; }
    }
}
