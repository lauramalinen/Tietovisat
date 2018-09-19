using System;
using Viikko1_Quizproject;
using static System.Net.Mime.MediaTypeNames;
using System.Windows;
using System.Diagnostics;

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
            else if (luku ==3)
            {
                Process.Start(@"C:\work\AcademyOpinnot\VIIKKO1\MiniProjektiViikko1\QuizSovellus\bin\Debug\QuizSovellus.exe");
            }
              else
            Console.WriteLine("Väärä valinta! :((");

                Console.ReadKey();
        }

       
      

       

    }
}
