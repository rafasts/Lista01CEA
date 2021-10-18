using System;

namespace Execicio02
{
    class Program
    {
        //Criar um programa que receba o valor do salário de um funcionário e 
        //o valor do salário mínimo e apresente na tela quantos salários mínimos
        //ganha esse funcionário.

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salário: ");
            float salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salário mínimo: ");
            float salarioMinimo = float.Parse(Console.ReadLine());

            float quantidadeSalario = salario / salarioMinimo;

            Console.WriteLine(@"O funcionário recebe {0} salários mínimo.", quantidadeSalario);
        }
    }
}
