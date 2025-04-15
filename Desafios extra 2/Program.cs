namespace CalculadoraIMC;

class Program
{
    static void Main()
    {
        Console.WriteLine ("Escreva seu peso em Kg:");
         double peso = Convert.ToDouble(Console.ReadLine());
         
         Console.WriteLine("Agora, inform sua altura em Metros:");
         double altura = Convert.ToDouble(Console.ReadLine());
         double dez = peso * 10000;

         double IMC = dez / (altura*altura) ;

         Console.WriteLine($"Seu IMC é: {IMC:F2}"); 

            if (IMC < 18.5)
            {
                Console.WriteLine("Abaixo do peso ideal");
            }
            else if (IMC < 25.0)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (IMC < 30.0)
            {
                Console.WriteLine("Acima do peso ideal");
            }
            else if (IMC < 35.0)
            {
                Console.WriteLine("Obesidade Grau I");
            }
            else if (IMC < 40)
            {
                Console.WriteLine("Obesidade Grau II");
            }
            else
            {
                Console.WriteLine("Obesidade Grau III");
            }
    }



}
