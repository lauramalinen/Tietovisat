using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSovellus
{
    public partial class Form1 : Form
    {

        List<Kysymykset> kysymykset;
        int vastausIndeksi;
        public int pisteet;
        public Form1()

            
        {
            InitializeComponent();
            LueTiedosto lue = new LueTiedosto();
            lue.TiedostoLukija();
            kysymykset = new List<Kysymykset>(lue.Randomize());
            
            textBox1.Text = kysymykset[0].Kysymys;


        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (radioButton1.Checked == kysymykset[vastausIndeksi].Vastaus)
            {
                
                pisteet++;
                textBox2.Text = " Oikein! Pisteesi: " + pisteet + "/10";

            }

            else
            {
                textBox2.Text = "Väärin! Pisteesi: " + pisteet +  "/ 10";
            }

            vastausIndeksi++;

            textBox1.Text = kysymykset[vastausIndeksi].Kysymys;
            if (vastausIndeksi == 10)
            {
                textBox1.Text = "LOPPU. Pisteesi " + pisteet + "/10.";
                button1.Enabled = false;
                
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
