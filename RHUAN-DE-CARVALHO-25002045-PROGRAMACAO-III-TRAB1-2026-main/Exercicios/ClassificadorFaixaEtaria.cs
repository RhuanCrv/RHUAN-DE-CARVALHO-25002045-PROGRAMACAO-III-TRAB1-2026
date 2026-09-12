using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios
{
    public class ClassificadorFaixaEtaria
    {
        public void Executar()
        {
            Console.WriteLine("Exercício 5 - Faixa Etária");

            Console.Write("Escreva a idade: ");
            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                string faixa;

                if (idade < 0)
                {
                    faixa = "Idade inválida";
                }
                else if (idade <= 19)
                {
                    faixa = "Jovem";
                }
                else if (idade <= 59)
                {
                    faixa = "Adulto";
                }
                else
                {
                    faixa = "Idoso";
                }

                Console.WriteLine($"Com {idade} anos, a pessoa é classificada como: {faixa}");
            }
            else
            {
                Console.WriteLine("Valor inválido inserido para a idade.");
            }

            Console.WriteLine();
        }
    }
}