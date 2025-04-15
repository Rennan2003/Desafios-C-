namespace AdivinheONumero;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSorteado = random.Next(1, 101);
        int tentativas = 0;
        Console.WriteLine("Adivinhe o número entre 1 e 100!");
        int palpite ;
       
    do
    {

        Console.Write("Digite seu palpite: ");
        palpite =int.Parse(Console.ReadLine()) ;
        tentativas++;

     if (palpite < numeroSorteado)
     {
        Console.WriteLine("O número é MAIOR!");
        
     }   
    else if (palpite > numeroSorteado)
     {
        Console.WriteLine("O número é MENOR!");
     }
    else
    {
        Console.WriteLine($"Acertou em {tentativas} tentativas!");
        break; 
    }

    }
    while (palpite!=numeroSorteado);


    }
}
