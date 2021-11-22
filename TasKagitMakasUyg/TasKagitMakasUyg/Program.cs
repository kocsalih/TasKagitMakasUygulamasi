using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TasKagitMakasUyg
{
    class Program
    {
        static void Main(string[] args)
        {

        basla:
            Console.Clear();
            Random rst = new Random();
            string[] uygulama = { "taş", "kağıt", "makas" };

            int sistem = 0, kul = 0;

            Console.WriteLine("**********************");
            Console.WriteLine("TAŞ KAĞIT MAKAS OYUNU");
            Console.WriteLine("**********************");
            Console.WriteLine("\n3 OLAN KAZANIR");

            for (; ; ) // 3 olan kazanacak sonsuz döngü
            {
                
                Console.Write("SEÇİMİNİZİ YAPINIZ: Taş-Kağıt-Makas: ");
                string kullanıcı = Console.ReadLine().ToLower();
                int pc = rst.Next(1, 4);

                if (kullanıcı == "taş")//1 olsun, taş=1
                {
                    if (pc == 1)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Berabere");
                    }

                    else if (pc == 2)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Sistem kazandı");
                        sistem++;
                    }

                    else if (pc == 3)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Kazandınız");
                        kul++;
                    }
                }

                if (kullanıcı == "kağıt")//2 olsun, kağıt=2
                {
                    if (pc == 2)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Berabere");

                    }

                    else if (pc == 3)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Sistem kazandı");
                        sistem++;
                    }

                    else if (pc == 1)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Kazandınız");
                        kul++;
                    }
                }

                if (kullanıcı == "makas")//3 olsun, makas=3
                {
                    if (pc == 3)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Berabere");
                    }

                    else if (pc == 1)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Sistem kazandı");
                        sistem++;            
                    }

                    else if (pc == 2)
                    {
                        Console.WriteLine("{0} - {1}", uygulama[pc - 1], kullanıcı);
                        Console.WriteLine("Kazandınız");
                        kul++;               
                    }                     
                }

                Console.WriteLine("_____________________________________");

                if (kul == 3)
                {
                    Console.WriteLine("**********************\n{0} - {1} TEBRİKLER KAZANDINIZ\n**********************", sistem, kul);
                    goto sor;
                }
                else if (sistem == 3)
                {
                    Console.WriteLine("{0} - {1} KAYBETTİNİZ", sistem, kul);
                    goto sor;
                }


            }

        sor:
            Console.WriteLine("Tekrar oynamak istiyor musunuz? E/H");
            string cevap = Console.ReadLine().ToLower();
            if (cevap == "e") goto basla;
               
            
        }
    }
}
