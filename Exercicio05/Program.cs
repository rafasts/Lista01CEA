using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>();

            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine(@"Informe o nome do animal {0}: ", (i+1));
                string nome = Console.ReadLine();

                Console.WriteLine(@"Informe o tipo do animal {0}: ", (i+1));
                Console.WriteLine("Digite 0 - Cachorro");
                Console.WriteLine("Digite 1 - Gato");
                Console.WriteLine("Digite 2 - Peixe");
                int tipoDeAnimal = int.Parse(Console.ReadLine());

                int[] tipos = { 0, 1, 2 };

                if (! tipos.Contains(tipoDeAnimal)) 
                {
                    tipoDeAnimal = 2;
                }

                animais.Add(new Animal(nome, (TiposDeAnimais)tipoDeAnimal));
            }

            Console.Clear();

            Console.WriteLine(@"Quantidade de Cachorros {0} ",
                animais.Where(a => a.GetTipoDeAnimal() == TiposDeAnimais.cachorros).Count());

            Console.WriteLine(@"Quantidade de Gatos {0} ",
                animais.Where(a => a.GetTipoDeAnimal() == TiposDeAnimais.gatos).Count());

            Console.WriteLine(@"Quantidade de Peixes {0} ",
                animais.Where(a => a.GetTipoDeAnimal() == TiposDeAnimais.peixes).Count());

            Console.Read();
        }
    }
}
