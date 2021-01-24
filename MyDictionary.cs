using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] kArray;
        TValue[] vArray;
        TKey[] tempkArray;
        TValue[] tempvArray;

        public MyDictionary()
        {
            kArray = new TKey[0];
            vArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempkArray = kArray;
            tempvArray = vArray;
            kArray = new TKey[kArray.Length + 1];
            vArray = new TValue[vArray.Length + 1];

            // array'in uzunluğu arttırıldıktan sonra geçici array'lerdeki elemanları ana array'lerimize aktarıyoruz.
            for (int i = 0; i < tempkArray.Length; i++)
            {
                kArray[i] = tempkArray[i];
            }

            for (int i = 0; i < tempvArray.Length; i++)
            {
                vArray[i] = tempvArray[i];
            }

            // array^leri eşitleme işlemi bittikten sonra yeni elemanlarımızı ekliyoruz.
            kArray[kArray.Length - 1] = key;
            vArray[vArray.Length - 1] = value;
        }

        // iki metot listelerimizi consolda göstermemizi sağlar.
        public TKey[] Key
        {
            get { return kArray; }
        }

        public TValue[] Value
        {
            get { return vArray; }
        }
    }
}