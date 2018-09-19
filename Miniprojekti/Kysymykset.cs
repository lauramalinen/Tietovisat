using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace QuizSovellus
{
    class Kysymykset
    {
        public int Id { get; set; }
        public string Kysymys { get; set; }
        public bool Vastaus { get; set; }

        public Kysymykset()
        {

        }

        public Kysymykset(int id, string kysymys, bool vastaus)
        {
            Kysymys = kysymys;
            Id = id;
            Vastaus = vastaus;
        }

        
    }
}
