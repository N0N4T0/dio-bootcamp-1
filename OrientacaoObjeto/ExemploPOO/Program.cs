using System;
using ExemploPOO.Modulos;

namespace ExemploPOO{
    class Program{
        static void Main(string[] args)
        {
            Aluno p1 = new Aluno();
            p1.Nome = "Aluno";
            p1.Idade = 19;
            p1.Documento = "asdjasd";
            p1.Nota = 10;
            p1.Apresentar();

            Professor p2 = new Professor();
            p2.Nome = "Professor";
            p2.Idade = 19;
            p2.Documento = "asdjasd";
            p2.Salario = 1900;
            p2.Apresentar();

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