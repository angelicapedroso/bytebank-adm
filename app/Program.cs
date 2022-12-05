using System;
using ByteBankAdm.Funcionarios;

Funcionario ana = new Funcionario();
ana.Nome = "Ana";
ana.Cpf = "123.456.789-10";
ana.Salario = 2000;

Console.WriteLine("Nome: " + ana.Nome);
Console.WriteLine("CPF: " + ana.Cpf);
Console.WriteLine("Salário: " + ana.Salario);
Console.WriteLine("Bonificação: " + ana.getBonificacao());