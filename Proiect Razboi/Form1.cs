using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Proiect_Razboi
{
    public partial class Form1 : Form
    {
        Joc joc;
        Pachet pachet;
        private Carte cartecurentajucator1;
        private Carte cartecurentajucator2;

        List<String> imagini_carti = new List<String>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();


            this.Load += Form1_Load;

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            pachet = new Pachet();
            pachet.Amesteca();

            joc = new Joc();

            string path = Path.Combine(Application.StartupPath, "imagini_carti");

            if (Directory.Exists(path))
            {
                imagini_carti = new List<string>();
                imagini_carti.AddRange(Directory.GetFiles(path, "*.png"));
            }
            else
            {
                MessageBox.Show($"Folderul {path} nu exista!");
            }
        }

        private void imparte_Click(object sender, EventArgs e)
        {
            Carte cartejucator1 = pachet.DaCarte();
            Carte cartejucator2 = pachet.DaCarte();
           

            joc.CarteCurentaJucator1 = cartejucator1;
            joc.CarteCurentaJucator2 = cartejucator2;
         
            pozacarte.Image = Image.FromFile(cartejucator1.Imagine);
            pozacarte2.Image = Image.FromFile(cartejucator2.Imagine);


        }


        private void Butonstart_Click(object sender, EventArgs e)
        {
            labelscor2.Text = "0";
            labelscor1.Text= "0";   

          
            pachet = new Pachet();
            pachet.Amesteca();


        }
       



        private void Butondejoc_Click(object sender, EventArgs e)
        {
            joc.ComparareCarti();
            labelscor1.Text = joc.ScorJucator1.ToString();
            labelscor2.Text = joc.ScorJucator2.ToString();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butondeiesire_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

       
    }
}










