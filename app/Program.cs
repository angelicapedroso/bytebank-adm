using ByteBankAdm.Funcionarios;
using ByteBankAdm.Utilitario;
using ByteBankAdm.SistemaInterno;

Console.WriteLine("\n");

// Console.WriteLine("### Calculando Bonificação ###");
CalcularBonificacao();

Console.WriteLine("### Usando Sistema Interno ###");
UsarSistema();

Console.ReadKey();

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteDeConta ursula = new GerenteDeConta("326.985.628-89");
    ursula.Nome = "Ursula";
    ursula.Senha = "321";

    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(roberta, "321");

    sistemaInterno.Logar(ursula, "123");
    sistemaInterno.Logar(ursula, "321");
}

static void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciadorBonificacao = new GerenciadorDeBonificacao();

    Funcionario pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Funcionario roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";

    Funcionario igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    Funcionario camila = new GerenteDeConta("326.985.628-89");
    camila.Nome = "Camila";

    Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
    guilherme.Nome = "Guilherme";

    gerenciadorBonificacao.Registrar(guilherme);
    gerenciadorBonificacao.Registrar(pedro);
    gerenciadorBonificacao.Registrar(roberta);
    gerenciadorBonificacao.Registrar(igor);
    gerenciadorBonificacao.Registrar(camila);

    Console.WriteLine(
        "Total de bonificações do mês " + gerenciadorBonificacao.GetTotalBonificacao()
    );
}
