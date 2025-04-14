/*1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso.*/

using System.Globalization;

namespace Desafio06;

class Program
{
    static void Main()
    {
    DateTime dia = DateTime.Now ;
    string data1 = dia.ToString("R", new CultureInfo("pt-BR"));
    string data2 = dia.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"));
    string data3 = dia.ToString("dd/MMMM/yyyy", new CultureInfo("pt-BR"));
    string data4 = dia.ToString("HH:mm:ss.f", new CultureInfo("pt-BR"));
    
    Console.WriteLine(data1);
    Console.WriteLine(data2);
    Console.WriteLine(data4);
    Console.WriteLine(data3);
    }
}

