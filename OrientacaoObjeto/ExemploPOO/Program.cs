using System;
using ExemploPOO.Modulos;

namespace ExemploPOO{
    class Program{
        static void Main(string[] args)
        {
            Professor p1 = new Professor();
            p1.Salario = 2000;
            p1.Nome = "Professor";
            p1.Idade = 40;

            p1.Apresentar();

            // Valores válidos
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            // System.Console.WriteLine($"Área: {r.ObterArea()}");
           
            // // Valores inválidos
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 30);
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");

            // Pessoa p1= new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p1.Apresentar();
        }
    }
}