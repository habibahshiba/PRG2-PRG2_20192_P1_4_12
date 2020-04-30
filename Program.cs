using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_20192_P1_4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int alas, tinggi, Luas, Kell, hipotenusa;
            char pil;
            do
            {
                Console.Clear();
                Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
                Console.WriteLine("a. Hitung Luas");
                Console.WriteLine("b. Hitung Hipotenusa");
                Console.WriteLine("c. Hitung Keliling");
                Console.WriteLine("d. Keluar");
                Console.Write("Menu Pilihan : ");
                pil = Convert.ToChar(Console.ReadLine());

                switch (pil)
                {
                    case 'a':
                        Console.Write("Masukkan Alas :");
                        alas = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Masukkan Tinggi :");
                        tinggi = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, Luas = alas * tinggi / 2);
                        System.Console.ReadKey();
                        break;
                    case 'b':
                        Console.Write("Masukkan Alas :");
                        alas = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Masukkan Tinggi :");
                        tinggi = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Hipotenusa segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, hipotenusa = Convert.ToInt16(Math.Sqrt((alas * alas) + (tinggi * tinggi))));
                        System.Console.ReadKey();
                        break;
                    case 'c':
                        Console.Write("Masukkan Alas :");
                        alas = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Masukkan Tinggi :");
                        tinggi = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Keliling segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan", alas, tinggi, hipotenusa = Convert.ToInt16(Math.Sqrt((alas * alas) + (tinggi * tinggi))), Kell = alas + tinggi + hipotenusa);
                        System.Console.ReadKey();
                        break;
                    case 'd':
                        Environment.Exit(0); break;
                }
            } while (pil != 'd');
        }
    }
}
