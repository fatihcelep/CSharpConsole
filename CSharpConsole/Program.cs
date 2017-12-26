using CSharpConsole.Dersler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // var Maraba = new MerhabaDunyaDersi();
            // Maraba.Selamla();
            // Maraba.Küfret();

            //var matdersi = new MatDersi();

            //Console.Write("toplaması : " + matdersi.Topla() );
            //Console.ReadLine();

            //Console.Write("çıkartması : " + matdersi.Çıkar());
            //Console.ReadLine();

            //Console.Write("çarpması : " + matdersi.Çarp());
            //Console.ReadLine();

            //Console.Write("bölmesi : " + matdersi.böl());
            //Console.ReadLine();
            //Console.Clear();


            //matdersi.değerlendirme();
            //Console.ReadKey();

            var geo = new Geo();
            Console.WriteLine("kare alanı : " + geo.kareAlanı());
            Console.ReadKey();

            Console.Write("dikdörtgenin alanı :" + geo.dikdörtgen());
            Console.ReadKey();

            
            

           
            
        }
    }
}
