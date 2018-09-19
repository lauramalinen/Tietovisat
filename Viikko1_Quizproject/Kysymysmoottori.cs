using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko1_Quizproject
{
    class Kysymysmoottori
    {
        public static void LauranPeli()
        {
            Kysymys kysymys = new Kysymys();
            string vastaus = "";
            int pisteet = 0;
            int kysymysLaskuri = 1;

            for (int i = 0; i < 10; i++)
            {
                string[] kysymysVastaus = kysymys.KysyKysymys().Split('*');
                string kysyRandom = kysymysVastaus[0];
                string oikeaVast = kysymysVastaus[1];

                Console.WriteLine("Kysymys " + kysymysLaskuri + "/10 " + kysyRandom);
                Console.Write("Vastaus: ");

                vastaus = Console.ReadLine().ToUpper();

                //Vastauksen arviointi
                kysymysLaskuri++;

                if (vastaus == oikeaVast)
                {
                    pisteet++;
                    Console.WriteLine("Oikea vastaus!");
                }
                else
                {
                    Console.WriteLine("Vastaus väärin :(");
                }

                Console.WriteLine("-------------------");
            }
            Console.WriteLine("Pistemääräsi on: " + pisteet);
        }

        
    }
}
