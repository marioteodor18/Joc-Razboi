using Proiect_Razboi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_Razboi
{


    public class Joc
    {
        public Pachet pachet;
        public Carte CarteCurentaJucator1;
        public Carte CarteCurentaJucator2;

        public int ScorJucator1 { get; private set; } = 0;
        public int ScorJucator2 { get; private set; } = 0;

        public Joc()
        {
            pachet = new Pachet();
            pachet.Amesteca();
        }





        public void ComparareCarti()
        {
            if (CarteCurentaJucator1 == null || CarteCurentaJucator2 == null)
            {
                MessageBox.Show("Apasa mai intai butonul 'Imparte Carti' !");
                return;
            }

            if (CarteCurentaJucator1.Valoare > CarteCurentaJucator2.Valoare)
            {
                ScorJucator1++; 
                MessageBox.Show("Jucatorul 1 castiga runda!");
            }
            else if (CarteCurentaJucator1.Valoare < CarteCurentaJucator2.Valoare)
            {
                ScorJucator2++; 
                MessageBox.Show("Jucatorul 2 castiga runda!");
            }
            else
            {
                MessageBox.Show("Razboi !");
            }

        }
    }
}

