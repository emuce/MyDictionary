using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<byte, string> plakaSehir = new MyDictionary<byte, string>();
            plakaSehir.Add(67, "Zonguldak");
            plakaSehir.Add(41, "Kocaeli");
            plakaSehir.Add(21,"Diyarbakır");
            plakaSehir.Add(64,"Uşak");
            plakaSehir.Add(78,"Karabük");

            Console.WriteLine("Plaka No : " + plakaSehir.Key[0] + "\tŞehir : " + plakaSehir.Value[0]);
            Console.WriteLine("Plaka No : " + plakaSehir.Key[1] + "\tŞehir : " + plakaSehir.Value[1]);
            Console.WriteLine("Plaka No : " + plakaSehir.Key[2] + "\tŞehir : " + plakaSehir.Value[2]);
            Console.WriteLine("Plaka No : " + plakaSehir.Key[3] + "\tŞehir : " + plakaSehir.Value[3]);
            Console.WriteLine("Plaka No : " + plakaSehir.Key[4] + "\tŞehir : " + plakaSehir.Value[4]);

        }
    }
}
