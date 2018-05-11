using System;

namespace TesteProjecoes.Model
{
    public class Funcionario : BaseModelWithAttr
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public decimal Salario { get; set; }
        public DateTime? Admissao { get; set; }
        public DateTime? Rescisao { get; set; }
        public bool Ativo => Admissao != null && Rescisao == null;
        public Cargo Cargo { get; set; }

        public int Idade => (int)(DateTime.Today.Subtract(Nascimento).TotalDays / 365);

        #region ctor
        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, DateTime nascimento, string sexo, decimal salario, Cargo cargo, DateTime admissao)
            : this(id, nome, nascimento, sexo, salario, cargo)
        {
            Admissao = admissao;
        }

        public Funcionario(int id, string nome, DateTime nascimento, string sexo, decimal salario, Cargo cargo)
        {
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
            Sexo = sexo;
            Salario = salario;
            Cargo = cargo;
        }
        #endregion
    }
}
