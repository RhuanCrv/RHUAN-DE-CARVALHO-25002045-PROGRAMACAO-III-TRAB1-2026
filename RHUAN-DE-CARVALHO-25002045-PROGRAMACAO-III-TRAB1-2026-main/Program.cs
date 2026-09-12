using RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("   TRABALHO 1 - 2026 - PROGRAMAÇÃO III");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("1 - Calculadora");
    Console.WriteLine("2 - Contar vogais de uma string");
    Console.WriteLine("3 - Imprimir apenas as vogais");
    Console.WriteLine("4 - Imprimir apenas as consoantes");
    Console.WriteLine("5 - Classificar faixa etária");
    Console.WriteLine("6 - Cadastro de Livro");
    Console.WriteLine("7 - Cadastro de Aluno");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("----------------------------------------");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine() ?? string.Empty;
    Console.WriteLine();

    switch (opcao)
    {
        case "1":
            new Calculadora().Executar();
            break;
        case "2":
            new ContadorDeVogais().Executar();
            break;
        case "3":
            new ImpressorDeVogais().Executar();
            break;
        case "4":
            new ImpressorDeConsoantes().Executar();
            break;
        case "5":
            new ClassificadorFaixaEtaria().Executar(); 
            break;
        case "6":
            Livro.Executar();
            break;
        case "7":
            Aluno.Executar();
            break;
        case "0":
            continuar = false;
            Console.WriteLine("Programa encerrando..");
            break;
        default:
            Console.WriteLine("Inválido! Tente novamente.");
            break;
    }

    if (continuar)
    {
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}
