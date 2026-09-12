using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios
{
    public class Livro
    {
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public decimal Valor { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("-Dados do Livro-");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Valor: {Valor:C2}");
        }

        public static void Executar()
        {
            Console.WriteLine("Exercício 6 - Cadastro de Livro");

            Livro livro = new Livro();

            Console.Write("Escreva o título do livro: ");
            livro.Titulo = Console.ReadLine() ?? string.Empty;

            Console.Write("Escreva o autor do livro: ");
            livro.Autor = Console.ReadLine() ?? string.Empty;

            Console.Write("Escreva o valor do livro: ");
            if (decimal.TryParse(Console.ReadLine()?.Replace('.', ','), out decimal val))
                livro.Valor = val;

            Console.WriteLine();
            livro.Imprimir();
            Console.WriteLine();
        }

    }

}
