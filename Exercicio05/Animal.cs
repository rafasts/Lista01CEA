using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    public class Animal
    {
        private string _Nome;
        private TiposDeAnimais _TipoDeAnimal;

        public Animal(string nome, TiposDeAnimais tipoDeAnimal) 
        {
            _Nome = nome;
            _TipoDeAnimal = tipoDeAnimal;
        }

        public string GetNome() 
        {
            return _Nome;
        }

        public void SetNome(string nome)
        {
            _Nome = nome;
        }

        public TiposDeAnimais GetTipoDeAnimal()
        {
            return _TipoDeAnimal;
        }

        public TiposDeAnimais SetTipoDeAnimal(TiposDeAnimais tipoDeAnimal )
        {
            return _TipoDeAnimal = tipoDeAnimal;
        }
    }
}
