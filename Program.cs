using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> yemek = new MyDictionary<string, int>();
            yemek.Add("Adana",1);
            yemek.Add("pide",2);
            yemek.Add("Mantı",3);
            yemek.Add("Menemen",4);
            yemek.Add("İçli Köfte",5);
            yemek.Add("Beyti",6);
            yemek.Add("Peynir Helvası",7);
            yemek.Add("Cağ Kebabı",8);

            foreach (var yemekler in yemek.Yemek)
            {
                Console.WriteLine("Yemeğin adı :" +yemekler );
            }

            foreach (var sirasi in yemek.Numara)
            {
                
            }
        }
    }
}
