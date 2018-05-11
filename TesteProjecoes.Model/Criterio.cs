namespace TesteProjecoes.Model
{
    public class Criterio : BaseModel
    {
        public int RegraId { get; set; }
        public string Formula { get; set; }

        #region ctor
        public Criterio()
        {

        }

        public Criterio(int id, int regraId, string formula)
        {
            Id = id;
            RegraId = regraId;
            Formula = formula;
        }
        #endregion
    }
}
