namespace ExemploPOO.Modulos
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome} e ganho {Salario} reais");
        }
    }
}