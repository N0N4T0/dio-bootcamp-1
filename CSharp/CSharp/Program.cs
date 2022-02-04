using System;
using Primeiro;
using Classes;
using Interface;


namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();

            person.Nome = "None";
            person.Idade = 23;
            person.Estado = "HH";

            var person2 = new Pessoa();
            person2.Nome = "Done";
            person2.Idade = 13;
            person2.Estado = "AD";

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine("Hello World");


            Animal animal = new Animal();
            animal.Nome = "Rex";
            animal.NomeDono = "Rexona";
            animal.Especie = "Cachorro";

        }
    }
}