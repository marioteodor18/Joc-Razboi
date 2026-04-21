using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Razboi
{
    public class Pachet
    {
        public List<Carte> Carti;
        private Random rnd = new Random();

        public Pachet()
        {
            Carti = new List<Carte>();
            string[] simboluri = { "hearts", "diamonds", "spades", "clubs" };

            for (int valoare = 2; valoare <= 14; valoare++)
            {
                foreach (string simbol in simboluri)
                {
                    string stocheazanumeimagine = ianumeimagine(valoare, simbol);
                    Carti.Add(new Carte(valoare, $"imagini_carti/{stocheazanumeimagine}"));
                }
            }
        }

        private string ianumeimagine(int valoare, string simbol)
        {
            switch (valoare)
            {
                case 11: return $"J_of_{simbol}.png";
                case 12: return $"Q_of_{simbol}.png";
                case 13: return $"K_of_{simbol}.png";
                case 14: return $"A_of_{simbol}.png";
                default: return $"{valoare}_of_{simbol}.png";
            }
        }
        public void Amesteca()
        {
            for (int i = Carti.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = Carti[i];
                Carti[i] = Carti[j];
                Carti[j] = temp;
            }
        }

        public Carte DaCarte()
        {
            if (Carti.Count == 0)
            {
                MessageBox.Show("Nu mai sunt carti in pachet!");
                return null;
            }
            Carte c = Carti[0];
            Carti.RemoveAt(0);

            return c;
        }

        
    }
}

