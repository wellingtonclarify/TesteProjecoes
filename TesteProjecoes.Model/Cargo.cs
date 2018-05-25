using System;

namespace TesteProjecoes.Model
{
    public class Cargo : BaseModelWithAttr
    {
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public CargoMestre CargoMestre { get; set; }
        //public decimal? SalarioInicial => CargoMestre?.CargoNivel1?.SalarioBase;
        //public decimal? SalarioFinal => CargoMestre?.CargoNivel5?.SalarioBase;

        #region ctor
        public Cargo()
        {

        }

        public Cargo(int id, string nome, decimal salarioBase, CargoMestre cargoMestre)
        {
            Id = id;
            Nome = nome;
            SalarioBase = salarioBase;
            CargoMestre = cargoMestre;
        }
        #endregion
    }
}
