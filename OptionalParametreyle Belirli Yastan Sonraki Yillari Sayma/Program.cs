using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParametreyle_Belirli_Yastan_Sonraki_Yillari_Sayma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Varsayılan Yaşı 18 yerine kendi yaşım 20 olarak aldım

            Console.WriteLine("Yaş Belirtilmedi: " + YasFarki() + " yaş büyüktür"); //Bu örnekte yaşı belirtmediğim için varsayılan yaş hesaba katılacaktır.

            Console.WriteLine("Yaş 56: " + YasFarki(56) + " yaş büyüktür");

            Console.WriteLine("Yaş 52: " + YasFarki(52) + " yaş büyüktür");

            Console.WriteLine("Yaş 28: " + YasFarki(28) + " yaş büyüktür");

            Console.ReadKey();

        }

        static int YasFarki(int yas = 20)
        {
            return yas - 20;
        }

    }
}