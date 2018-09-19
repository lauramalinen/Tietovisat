using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Viikko1_Quizproject;

namespace Miniprojekti
{
    class Program
    {
        public int Pistelaskuri { get; set; }
        
        public Program() {
            this.Pistelaskuri = 0;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Mikä peli valitaan? (1-3)");
            int luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Moottori Peli2 = new Moottori();
                Peli2.KysymysMoottori();
            }

            else if(luku == 2)
            {
                Console.WriteLine("Tervetuloa Tietovisaan!");
                Console.WriteLine("Vastaa annettuihin kysymyksiin K tai E");
                Console.WriteLine("***********************");

                Kysymysmoottori.LauranPeli();
            }
                
            
            else
            Console.WriteLine("Väärä valinta! :((");

                Console.ReadKey();
        }

       
      

       

    }
}
