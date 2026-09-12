using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios
{
    public class ImpressorDeConsoantes
    {
        public void Executar()
        {
            Console.WriteLine("Exercício 4 - Imprimir apenas as Consoantes");

            Console.Write("Escreva uma frase ou palavra: ");
            string texto = Console.ReadLine() ?? string.Empty;

            string vogais = "aeiouAEIOU";
            string resultado = string.Empty;

            foreach (char caractere in texto)
            {
                if (char.IsLetter(caractere) && !vogais.Contains(caractere))
                {
                    resultado += caractere;
                }
            }

            Console.WriteLine($"Consoantes encontradas: {resultado}");
            Console.WriteLine();
        }
    }
}
