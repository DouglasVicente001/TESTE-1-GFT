using static System.Console;
namespace TESTE_1_GFT.Models
{
    public class EstudanteSuperior : EstudanteMedio
    {   
        public string Universidade;
        public virtual void Info()
        {
        WriteLine("Digite o nome da pessoa:");
        Nome = ReadLine();
        WriteLine("Insira a matrícula da pessoa: ");
        Matricula = ReadLine();
        WriteLine("Insira a escola em que o aluno estudou: ");
        Escola = ReadLine();
        WriteLine("Insira a Universidade  em que o aluno se formou: ");
        Universidade = ReadLine();
        }
        public virtual void  Mensagem()
        {
            WriteLine("O nome do aluno é:" + Nome + "E a matricula é: " + Matricula);
            WriteLine($"A escola em que o aluno estudou foi: {Escola}");
            WriteLine($"A universidade cursada pelo aluno {Nome} é: {Universidade}");
        }
    }
}