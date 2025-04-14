using System.Formats.Asn1;

namespace Desafio05
/*1. Crie um programa em que o usuário precisa digitar a
 placa de um veículo e o programa verifica se a placa é válida,
  seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
 Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** 
caso contrário.*/
{
   class Program
   {
    static void Main()
    {
        Console.WriteLine("Verificador de placas!");
        Console.WriteLine ("Digite a sua placa:");

        string Placa = Console.ReadLine ();
 
       bool resultado = ValidaPlaca(Placa);
    if (resultado)
                Console.WriteLine("Verdadeiro");
            else
                Console.WriteLine("Falso");
        }

        static bool ValidaPlaca(string Placa)
        {
            if (Placa.Length != 7)
                return false;

            for (int i = 0; i < 3; i++)
            {
                string c = Placa[i].ToString().ToLower();

                if (c != "a" && c != "b" && c != "c" && c != "d" && c != "e" &&
                    c != "f" && c != "g" && c != "h" && c != "i" && c != "j" &&
                    c != "k" && c != "l" && c != "m" && c != "n" && c != "o" &&
                    c != "p" && c != "q" && c != "r" && c != "s" && c != "t" &&
                    c != "u" && c != "v" && c != "w" && c != "x" && c != "y" && c != "z")
                  {
                    return false;
                  }
                    
                
            }

            for (int i = 3; i < 7; i++)
            {
                string c = Placa[i].ToString();

                if (c != "0" && c != "1" && c != "2" && c != "3" &&
                    c != "4" && c != "5" && c != "6" && c != "7" &&
                    c != "8" && c != "9")
                {
                    return false;
                }
            }

            return true;
        }
        /* para os 3 primeiros se diferentes de "a" e ou "b" e ou "c"... - return false
   para os últimos 4 se diferentes de 1 e ou 2 e ou 3 .... retornar falso
   else, retornar true.*/ 
   }
}