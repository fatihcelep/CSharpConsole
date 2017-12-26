using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Dersler
{
    public class Geo
    {
        public int kareAlanı()
        {
            Console.Write("karenin kenarını giriniz :  ");
            int kenar = Convert.ToInt32(Console.ReadLine());
            return kenar*kenar;
        }
        public int dikdörtgen()
        {
            Console.Write("kısa kenarı giriniz :" );
            int kısakenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("uzun kenarı giriniz :  ");
            int uzunkenar = Convert.ToInt32(Console.ReadLine());
            return kısakenar * uzunkenar;

        }
    }
}
