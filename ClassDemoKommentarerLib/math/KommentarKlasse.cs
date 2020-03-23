using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoKommentarerLib.math
{
    /// <summary>
    /// Udregner forskellige tal
    /// </summary>
    public class KommentarKlasse
    {
        /// <summary>
        /// Lægger to heltal sammen
        /// </summary>
        /// <param name="x">værdi af det ene tal</param>
        /// <param name="y">værdi af det andet tal</param>
        /// <returns>summen af de to tal</returns>
        public int Plus(int x, int y)
        {
            return x + y;
        }


        /// <summary>
        /// lægger to kommatal sammen - kaldes på klassen
        /// </summary>
        /// <param name="x">værdi i første kommatal</param>
        /// <param name="y">værdi i andet kommatal</param>
        /// <returns>summen af de to tal</returns>
        public static double Plus(double x, double y)
        {
            // lægger de to tal sammen
            return x + y;
        }


        /// <summary>
        /// konverterer en sterng til et tal
        /// </summary>
        /// <param name="str">en tekst der ikke må være null og skal kun indeholde cifre</param>
        /// <returns>værdien af tekst strengen som heltal </returns>
        /// <exception cref="NullReferenceException">NullReferenceException hvis parameteren str er null</exception>
        /// <exception cref="NumberFormatException">NumberFormatException hvis parameteren str indeholder andet end cifre</exception>
        public int ParseInt(String str)
        {
            if (str == null) throw new NullReferenceException();

            return Int32.Parse(str);
        }
    }
}
