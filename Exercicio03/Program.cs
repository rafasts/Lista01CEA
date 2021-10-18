using System;

namespace Exercicio03
{
    class Program
    {
        // Criar um programa que calcule e apresente na tela o volume de uma esfera de raio R, 
        // em que R é um dado fornecido pelo usuário.
        // O volume de uma esfera é dado por V = 4/3πR³.

        static void Main(string[] args)
        {
            Console.Write("Informe o raio da esfera: ");
            double raioEsfera = double.Parse(Console.ReadLine());

            double volume = ((4 * Math.PI * Math.Pow(raioEsfera, 3)) / 3);

            Console.WriteLine("Ovolume da esfera é {0}", volume);
        }
    }
}
