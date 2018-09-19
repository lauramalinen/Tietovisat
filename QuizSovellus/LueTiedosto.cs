using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSovellus
{
    class LueTiedosto
    {
        int id;
        string kysymys = null;
        bool vastaus;
        List<Kysymykset> kysymykset = new List<Kysymykset>();

        public void TiedostoLukija()
        {
            using (StreamReader lukija = new StreamReader(@"C:\work\AcademyOpinnot\VIIKKO1\MiniProjektiViikko1\Kysymykset.csv"))
            {
                string line = null;
                
                while ((line = lukija.ReadLine()) != null)
                {                    
                    string[] lista = line.Split(';');
                    id = Convert.ToInt32(lista[0]);
                    kysymys = Convert.ToString(lista[1]);
                    vastaus = Convert.ToBoolean(lista[2]);
                    kysymykset.Add(new Kysymykset(id, kysymys, vastaus));

                }
                
            }
        }

        public List<Kysymykset> Randomize()
        {
            Random random = new Random();
            List<Kysymykset> palautus = new List<Kysymykset>();

            int rndId = 0;
            while(kysymykset.Count > 0)
            {
                rndId = random.Next(0, kysymykset.Count);
                palautus.Add(kysymykset[rndId]);
                kysymykset.RemoveAt(rndId);
            }

            return palautus;


        }

    }
}
