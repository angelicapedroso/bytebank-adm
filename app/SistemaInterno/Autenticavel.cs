using ByteBankAdm.Funcionarios;

namespace ByteBankAdm.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(string cpf, double salario) : base(cpf, salario) { }

        public string Senha { get; set; } = "";

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
