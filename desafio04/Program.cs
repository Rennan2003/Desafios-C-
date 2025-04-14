namespace Desafio04;

/*  Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
 Você pode fazer uma verificação e incrementar o contador apenas **`se`** for um caractere, ignorando os espaços caso o usuário digite mais que uma palavra, por exemplo.
    
    */

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vamos brincar de contar caracteres!");
            Console.WriteLine("Digite uma palavra (ou frase) e eu direi quantos caracteres tem!");
            string frase = Console.ReadLine();
            string fraseSemEspacos = frase.Replace(" ", "");
            int NC = fraseSemEspacos.Length;

            Console.WriteLine($"Você digitou {NC} caracteres!");

        }
    }