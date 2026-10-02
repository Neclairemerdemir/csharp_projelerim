using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek1
{
    // bu proje elektrikli araçların ortam şartlarına göre elektrik kullanımını hesaplar.
    internal class Program
    {
        static void Main(string[] args)
        {
            double bataryaKap, tuketim;
            int egim, sicaklik;

            Console.WriteLine(" Arabanın batarya kapasitesini giriniz : ");
            bataryaKap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Arabanın 100 km de kaç KW tükettiğini giriniz:");
            tuketim = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ortamın sıcaklık değerini giriniz:");
            sicaklik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Arabanın geçeceği ortam eğimini giriniz (yokuş aşağı - olacak şekilde ):");
            egim = Convert.ToInt32(Console.ReadLine());


           double tuketimDgsimi =0 ;
           

            if (sicaklik < 15)
            {
                tuketimDgsimi += 15;
            }
             tuketimDgsimi += egim;


            double yeniTuketim ;
            yeniTuketim = tuketim + (tuketim * (tuketimDgsimi / 100));
         
            Console.WriteLine("Ortam şartlarına bağlı olarak arabanızın ortalama tüketimi:" + yeniTuketim);

            Console.WriteLine("Bu arac bu şartlarda {0:F3} km yol gidebilir." , bataryaKap / yeniTuketim *100 );


        }
    }
}
