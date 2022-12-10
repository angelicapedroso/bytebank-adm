namespace ByteBankAdm.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf) { }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
