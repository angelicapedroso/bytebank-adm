using ByteBankAdm.SistemaInterno;

namespace ByteBankAdm.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000) { }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
