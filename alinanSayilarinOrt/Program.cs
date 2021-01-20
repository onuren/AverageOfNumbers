using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alinanSayilarinOrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç sayı gireceksiniz?");
            int kacSayi = Convert.ToInt32(Console.ReadLine());
            double sayi = 0;
            double toplam = 0;
            double ort = 0;


            for (int i = 1; i <= kacSayi; i++)
            {
                Console.WriteLine("Lütfen {0}. sayı giriniz: ",i);
                sayi = Convert.ToDouble(Console.ReadLine());
                toplam += sayi;
            }
            ort = (toplam / kacSayi);
            Console.WriteLine("Ortalaması: "+ort);
        }
    }
}
