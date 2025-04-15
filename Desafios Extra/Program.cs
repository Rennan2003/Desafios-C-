using System;

namespace GeradorDeNome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite seu primeiro nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu mês de nascimento (por extenso ou número):");
            string niver = Console.ReadLine().ToLower();

            Console.WriteLine("Digite sua cor favorita:");
            string cor = Console.ReadLine().ToLower();

            string gato1 = "";
            string gato2 = "";
            string gato3 = "";

           if (nome[1].ToString().ToLower() == "a")
             {gato1 = "Tralelino";}
           else if (nome[1].ToString().ToLower() == "b") 
             {gato1 = "Bombardello";}
           else if (nome[1].ToString().ToLower() == "c") 
             {gato1 = "Crocantino"; }
           else if (nome[1].ToString().ToLower() == "d") 
             {gato1 = "Donfettuccio";} 
           else if (nome[1].ToString().ToLower() == "e") 
             {gato1 = "Espaguettini";} 
           else if (nome[1].ToString().ToLower() == "f") 
             {gato1 = "Frangolino";}
           else if (nome[1].ToString().ToLower() == "g") 
             {gato1 = "Gattarello";}
           else if (nome[1].ToString().ToLower() == "h") 
             {gato1 = "Histericcio";}
           else if (nome[1].ToString().ToLower() == "i") 
             {gato1 = "Incantolino";}
           else if (nome[1].ToString().ToLower() == "j") 
             {gato1 = "Jambonetto";}
           else if (nome[1].ToString().ToLower() == "k") 
             {gato1 = "Kriminaletti";}
           else if (nome[1].ToString().ToLower() == "l") 
             {gato1 = "Lamentino";} 
           else if (nome[1].ToString().ToLower() == "m") 
             {gato1 = "Mangiacielo";} 
           else if (nome[1].ToString().ToLower() == "n") 
             {gato1 = "Notturnello";} 
           else if (nome[1].ToString().ToLower() == "o")
             {gato1 = "Ombrellino";} 
           else if (nome[1].ToString().ToLower() == "p")
             {gato1 = "Pastaflor";} 
           else if (nome[1].ToString().ToLower() == "q")
             {gato1 = "Quasinuvola";} 
           else if (nome[1].ToString().ToLower() == "r")
             {gato1 = "Ridolento";} 
           else if (nome[1].ToString().ToLower() == "s")
             {gato1 = "Strambolinho";} 
           else if (nome[1].ToString().ToLower() == "t")
             {gato1 = "Tremolatto";} 
           else if (nome[1].ToString().ToLower() == "u")
             {gato1 = "Ululantino";} 
           else if (nome[1].ToString().ToLower() == "v")
             {gato1 = "Ventolazzo";} 
           else if (nome[1].ToString().ToLower() == "w")
             {gato1 = "Waffelini";} 
           else if (nome[1].ToString().ToLower() == "x")
             {gato1 = "Xeroxano"; }
           else if (nome[1].ToString().ToLower() == "y")
            { gato1 = "Yogurtello"; }
           else if (nome[1].ToString().ToLower() == "z")
            { gato1 = "Zangarello"; }
          else
            { gato1 = "Misterioso"; 
            }

         
         switch (niver)
            {
                case "1":
                case "janeiro": gato2 = "Belcanto"; break;
                case "2":
                case "fevereiro": gato2 = "Melodramatto"; break;
                case "3":
                case "março": gato2 = "Violenzzo"; break;
                case "4":
                case "abril": gato2 = "Amorellino"; break;
                case "5":
                case "maio": gato2 = "Tenebroso"; break;
                case "6":
                case "junho": gato2 = "Lucifritto"; break;
                case "7":
                case "julho": gato2 = "Donzarelli"; break;
                case "8":
                case "agosto": gato2 = "Cataclismetto"; break;
                case "9":
                case "setembro": gato2 = "Bravissimo"; break;
                case "10":
                case "outubro": gato2 = "Mortadello"; break;
                case "11":
                case "novembro": gato2 = "Deliranzzo"; break;
                case "12":
                case "dezembro": gato2 = "Serenattoni"; break;
                default: gato2 = "Eterno"; break;
            }

          
            switch (cor)
            {
                case "vermelho": gato3 = "della Rabbia"; break;
                case "laranja": gato3 = "di Fuoco e Pasta"; break;
                case "amarelo": gato3 = "del Sole Perduto"; break;
                case "verde": gato3 = "dell’Erba Furiosa"; break;
                case "azul": gato3 = "della Notte Lamentosa"; break;
                case "roxo": gato3 = "del Vino Tragico"; break;
                case "rosa": gato3 = "di Fragola Maldita"; break;
                case "preto": gato3 = "delle Tre Sombras"; break;
                case "branco": gato3 = "della Neve Caótica"; break;
                case "cinza": gato3 = "di Nebbia Antiga"; break;
                case "marrom": gato3 = "di Fango Antipático"; break;
                default: gato3 = "da Cor Indefinível"; break;
            }

        Console.WriteLine($"\n🐱 Nome do seu gato: {gato1} {gato2} {gato3}");
    }
    }
    }