using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios
{
    public class ImpressorDeVogais
    {
        public void Executar()
        {
            Console.WriteLine("Exercício 3 - Imprimir apenas as Vogais");

            Console.Write("Escreva uma frase ou palavra: ");
            string texto = Console.ReadLine() ?? string.Empty;

            string vogais = "aeiouAEIOU";
            string resultado = string.Empty;

            foreach (char caractere in texto)
            {
                if (vogais.Contains(caractere))
                {
                    resultado += caractere;
                }
            }

            Console.WriteLine($"Vogais encontradas: {resultado}");
            Console.WriteLine();
        }
    }
}
