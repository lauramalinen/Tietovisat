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
    public partial class Form2 : Form

    {
        static Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "Pisteesi: " + form1.pisteet;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
