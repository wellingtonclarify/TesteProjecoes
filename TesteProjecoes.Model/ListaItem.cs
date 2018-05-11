namespace TesteProjecoes.Model
{
    public class ListaItem : BaseModel
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public int TipoId { get; set; }
    }
}
