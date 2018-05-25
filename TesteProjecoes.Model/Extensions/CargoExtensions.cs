using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteProjecoes.Model.Extensions
{
    public static class CargoExtensions
    {
        public static Cargo ObterCargoSuperior(this Cargo cargo)
        {
            if (cargo.CargoMestre == null)
                throw new Exception("Cargo-meste não localizado.");

            if (cargo.CargoMestre.CargoNivel1.Id == cargo.Id)
                return cargo.CargoMestre.CargoNivel2;
            else if (cargo.CargoMestre.CargoNivel2.Id == cargo.Id)
                return cargo.CargoMestre.CargoNivel3;
            else if (cargo.CargoMestre.CargoNivel3.Id == cargo.Id)
                return cargo.CargoMestre.CargoNivel4;
            else if (cargo.CargoMestre.CargoNivel4.Id == cargo.Id)
                return cargo.CargoMestre.CargoNivel5;

            return null;
        }

        public static bool PodeSubirCargo(this Cargo cargo)
        {
            return ObterCargoSuperior(cargo) != null;
        }
    }
}
