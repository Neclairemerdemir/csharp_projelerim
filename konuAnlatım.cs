using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konuAnlatım
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi1;
            double sayi2 ;
            // bu satır aynı javadaki gibi değişkenlerimizi tanımlamamızı sağlar 
            
            Console.WriteLine("Sayı 1 'i giriniz :");
            // bu satır printf gibidir . ekrana yazdırmayı sağlar

            sayi1 = Convert.ToInt32(Console.ReadLine());
            // bu satır kullanıcıdan değer almayı saglar 
            // Convert.ToInt32 yapısı kullanılır 
            // To dan sonra değişkenin yapısı neyse o tür yazılır
            // int değerleri için 32 de yazılır 
            

            Console.WriteLine("Sayi 2 yi giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            double toplam = sayi2 + sayi1;

            Console.WriteLine("iki sayının yoplamı :"+ toplam);
            // 1. yol bu şekilde yazmak
            // bu yolda + kullanırsan toplam direkt en sona eklenir 

            Console.WriteLine("iki sayının toplamı :{0} ", sayi2 + sayi1);
            // 2.yol bu şekilde 
            // bu yolda ise {0} kullanarak yazdırılmak istenen değerin yeri direkt olarak belirtilebilir 

            Console.WriteLine("sayılar 1.sayı :" + sayi1 + "\t 2. sayi :" + sayi2);
            // yazımlarda  +  işareti kullanılarak yazılabilir 


            // WrteLine kısmındaki line aşağı satıra geçmeyi ifade eder

            //Write dersen alt satıra yazmadan da kullanabilrisin 

            // not : , kullanırsan {0} bunu kullanmak zorundasın 
            //       + kullanırsan kullanmana gerek yok en sona ekler 
        }

    }
}
