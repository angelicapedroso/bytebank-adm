namespace ByteBankAdm.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; } = "";
        public string Cpf { get; private set; } = "";
        public double Salario { get; protected set; }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            TotalDeFuncionarios++;
            Cpf = cpf;
            Salario = salario;
        }

        public virtual void AumentarSalario()
        {
            this.Salario *= 1.1;
        }
    }
}