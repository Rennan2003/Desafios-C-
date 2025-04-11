using System; 

namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
             Console.WriteLine("Qual seu sobrenome?");
            var sobrenome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome + " "+ sobrenome + "! Seja bem-vindo!");
        }
    }
}