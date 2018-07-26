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

            int id = 0;
            if (cargo.CargoMestre.CargoNivel1Id == cargo.Id)
                id = cargo.CargoMestre.CargoNivel2Id.Value;
            else if (cargo.CargoMestre.CargoNivel2Id == cargo.Id)
                id = cargo.CargoMestre.CargoNivel3Id.Value;
            else if (cargo.CargoMestre.CargoNivel3Id == cargo.Id)
                id = cargo.CargoMestre.CargoNivel4Id.Value;
            else if (cargo.CargoMestre.CargoNivel4Id == cargo.Id)
                id = cargo.CargoMestre.CargoNivel5Id.Value;
            else
                return null;

            using (var context = new Context())
            {
                return context.Cargo.GetById(id);
            }
        }

        public static int ObterQtdPossivelPromocao(this Cargo cargo)
        {
            if (cargo.CargoMestre == null)
                throw new Exception("Cargo-meste não localizado.");
            
            if (cargo.CargoMestre.CargoNivel1Id == cargo.Id)
                return 4;
            else if (cargo.CargoMestre.CargoNivel2Id == cargo.Id)
                return 3;
            else if (cargo.CargoMestre.CargoNivel3Id == cargo.Id)
                return 2;
            else if (cargo.CargoMestre.CargoNivel4Id == cargo.Id)
                return 1;

            return 0;
        }

        public static bool PodeSubirCargo(this Cargo cargo)
        {
            return ObterCargoSuperior(cargo) != null;
        }
    }
}
