using System;
using System.Collections.Generic;
using System.Text;

namespace Filmregister1_7
{
   partial class Film
    {
        public string FilmTitel;
        public int FilmLängd;
        public string genre;
        public double betyg;
        public int produktionsÅr;
        
        
        public void VisaInformation() 
        {

            Console.WriteLine("Filmtitel: {0}", FilmTitel);
            Console.WriteLine("Längd: {0} ", FilmLängd);
            Console.WriteLine("Genre: {0} ", genre);
            Console.WriteLine("Betyg: {0} ", betyg);
            Console.WriteLine("År: {0} ", produktionsÅr);
            Console.WriteLine("---------------------------");
        } 
        
        
        
    }
}
