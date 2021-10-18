using System;

namespace Exercicio01
{
    class Program
    {
        //Criar um programa que leia o peso e a altura de uma pessoa, calcule o seu IMC (Índice de Massa Corporal) 
        //e apresente na tela uma mensagem informando se a pessoa está ou não no seu peso ideal, de acordo com a tabela abaixo.
        //A fórmula para calcular o IMC é: IMC = peso / altura² .

        static void Main(string[] args)
        {
            Console.WriteLine("Informe o peso: ");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc >= 20 && imc < 25) 
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Acima do peso");
            }
        }
    }
}
