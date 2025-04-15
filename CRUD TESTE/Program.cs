namespace Biblioteca;

class Program
{
    static void Main ()
    { 
        Console.WriteLine("Olá! Seja Bem-Vindo a nossa Biblioteca Online");
        string opção;
        do
        {
            /*Menu*/
        
        Console.WriteLine("Qual função deseja realiza?");
        Console.WriteLine ("1-  Criar um Livro ");
        Console.WriteLine  ("2- Acessar coleção");
        Console.WriteLine  ("3- Editar um Livro"); 
        Console.WriteLine("4- Excluir Livro");
        Console.WriteLine("0- Sair da Biblioteca");
        
        
         opção= Console.ReadLine();

            switch (opção)
            {
                case "1":
                {
                 Console.WriteLine("Criando um Livro");
                 var meulivro = new CriarLivro();
                 meulivro.Adicionar(Console.ReadLine());
                 break;
                }
                case  "2":
                {
                      Console.WriteLine("Acessando Coleção");
                      break;
                }
                case  "3":
                {
                     Console.WriteLine("Editando um Livro");
                     break;
                }
                case "4":
                            
                    {
                        Console.WriteLine("Excluindo um Livro");
                        break;
                    }
                case "0":
                            
                    {
                        Console.WriteLine("Saindo da Biblioteca... Até Breve!");
                        break;
                    }


                default:
                Console.WriteLine("Função indisponível");
                Console.WriteLine("Tente Novamente!");
                break;
            }
            

        }while (opção != "0" );
   
        } 
   
    }


/* Permitir que todas as opções retornem o menu principal
criar funções para as opções*/