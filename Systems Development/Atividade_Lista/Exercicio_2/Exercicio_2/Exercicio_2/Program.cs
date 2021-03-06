using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_2
{
    class Program
    {
        public struct Aluno
        {
            public string nome;
            public float nota1, nota2, media;
        }
        static void Main(string[] args)
        {
            //Declaração de variáveis 
            Aluno[] alunos = new Aluno[15];
            //alunos[0].nome

            //Solicitação das informações dos alunos
            for (int c = 0; c < 15; c++)
            {
                Console.Write($"Digite o nome do {(c+1)}° aluno: ");
                alunos[c].nome = Console.ReadLine();
                Console.Clear();

                Console.Write("Digite a 1° nota: ");
                alunos[c].nota1 = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.Write("Digite a 2° nota: ");
                alunos[c].nota2 = int.Parse(Console.ReadLine());
                Console.Clear();

                alunos[c].media = (alunos[c].nota1 + alunos[c].nota2) / 2;
            }

            //Exposição das médias
            Console.WriteLine("Nome do aluno | 1° nota | 2° nota | Média");
            for (int x = 0; x < 15; x++)
            {
                if (alunos[x].media  >= 7)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{alunos[x].nome} | {alunos[x].nota1} | {alunos[x].nota2} | {alunos[x].media}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{alunos[x].nome} | {alunos[x].nota1} | {alunos[x].nota2} | {alunos[x].media}");
                }
                
            }
            Console.ReadKey();
        }
    }
}
