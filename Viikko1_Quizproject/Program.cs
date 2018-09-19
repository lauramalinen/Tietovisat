using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko1_Quizproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tervetuloa Tietovisaan!");
            Console.WriteLine("Vastaa annettuihin kysymyksiin K tai E");
            Console.WriteLine("***********************");

            Kysymysmoottori.LauranPeli();
            Console.ReadKey();
        }
    }
}
