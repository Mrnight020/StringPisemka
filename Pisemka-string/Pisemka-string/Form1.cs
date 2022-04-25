using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pisemka_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string abeceda = "abcdefghijklmnopqrstuvwxyz ";

            if(text != "")
            {
                while (text.Contains("  "))
                {
                    text = text.Replace("  ", " ");
                }

                char nejcastejsipismeno;

                int pocet = 0;
                int pocetpismeno = -1;
                int pozice = 0;

                for (int j = 0; j < 26; j++)
                {
                    foreach (char pismeno in text)
                    {

                        if (abeceda.Contains(pismeno))
                        {
                            if (pismeno == abeceda[j])
                            {
                                pocet++;
                            }
                        }
                    }
                    if (pocetpismeno < pocet)
                    {
                        pocetpismeno = pocet;
                        pozice = j;
                    }
                    pocet = 0;
                }

                MessageBox.Show("nejpouzivanejsi pismeno je : " + abeceda[pozice]);
            }
            else
            {
                MessageBox.Show("Nic si nezadal!!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            string abeceda = "abcdefghijklmnopqrstuvwxyz ";
            StringBuilder sb = new StringBuilder();

            foreach(char c in text)
            {
                if(abeceda.Contains(c))
                {
                    sb.Append(c);
                }
            }
            string sbstring = sb.ToString();

            StringBuilder neco = new StringBuilder();

            foreach (char c in abeceda)
            {
                if (sbstring.Contains(c))
                {
                }
                else
                {
                    neco.Append(c);
                }
            }

            MessageBox.Show("Chybejici pismena = "+ neco);
        }
    }
}
