using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nazli.Topcu203801058
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rastgele = new Random();
            int random = 0;
            int sayiTahmini = 0;
            int hak = 0;
            int oyunseviyesi = 0;
            int i;

                Console.WriteLine("Lütfen bir seviye seçiniz;");
                Console.WriteLine("Kolay seviye için 1'e\nOrta seviye için 2'ye\nZor seviye için 3'e basınız.\n");
                oyunseviyesi = Convert.ToInt32(Console.ReadLine());
            do
            {
                

                switch (oyunseviyesi)
                {
                    case 1:

                        Console.WriteLine("\nKolay seviyeyi seçtiniz. Tahmin hakkınız 6. Tahmin edilecek sayı aralığınız 1-10.");
                        hak = 6;
                        random = rastgele.Next(1, 10);

                        break;

                    case 2:

                        Console.WriteLine("\nOrta seviyeyi seçtiniz. Tahmin hakkınız 4.Tahmin edilecek sayı aralığınız 1-25.");
                        hak = 4;
                        random = rastgele.Next(1, 25);

                       
                            break;            
                case 3:
                
                    Console.WriteLine("\nZor seviyeyi seçtiniz. Tahmin hakkınız 2. Tahmin edilecek sayı aralığınız 1-50.");
                hak = 2;
                random = rastgele.Next(1, 50);

                break;
                }
                for ( i = 1; i <= hak; i++)
                {
                    Console.WriteLine("Sayı Tahmini Gir : ");
                    sayiTahmini = Convert.ToInt32(Console.ReadLine());
                    if (random == sayiTahmini)
                    {
                        Console.WriteLine("Tebrikler Bildiniz....");
                        Console.WriteLine("Oyun Bitti.... ");
                        break;
                    }
                    Console.WriteLine("Bilemediniz Kalan Hakkınız :  " + (hak - i));
                    if ((hak - i) == 0)
                        Console.WriteLine("Oyun Bitti.... ");
                }
  
            } while (oyunseviyesi != 1 && oyunseviyesi != 2 && oyunseviyesi != 3);

            Console.ReadKey();
}
            }
    }
            
    

