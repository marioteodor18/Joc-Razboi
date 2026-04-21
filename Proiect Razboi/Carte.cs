using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Razboi
{
    public class Carte
    {
        
        private int valoare;
        private String imagine;

        public Carte( int valoare, String imagine)
        {
          
           this.valoare = valoare;
            this.imagine = imagine;

        }
     

        public int Valoare
        {
            get { return valoare; }
        }

        public string Imagine
        {
            get { return imagine; }
        }
    }
}
    

