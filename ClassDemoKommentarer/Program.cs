using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKommentarer
{
    class Program
    {
        static void Main(string[] args)
        {
            KommentarWorker worker = new KommentarWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
