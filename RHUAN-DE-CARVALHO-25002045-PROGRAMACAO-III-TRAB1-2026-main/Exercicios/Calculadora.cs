using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios
{
    public class Calculadora
    {
        public void Executar()
        {
            Console.WriteLine("Exercício 1 - Calculadora");

            Console.Write("Escreva o primeiro número: ");
            double.TryParse(Console.ReadLine()?.Replace('.', ','), out double numero1);

            Console.Write("Escreva o segundo número: ");
            double.TryParse(Console.ReadLine()?.Replace('.', ','), out double numero2);

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;

            Console.WriteLine();
            Console.WriteLine($"Soma: {numero1} + {numero2} = {soma}");
            Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao}");
            Console.WriteLine($"Multiplicação: {numero1} x {numero2} = {multiplicacao}");

            if (numero2 != 0)
            {
                double divisao = numero1 / numero2;
                double resto = numero1 % numero2;
                Console.WriteLine($"Divisão: {numero1} / {numero2} = {divisao}");
                Console.WriteLine($"Resto da divisão: {numero1} % {numero2} = {resto}");
            }
            else
            {
                Console.WriteLine("Divisão e resto da divisão: não é possível dividir por zero.");
            }

            Console.WriteLine();
        }
    }

}
