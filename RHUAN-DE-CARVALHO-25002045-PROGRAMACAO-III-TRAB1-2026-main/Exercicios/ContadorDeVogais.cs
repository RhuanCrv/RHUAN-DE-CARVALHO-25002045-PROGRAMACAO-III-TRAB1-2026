using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios
{
    public class ContadorDeVogais
    {
        public void Executar()
        {
            Console.WriteLine("Exercício 2 - Contador de Vogais");

            Console.Write("Escreva uma frase ou palavra: ");
            string texto = Console.ReadLine() ?? string.Empty;

            string vogais = "aeiouAEIOU";
            int quantidade = 0;

            foreach (char caractere in texto)
            {
                if (vogais.Contains(caractere))
                {
                    quantidade++;
                }
            }

            Console.WriteLine($"Quantidade de vogais encontradas: {quantidade}");
            Console.WriteLine();
        }
    }
}
