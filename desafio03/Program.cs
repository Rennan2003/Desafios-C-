using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Desafio03
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine ("Digite o primeiro número da operação:");  
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine ("Digite o segundoo número da operação:");  
        double numero2 = double.Parse(Console.ReadLine());
        double numeroM = numero1+numero2;
        double M = numeroM/2;
        double X= numero1 * numero2;
        double Y= numero1 - numero2;
        double V;
            if (numero2 != 0)
            {
                V = numero1 / numero2; // Divisão
            }
            else
            {
                V = double.NaN; // Retorna "Not a Number" se o divisor for zero
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }

        Console.WriteLine ("Soma:"+" "+numeroM);
        Console.WriteLine ("Subtração:"+" "+Y);
        Console.WriteLine ("Multiplicação:"+X);
        Console.WriteLine ("Divisão:"+" "+V);
        Console.WriteLine ("Média:"+" "+M);
        }  
    }

}
 /*Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.*/


