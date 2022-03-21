using static System.Console;
namespace TESTE_1_GFT.Models
{
    public class EstudanteMedio : NaoEstudante
    {
        public string Escola;
        public virtual void Info()
        {
        WriteLine("Digite o nome da pessoa:");
        Nome = ReadLine();
        WriteLine("Insira a matrícula da pessoa: ");
        Matricula = ReadLine();
        WriteLine("Insira a escola em que o aluno estudou: ");
        Escola = ReadLine();
        }
        public virtual void  Mensagem()
        {
            WriteLine("O nome do aluno é:" + Nome + " e a matricula é: " + Matricula);
            WriteLine($"A escola em que o aluno estudou foi: {Escola}");
        }
    }
}