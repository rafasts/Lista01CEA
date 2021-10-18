using System;

namespace Exercicio04
{
    class Program
    {
        //Criar um programa que leia o valor de três notas escolares de um aluno. 
        //Calcular a média aritmética e apresentar na tela a mensagem “Aprovado” se a média obtida for maior ou igual a 7; 
        //caso contrário, o programa deve solicitar a nota de exame do aluno e calcular uma nova média aritmética entre a nota do exame 
        //e a primeira média aritmética.
        //Se o valor da nova média for maior ou igual a 5, apresentar na tela a mensagem “Aprovado em exame”; 
        //caso contrário, apresentar a mensagem “Reprovado”. Informar junto com cada mensagem o valor da média obtida.

        static void Main(string[] args)
        {
            Console.Write("Informe a nota 1: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe a nota 2: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a nota 3: ");
            float nota3 = float.Parse(Console.ReadLine());

            float media = ((nota1 + nota2 + nota3) / 3);

            if (media >= 7) 
            {
                Console.WriteLine("Aprovado. Média {0}", media);
            }
            else
            {
                Console.Write("Informe a nota do exame: ");
                float notaExame = float.Parse(Console.ReadLine());

                media = ((notaExame + media) / 2);

                if (media >= 5) 
                {
                    Console.Write("Aprovado em exame. Média {0}", media);
                }
                else 
                {
                    Console.Write("Reprovado. Média {0}", media);
                }
            }
        }
    }
}
