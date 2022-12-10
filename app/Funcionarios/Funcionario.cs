namespace ByteBankAdm.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; } = "";
        public string Cpf { get; private set; } = "";
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf)
        {
            TotalDeFuncionarios++;
            Cpf = cpf;
        }
    }
}