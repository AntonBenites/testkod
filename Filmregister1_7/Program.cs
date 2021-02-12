using System;

namespace Filmregister1_7
{
   partial class Program
   {
        

        static void Meny()  // Huvudprogrammet - main-metoden, här finns menyn som anropar metoder/klasser 
        {
            Console.WriteLine("");
            Console.WriteLine("Hej och välkommen till ditt filmregister!");
            Console.WriteLine(" ");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("MENY");
            Console.WriteLine("*******************************************************");
            Console.WriteLine("");
            Console.WriteLine("Vad vill du göra idag?");
            Console.WriteLine("");
            
            Console.WriteLine("Tryck 1 för att lägga till en film ");
            Console.WriteLine("Tryck 2 för att visa ditt filmregister");
            Console.WriteLine("Tryck 3 för att ta bort en film");
            Console.WriteLine("Tryck 4 för att välja film");
            Console.WriteLine("Tryck 5 för att visa sorterade filmer efter rating");
            Console.WriteLine("Tryck 6 för att visa den sammanlagda tiden för filmaraton");
            Console.WriteLine("Tryck 7 för att söka efter titel");
            Console.WriteLine("Tryck 8 för att avsluta");
            Console.WriteLine("");
            Console.WriteLine("");
        }
        static void Main()
        {
            Film [] filmer = new Film[0]; // Vektorn har noll, innan man laddar in sina filmer
            LaddaUppInfo(ref filmer);
            // Metod för att ladda in våran vektor med alla filmer från filen med en referensvärde

               while (true)
               {
                    LaddaUppInfo(ref filmer);
                    Meny();
                    Console.WriteLine("---------------------------");
                    Console.Write("Menyval: ");
                    Console.WriteLine("");
                    int menyval = int.Parse(Console.ReadLine());
                    switch (menyval)
                    {
                        case 0: Meny(); break;
                        case 1:
                            LäggTillFilm(filmer); 
                            break;
                        case 2:
                            VisaAllaFilmer(filmer); 
                            break;
                        case 3: Console.WriteLine(filmer[2].FilmTitel); break;
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                             SökViaTitel(filmer);
                        
                            break;
                        case 8: break;
                        
                    }


                }
               
        }
    }
}
