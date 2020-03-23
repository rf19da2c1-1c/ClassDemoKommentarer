using System;
using ClassDemoKommentarerLib.math;

namespace ClassDemoKommentarer
{
    internal class KommentarWorker
    {
        public void Start()
        {
            KommentarKlasse kom = new KommentarKlasse();

            int res = kom.ParseInt("7");
            Console.WriteLine("res er " + res);

            int sum = kom.Plus(5, 6);
            Console.WriteLine("summen er " + sum);

            double dres = KommentarKlasse.Plus(3.4, 5.7);
            Console.WriteLine("summen er " + dres);

        }
    }
}