using static System.Console;
namespace TESTE_1_GFT.Models
{
    public class NaoEstudante
    {
        public string Nome,Matricula;
        public virtual void Info()
        {
        WriteLine("Digite o nome da pessoa:");
        Nome = ReadLine();
        WriteLine("Insira a matrícula da pessoa: ");
        Matricula = ReadLine();
        }
        public virtual void  Mensagem()
        {
            WriteLine("O nome do aluno é:" + Nome + "E a matricula é: " + Matricula);
        }
    }
}