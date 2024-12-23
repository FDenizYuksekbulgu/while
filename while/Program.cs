using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            // SORU 1: Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırıldı.

            int i = 0;


            while (i < 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                i++;
            }

            // SORU 2:  1 ile 20 arasındaki sayıları konsol ekranına yazdırıldı.

            int i = 2;
            while (i < 20)

            {
                Console.WriteLine(i);
                i++;
            }

            //SORU 3: 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırıldı.

            int i = 2;

            while (i < 20)
            {


                {
                    Console.WriteLine(i);
                    i += 2;
                }

            }

            //SORU 4: 50 ile 150 arasındaki sayıların toplamını ekrana yazdırıldı.

            int i = 51;
            int toplam = 0;

            while (i < 150)

            {

                toplam += i;
                i++;
            }
            Console.WriteLine($"50 ile 150 arasındaki sayıların tolpamı: {toplam}");

            //SORU 5: 1 ile 120 arasındaki tek  sayıların toplamları ekrana yazdırıldı.


            int i = 1;
            int toplam = 0;

            while (i < 120)
            {
                toplam += i;
                i += 2;
            }
            Console.WriteLine($"1 ile 120 arasındaki tek  sayıların toplamı: {toplam}");

            //SORU 5: 1 ile 120 arasındaki çift sayıların toplamları ekrana yazdırıldı.

            int i = 2;
            int toplam = 0;

            while (i < 120)

            {
                toplam += i;
                i += 2;
            }
            Console.WriteLine($"1 ile 120 arasındaki çift  sayıların toplamı: {toplam}");


        }
    }
}
