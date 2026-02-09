using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3_tdd_Geometrie
{
    // Klasse muss public sein, sonst kann sie das 
    // externe Testprojekt nicht nutzen.
    public class Rechteck 
    {
        private int breite;
        private int hoehe;


        public Rechteck() // Parameterloser Konstruktor
        {
            Breite = 0;
            Hoehe = 0;
        }

        public Rechteck(int breite, int hoehe)
        {
            Breite = breite;
            Hoehe = hoehe;

        }

        public int Breite { 
            get { return breite; } 
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Breite)); // Exception für Breite_ZuNiedrigerWertWirftException()
                breite = value;
            }
            
        }
        public int Hoehe { 
            get { return hoehe; } 
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Hoehe)); // Exception für Hoehe_ZuNiedrigerWertWirftException()

                hoehe = value;
            }
        }

        public int Umfang()  // Umfang definieren
        {
            return 2 * (breite + hoehe);
        }

        public int Flaeche() // Fläche definieren
        {
            return breite * hoehe;
        }


        public void Skalieren(double faktor)
        {
            if (faktor <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            breite = Convert.ToInt32(breite * faktor);
            hoehe = Convert.ToInt32(hoehe * faktor);
        }
    }
}
