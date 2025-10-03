using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio3.App
{
    public static class Registo
    {
        public static List<Aluno> Alunos { get; private set; } = new List<Aluno>();

        public static void IniciarRegisto()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nDigite o nome do aluno:");
                string nome = Console.ReadLine();

                int idade;
                while (true)
                {
                    Console.Write("Digite a idade do aluno: ");
                    if (int.TryParse(Console.ReadLine(), out idade)) break;
                    Console.WriteLine("Idade inválida. Tente novamente.");
                }

                int matricula;
                while (true)
                {
                    Console.Write("Digite a matrícula do aluno: ");
                    if (int.TryParse(Console.ReadLine(), out matricula)) break;
                    Console.WriteLine("Matrícula inválida. Tente novamente.");
                }

                int quantidadeNotas;
                while (true)
                {
                    Console.Write("Quantas notas deseja inserir? ");
                    if (int.TryParse(Console.ReadLine(), out quantidadeNotas) && quantidadeNotas > 0) break;
                    Console.WriteLine(" Quantidade inválida. Tente novamente.");
                }

                List<double> notas = new List<double>();
                for (int i = 0; i < quantidadeNotas; i++)
                {
                    double nota;
                    while (true)
                    {
                        Console.Write($"Digite a nota {i + 1}: ");
                        if (double.TryParse(Console.ReadLine(), out nota)) break;
                        Console.WriteLine("Nota inválida. Tente novamente.");
                    }
                    notas.Add(nota);
                }

                
                double media = notas.Average();

                
                Aluno aluno = new Aluno(nome, idade, matricula, media);
                Alunos.Add(aluno);

                Console.WriteLine($"\n✅ Aluno registado com sucesso!");
                aluno.AlunoInfo();

                Console.Write("\nDeseja registar outro aluno? (s/n): ");
                string resposta = Console.ReadLine()?.Trim().ToLower();
                if (resposta == "n") continuar = false;
            }

            MostrarTodosAlunos();
        }

        public static void MostrarTodosAlunos()
        {
            Console.WriteLine("\n --- Lista de Alunos Registados ---");
            if (Alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno foi registado.");
                return;
            }

            foreach (Aluno a in Alunos)
            {
                a.AlunoInfo();
            }
        }
    }
}


