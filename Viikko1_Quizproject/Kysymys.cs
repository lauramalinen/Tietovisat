using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikko1_Quizproject
{
    class Kysymys
    {
        private string kysymysTeksti;
        private List<String> vastausVaihtoehdot;
        private int oikeanVaihtoehdonIndeksi;
        public string KysymysTeksti { get => kysymysTeksti; set => kysymysTeksti = value; }
        public int OikeanVaihtoehdonIndeksi { get => oikeanVaihtoehdonIndeksi; set => oikeanVaihtoehdonIndeksi = value; }


        public string KysyKysymys()
        {
            //string[] kysymykset = File.ReadAllLines(@"C:\Users\ainon\OneDrive\Desktop\C# ohjelmointi\Viikko_1\TietovisaC\TietovisaC\Kysymykset.txt");
            string[] kysymykset = File.ReadAllLines(@"C:\Users\laura\source\repos\Viikko1_Quizproject\Viikko1_Quizproject\Kysymykset.txt");


            Random r = new Random();

            for (int i = kysymykset.Length; i > 1;)
            {
                int k = r.Next(i--);
                string temp = kysymykset[i];
                kysymykset[i] = kysymykset[k];
                kysymykset[k] = temp;
            }

            //foreach (var kysymys in kysymykset)
            //{
            //    Console.WriteLine(kysymys);
            //}


            return kysymykset[0];

        }
    }
}
