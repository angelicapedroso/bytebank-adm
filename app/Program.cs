using ByteBankAdm.Funcionarios;
using ByteBankAdm.Utilitario;

Console.WriteLine("Boas vindas ao ByteBank Administração!\n");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario andre = new Funcionario("546.879.157-20");
andre.Nome = "André";
andre.Salario = 2000;
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

gerenciador.Registrar(andre);

Diretor maria = new Diretor("454.658.148-3");
maria.Nome = "Maria";
maria.Salario = 5000;
Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

gerenciador.Registrar(maria);

Console.WriteLine(andre.Nome);
Console.WriteLine(andre.GetBonificacao());

Console.WriteLine(maria.Nome);
Console.WriteLine(maria.GetBonificacao());

Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());