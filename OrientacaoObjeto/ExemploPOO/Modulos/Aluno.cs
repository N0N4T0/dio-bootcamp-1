namespace ExemploPOO.Modulos
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar(){
            Console.WriteLine($"Olá meu nome é {Nome} e eu tire nota {Nota}");
        }
    }
}