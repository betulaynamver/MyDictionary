using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary sınıfı, içinde benim belirlediğim bir key'e uygun olarak değer saklar.
             Zorunluluğu vardır:
            -Key türünü belirlememiz şarttır. (int, string, float...) */

            Dictionary<int, string> Cicek = new Dictionary<int, string>();
            //Veri ekliyoruz.
            Cicek.Add(101, "Gül");
            Cicek.Add(103, "Papatya");
            Cicek.Add(104, "Lale");

            var eleman = Cicek.Count; //Değer sayma özelliği vardır.

            Console.WriteLine("Çiçek çeşidi: " + Cicek.Count);

            for (int i = 0; i < Cicek.Length; i++)
            {
                Console.WriteLine(Cicek);
            }
        }
        
    }
}
