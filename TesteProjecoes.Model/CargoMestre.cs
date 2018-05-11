using System;

namespace TesteProjecoes.Model
{
    public class CargoMestre : BaseModelWithAttr
    {
        public string Nome { get; set; }
        public Cargo CargoNivel1 { get; set; }
        public Cargo CargoNivel2 { get; set; }
        public Cargo CargoNivel3 { get; set; }
        public Cargo CargoNivel4 { get; set; }
        public Cargo CargoNivel5 { get; set; }

        #region ctor
        public CargoMestre()
        {

        }

        public CargoMestre(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        #endregion
    }
}
