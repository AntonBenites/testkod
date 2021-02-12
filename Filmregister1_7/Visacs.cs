using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Filmregister1_7
{
    partial class Program
    {
        public static void LaddaUppInfo(ref Film[] filmer)
        {
            StreamReader infil = new StreamReader("MinaFilmer.txt", true); // om filen finns lägger vi till en ny film i slutet av filen därav true
            int storlek = Convert.ToInt32(infil.ReadLine()); // hur stor vektorn kommer vara finns i txt filen, som uppdateras när vektorn utökas
            filmer = new Film[storlek]; //vektorn blir den storlek som finns i filen som man inhämtar via streamreader

            for (int i = 0; i < filmer.Length; i++) //loopar igenom vektorn och sparar all info som finns i filen i en vektor
            {
                filmer[i] = new Film();
                filmer[i].FilmTitel = infil.ReadLine();
                filmer[i].FilmLängd = Convert.ToInt32(infil.ReadLine()); // omvandlar string till int genom convert
                filmer[i].genre = infil.ReadLine();
                filmer[i].betyg = Convert.ToDouble(infil.ReadLine());
                filmer[i].produktionsÅr = Convert.ToInt32(infil.ReadLine());
            }
            infil.Close(); // stänger filen
        }
        public static void VisaAllaFilmer(Film[] filmer) // anropar vektorn 
        {

            Console.WriteLine("Dessa filmer har du i din filmsamling:");
            for (int i = 0; i < filmer.Length; i++)
            {
                filmer[i].VisaInformation(); // tar in metod för att visa filmerna enligt varje del av filmens egenskaper
            }
            Console.WriteLine("Tryck på valfri tangent för att återgå till meny");
            Console.ReadKey();
        }

        public static void LäggTillFilm(Film[] filmer) // anropar vektorn
        {
            StreamWriter utfil = new StreamWriter("MinaFilmer.txt");
            utfil.WriteLine(filmer.Length + 1); // ökar talet i txt filen för att kunna öka vektorn

            Film temp = new Film(); // skapa ny film som ska sparas i vektor och i filen sedan

            Console.Write("Skriv in titel: "); // spara ny data till filen
            temp.FilmTitel = Console.ReadLine(); // lägga in något där man kan skriva stora och små bokstäver
            Console.Write("Skriv in filmens längd i minuter: "); // lägga in något att du skrev inte ett heltal try parse 27 slide

            temp.FilmLängd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in genre, du kan välja mellan Skräck, Barnfilm, Komedi, Äventyr, Action, Sci-fi eller Drama: ");
            temp.genre = Console.ReadLine();
            Console.Write("Skriv in betyg: ");
            temp.betyg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv in produktionsår: ");
            temp.produktionsÅr = Convert.ToInt32(Console.ReadLine());

            utfil.WriteLine(temp.FilmTitel);
            utfil.WriteLine(temp.FilmLängd);
            utfil.WriteLine(temp.genre);
            utfil.WriteLine(temp.betyg);
            utfil.WriteLine(temp.produktionsÅr);

            for (int i = 0; i < filmer.Length; i++) // lägger tillbaka den gamla filmerna i filen
            {
                utfil.WriteLine(filmer[i].FilmTitel);
                utfil.WriteLine(filmer[i].FilmLängd);
                utfil.WriteLine(filmer[i].genre);
                utfil.WriteLine(filmer[i].betyg);
                utfil.WriteLine(filmer[i].produktionsÅr);

            }
            Console.WriteLine("");
            Console.WriteLine("Nu finns det " + filmer.Length + " i ditt filmregister");
            Console.WriteLine("--------------------------------");
            utfil.Close();
        }

        public static void SökViaTitel(Film[] filmer)  // sökning av film i vektorn, lägger hittade filmer i en ny vektor 
        {
            string sökning;
            Film[] hittadeFilmer = new Film[filmer.Length];
            int antalFilmer = 0;
            Console.Write("Skriv in titeln du vill söka efter:");
            sökning = Console.ReadLine();

            for (int i = 0; i < filmer.Length; i++)
            {

                if (filmer[i].FilmTitel.ToLower().Contains(sökning.ToLower())) // användaren kan söka på både stora och små bokstäver genom ToLower
                {

                    hittadeFilmer[antalFilmer++] = filmer[i];

                    Console.WriteLine("Filmtitel: " + filmer[i].FilmTitel + "\n" + "Längd:     " + filmer[i].FilmLängd + "\n" + "Genre:     " + filmer[i].genre + "\n" + "Betyg:     " + filmer[i].betyg + "\n" + "År:        " + filmer[i].produktionsÅr);

                }

            }

        }

             public static void Tabortfilmer(Film[] filmer)
        {
            StreamReader infil = new StreamReader("MinaFilmer.txt", true);
            Console.WriteLine("Ange namnet på filmen du vill ta bort ");
            String Titel = Console.ReadLine();
            int index = Getindexforfilmer (Titel);
            if (index == -1) 
            {
                Console.WriteLine("Filmen saknas");
            }
            else 
            {
                Tabortfilm(index);
                Console.WriteLine(Titel + "Togs bort ur registret");
            }
              public static void Tabortfilmer(Film[] filmer)
             {
               for(int b  = 0; b < filmer[i]; b++)
                {

                }  







            }

           
            {

            }
        
        
        
        
        }

           

            







    }









    
}