using System;
using System.Collections.Generic;
using System.Linq;
using TesteProjecoes.Model.Extensions;

namespace TesteProjecoes.Model
{
    public class Context : IDisposable
    {
        public IList<Atributo> Atributo { get; set; }
        public IList<CargoMestre> CargoMestre { get; set; }
        public IList<Cargo> Cargo { get; set; }
        public IList<Criterio> Criterio { get; set; }
        public IList<CentroCusto> CentroCusto { get; set; }
        public IList<Funcionario> Funcionario { get; set; }
        public IList<ListaItem> ListaItem { get; set; }
        public IList<Posicao> Posicao { get; set; }
        public IList<Regra> Regra { get; set; }
        public IList<Tabela> Tabela { get; set; }
        public IList<TabelaAtributo> TabelaAtributo { get; set; }
        public IList<TipoAtributo> TipoAtributo { get; set; }

        public Context()
        {
            this.CentroCusto = new[]
            {
                new CentroCusto(1, "Administrativo - SP"),
                new CentroCusto(2, "Administrativo - RJ"),
            }.ToList();

            this.Posicao = new[]
            {
                new Posicao(1, "Gerente", 1),
                new Posicao(2, "Coordenador", 1),
                new Posicao(3, "Analista", 1),
                new Posicao(4, "Programador", 1),
                new Posicao(5, "Pool", 1, 160),
            }.ToList();

            var cm1 = new CargoMestre(1, "Gerente");
            var cm2 = new CargoMestre(2, "Coordenador");
            var cm3 = new CargoMestre(3, "Analista");
            var cm4 = new CargoMestre(4, "Programador");

            this.CargoMestre = new[]
            {
                cm1, cm2, cm3, cm4
            }.ToList();

            this.Cargo = new[]
            {
                new Cargo(01, "Gerente TR", 3087.40M, cm1),
                new Cargo(02, "Gerente JR", 4013.62M, cm1),
                new Cargo(03, "Gerente PL", 5217.71M, cm1),
                new Cargo(04, "Gerente SR", 6783.02M, cm1),
                new Cargo(05, "Gerente MA", 8817.93M, cm1),

                new Cargo(06, "Coordenador TR", 3087.40M, cm2),
                new Cargo(07, "Coordenador JR", 4013.62M, cm2),
                new Cargo(08, "Coordenador PL", 5217.71M, cm2),
                new Cargo(09, "Coordenador SR", 6783.02M, cm2),
                new Cargo(10, "Coordenador MA", 8817.93M, cm2),

                new Cargo(11, "Analista TR", 3087.40M, cm3),
                new Cargo(12, "Analista JR", 4013.62M, cm3),
                new Cargo(13, "Analista PL", 5217.71M, cm3),
                new Cargo(14, "Analista SR", 6783.02M, cm3),
                new Cargo(15, "Analista MA", 8817.93M, cm3),

                new Cargo(16, "Programador TR", 3087.40M, cm4),
                new Cargo(17, "Programador JR", 4013.62M, cm4),
                new Cargo(18, "Programador PL", 5217.71M, cm4),
                new Cargo(19, "Programador SR", 6783.02M, cm4),
                new Cargo(20, "Programador MA", 8817.93M, cm4),
            }.ToList();

            cm1.CargoNivel1 = Cargo.GetById(01);
            cm1.CargoNivel2 = Cargo.GetById(02);
            cm1.CargoNivel3 = Cargo.GetById(03);
            cm1.CargoNivel4 = Cargo.GetById(04);
            cm1.CargoNivel5 = Cargo.GetById(05);
            cm2.CargoNivel1 = Cargo.GetById(06);
            cm2.CargoNivel2 = Cargo.GetById(07);
            cm2.CargoNivel3 = Cargo.GetById(08);
            cm2.CargoNivel4 = Cargo.GetById(09);
            cm2.CargoNivel5 = Cargo.GetById(10);
            cm3.CargoNivel1 = Cargo.GetById(11);
            cm3.CargoNivel2 = Cargo.GetById(12);
            cm3.CargoNivel3 = Cargo.GetById(13);
            cm3.CargoNivel4 = Cargo.GetById(14);
            cm3.CargoNivel5 = Cargo.GetById(15);
            cm4.CargoNivel1 = Cargo.GetById(16);
            cm4.CargoNivel2 = Cargo.GetById(17);
            cm4.CargoNivel3 = Cargo.GetById(18);
            cm4.CargoNivel4 = Cargo.GetById(19);
            cm4.CargoNivel5 = Cargo.GetById(20);

            this.Funcionario = new[]
            {
                new Funcionario(1, "Wellington", new DateTime(1992, 3, 6), "M", 5000.00M, Cargo.GetById(5), DateTime.Today),
                new Funcionario(2, "Leonardo", new DateTime(2002, 3, 6), "M", 900.00M, Cargo.GetById(8), DateTime.Today),
                new Funcionario(3, "Bianca", new DateTime(1992, 3, 6), "F", 5000.00M, Cargo.GetById(13), DateTime.Today),
                new Funcionario(4, "Luiza", new DateTime(2002, 3, 6), "F", 900.00M, Cargo.GetById(18)),
            }.ToList();

            var c1 = new Criterio(1, 1, "Sexo = 'M'");
            var c2 = new Criterio(2, 1, "Idade >= 16 And Idade <= 17");
            //var c3 = new Criterio(3, 1, "Ativo = true");
            var c3 = new Criterio(3, 1, "Admissao IS NOT NULL");
            var c4 = new Criterio(4, 1, "Rescisao IS NULL");

            var c5 = new Criterio(5, 2, "Sexo = 'F'");
            var c6 = new Criterio(6, 2, "Idade IN (16,17)");
            //var c7 = new Criterio(7, 2, "Ativo = true");
            var c7 = new Criterio(7, 2, "Admissao IS NOT NULL");
            var c8 = new Criterio(8, 2, "Rescisao IS NULL");

            var c9 = new Criterio(9, 3, "IsPool = true");
            
            this.Criterio = new[]
            {
                c1, c2, c3, c4, c5, c6, c7, c8, c9
            }.ToList();

            this.Regra = new[]
            {
                new Regra(1, "SalarioBase * 0.10") { Criterios = new [] { c1, c2, c3, c4}.ToList() },
                new Regra(2, "SalarioBase * 0.11") { Criterios = new [] { c5, c6, c7, c8}.ToList() },
                new Regra(3, "QtdHoras * 50") { Criterios = new [] { c9 }.ToList() },
            }.ToList();

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Context() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
