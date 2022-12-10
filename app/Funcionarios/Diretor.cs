namespace ByteBankAdm.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario;
        }
    }
}
