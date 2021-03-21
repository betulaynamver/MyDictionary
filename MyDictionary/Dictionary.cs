using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Dictionary<TKey, TValue>
    {
        TKey[] Numara;
        TValue[] Cicek;
        public Dictionary()
        {
            Numara = new TKey[0];
            Cicek = new TValue[0];
        }
        public int Length { get; internal set; }

        public void Add(TKey numara, TValue cicek)
        {
            TKey[] tempKey = Numara;
            TValue[] tempValue = Cicek;

            Numara = new TKey[Numara.Length + 1];
            Cicek = new TValue[Cicek.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                Numara[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                Cicek[i] = tempValue[i];
            }
            Numara[Numara.Length - 1] = numara;
            Cicek[Cicek.Length - 1] = cicek;
            //Console.WriteLine(numara);
            //Console.WriteLine(cicek);
            Console.WriteLine("Çiçek kodu, İsmi: " + numara + " , "+ cicek);
        }
        public int Count
        {
            get { return Numara.Length; }
        }
       
    }
}
