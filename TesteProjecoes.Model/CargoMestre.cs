using Newtonsoft.Json;
using System;

namespace TesteProjecoes.Model
{
    public class CargoMestre : BaseModelWithAttr
    {
        public string Nome { get; set; }

        public int CargoNivel1Id { get; set; }
        public int CargoNivel2Id { get; set; }
        public int CargoNivel3Id { get; set; }
        public int CargoNivel4Id { get; set; }
        public int CargoNivel5Id { get; set; }

        [JsonIgnore]
        public Cargo CargoNivel1 { get; set; }
        [JsonIgnore]
        public Cargo CargoNivel2 { get; set; }
        [JsonIgnore]
        public Cargo CargoNivel3 { get; set; }
        [JsonIgnore]
        public Cargo CargoNivel4 { get; set; }
        [JsonIgnore]
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
