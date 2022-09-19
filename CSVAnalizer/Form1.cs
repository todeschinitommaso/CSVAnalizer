using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSVAnalizer
{
    public partial class Form1 : Form
    {
        public string path = @".\Dati.csv";

        public Form1()
        {
            InitializeComponent();
        }

        //CONTROLLO LUNGHEZZA RECORD
        private void button1_Click(object sender, EventArgs e)
        {
            int character;
            int prevchar = 0;
            StreamReader sr = new StreamReader(path);
            int count = 0;
            string check = "Dimensioni Uguali";

            while (sr.ReadLine() != null)
            {
                character = sr.ReadLine().Length;

                if(count != 0)
                {
                    if(prevchar != character)
                    {
                        check = "Dimensioni differenti";
                        MessageBox.Show(check);
                        return;
                    }
                }

                prevchar = character;
                count++;
            }
            MessageBox.Show(check);
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path);
            int a = sr.ReadLine().Length;
            sr.Close();
            MessageBox.Show("Dimensione massima " + a.ToString());
        }
    }
}
