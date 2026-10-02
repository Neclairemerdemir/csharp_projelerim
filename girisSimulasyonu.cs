using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace girisSimulasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bu projede sisteme giriş simüle edilmiştir
            int hak = 0;
            string kayitliSifre = "123456";
            string kayitliEposta = "eposta@gmail.com";
            string girilenSifre = " ";
            string girilenEposta = " ";

            while (hak <= 5)
            {
                Console.WriteLine("sifrenizi giriniz:");
                girilenSifre = Console.ReadLine();
                if (girilenSifre == kayitliSifre)
                {
                    Console.WriteLine("Giriş doğrulandı");
                    break;
                }
                else
                {
                    hak++;
                }
                if (hak == 5)
                {
                    Console.WriteLine("Eposta giriniz:");
                    girilenEposta = Console.ReadLine();
                   
                    if(girilenEposta == kayitliEposta)
                    {
                        Console.WriteLine("Şifreyi giriniz:");
                        girilenSifre = Console.ReadLine();
                        if (girilenSifre == kayitliSifre)
                        {
                            Console.WriteLine(" Giriş e posta aracılıgı ile onaylandı");
                            break;
                        }
                        else
                            Console.WriteLine("Şİfre hatalı işleminiz iptal edildi");
                    }
                    else 
                        Console.WriteLine   ("e posta hatalı işleminiz iptal edildi");
                    break;
                }
            }
        }
    }
}
