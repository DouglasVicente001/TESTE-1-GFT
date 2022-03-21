using TESTE_1_GFT.Models;
using static System.Console;

namespace Teste_1_GFT
{
  class program
  {
    public static void Main(string []args)
    { 
      while(true)
      {
      int Opcao,Decisao;
      
      WriteLine ("Digite uma das opções");
      WriteLine("Digite [1] para aluno sem ensino. ");
      WriteLine("Digite [2] para aluno com ensino medio");
      WriteLine("Digite [3] para aluno de nivel universitário.");
      Opcao = int.Parse(ReadLine());
      switch (Opcao)
      { 
        case 1:
        NaoEstudante p1 = new NaoEstudante();
        p1.Info();
        p1.Mensagem();
        break;

        case 2:
        EstudanteMedio p2 = new EstudanteMedio();
        p2.Info();
        p2.Mensagem();
        break;

        case 3:
        EstudanteSuperior p3 = new EstudanteSuperior();
        p3.Info();
        p3.Mensagem();
        break;
      }
      WriteLine();
      WriteLine("Deseja continuar?Pressione: [1]Continuar / [0]Sair .");
      Decisao = int.Parse(ReadLine());
      if (Decisao == 0)
      { 
        WriteLine("Obrigado por usar nosso app. :)");
        break;
      }
        }

    }
  }
}