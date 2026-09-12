using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHUAN_DE_CARVALHO_25002045_PROGRAMACAO_III_TRAB1_2026.Exercicios
{
    public class Aluno
    {
        private const int TotalDeAulas = 40;
        private const double PercentualLimiteFaltas = 0.4;

        public string Nome { get; set; } = string.Empty;
        public string RA { get; set; } = string.Empty;

        private double notaProva;
        public double NotaProva
        {
            get => notaProva;
            set => notaProva = Math.Clamp(value, 0, 10);
        }

        private double notaTrabalho;
        public double NotaTrabalho
        {
            get => notaTrabalho;
            set => notaTrabalho = Math.Clamp(value, 0, 10);
        }

        private int faltas;
        public int Faltas
        {
            get => faltas;
            set => faltas = Math.Clamp(value, 0, TotalDeAulas);
        }
        public double CalcularMedia()
        {
            return (NotaProva * 0.7) + (NotaTrabalho * 0.3);
        }
        public bool PassouPorFrequencia()
        {
            int limiteDeFaltas = (int)(TotalDeAulas * PercentualLimiteFaltas);
            return Faltas <= limiteDeFaltas;
        }

        public void Imprimir()
        {
            Console.WriteLine("-Dados do Aluno-");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"RA: {RA}");
            Console.WriteLine($"Nota da Prova: {NotaProva}");
            Console.WriteLine($"Nota do Trabalho: {NotaTrabalho}");
            Console.WriteLine($"Faltas: {Faltas} de {TotalDeAulas} aulas");
            Console.WriteLine($"Média final: {CalcularMedia():F2}");
            Console.WriteLine($"Situação por faltas: {(PassouPorFrequencia() ? "Aprovado" : "Reprovado por falta")}");
        }

        public static void Executar()
        {
            Console.WriteLine("Exercício 7 - Cadastro de Aluno");

            Aluno aluno = new Aluno();

            Console.Write("Escreva o nome do aluno: ");
            aluno.Nome = Console.ReadLine() ?? string.Empty;

            Console.Write("Escreva o R.A. do aluno: ");
            aluno.RA = Console.ReadLine() ?? string.Empty;

            Console.Write("Escreva a nota da prova (0 a 10): ");
            if (double.TryParse(Console.ReadLine()?.Replace('.', ','), out double notaP))
                aluno.NotaProva = notaP;

            Console.Write("Escreva a nota do trabalho (0 a 10): ");
            if (double.TryParse(Console.ReadLine()?.Replace('.', ','), out double notaT))
                aluno.NotaTrabalho = notaT;

            Console.Write("Escreva a quantidade de faltas (0 a 40): ");
            if (int.TryParse(Console.ReadLine(), out int f))
                aluno.Faltas = f;

            Console.WriteLine();
            aluno.Imprimir();
            Console.WriteLine();
        }
    }

}
