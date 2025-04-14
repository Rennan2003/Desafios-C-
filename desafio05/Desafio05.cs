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
 
        ValidaPlaca(Placa);
    }

      static bool ValidaPlaca(string Placa)
   {
        if (Placa.Length != 7)
                {
                    Console.WriteLine ("Falso");
                    return false;
                }

        for (int i = 0; i < 3; i++)
            {
                if (Placa[i].ToString().ToLower() != "a" ||Placa[i].ToString().ToLower() != "b" ||Placa[i].ToString().ToLower() != "c" ||
                Placa[i].ToString().ToLower() != "d" ||Placa[i].ToString().ToLower() != "e" ||Placa[i].ToString().ToLower() != "f" ||
                Placa[i].ToString().ToLower() != "g" ||Placa[i].ToString().ToLower() != "h" ||Placa[i].ToString().ToLower() != "i" ||
                Placa[i].ToString().ToLower() != "j" ||Placa[i].ToString().ToLower() != "k" ||Placa[i].ToString().ToLower() != "l" ||
                Placa[i].ToString().ToLower() != "m" ||Placa[i].ToString().ToLower() != "n" ||Placa[i].ToString().ToLower() != "o" ||
                Placa[i].ToString().ToLower() != "p" ||Placa[i].ToString().ToLower() != "q" ||Placa[i].ToString().ToLower() != "r" ||
                Placa[i].ToString().ToLower() != "s" ||Placa[i].ToString().ToLower() != "t" ||Placa[i].ToString().ToLower() != "u" ||
                Placa[i].ToString().ToLower() != "v" ||Placa[i].ToString().ToLower() != "w" ||Placa[i].ToString().ToLower() != "x" ||
                Placa[i].ToString().ToLower() != "y" ||Placa[i].ToString().ToLower() != "z" )
                {
                    Console.Write("Falso");
                    return false;
                    
                }
                else
          
                {
                  Console.WriteLine("Verdadeiro!");
                  return true;
                 

                } 
            }
         for (int n = 3; n < 7; n++)
            {
                if (Placa[n].ToString() !="1" || Placa[n].ToString() != "2" ||Placa[n].ToString() != "3" ||Placa[n].ToString() != "4" ||
                Placa[n].ToString() != "5" ||Placa[n].ToString() != "6" ||Placa[n].ToString() != "7" ||Placa[n].ToString() != "8" ||Placa[n].ToString() != "9" ||
                Placa[n].ToString() != "0" )
                {
                    Console.Write("Falso");
                    return false;
                }
                else
          
                {
                  Console.WriteLine("Verdadeiro!");
                  return true;

                }
                } 
             Console.WriteLine("Verdadeiro!");
             return true;
            }
        
    }

   /* para os 3 primeiros se diferentes de "a" e ou "b" e ou "c"... - return false
   para os últimos 4 se diferentes de 1 e ou 2 e ou 3 .... retornar falso
   else, retornar true.*/ 
}

