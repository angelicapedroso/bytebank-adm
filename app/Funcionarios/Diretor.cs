namespace ByteBankAdm.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf, double salario) : base(cpf, salario) { }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
