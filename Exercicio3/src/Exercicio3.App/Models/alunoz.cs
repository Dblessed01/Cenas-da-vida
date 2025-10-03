using System;

namespace Exercicio3.App
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Matricula { get; set; }
        public double Media { get; set; }

        public Aluno(string nome, int idade, int matricula, double media)
        {
            Nome = nome;
            Idade = idade;
            Matricula = matricula;
            Media = media;
        }

        public void AlunoInfo()
        {
            Console.WriteLine($"📚 Nome: {Nome} | Idade: {Idade} | Matrícula: {Matricula} | Média: {Media:F2}");
        }
    }
}
