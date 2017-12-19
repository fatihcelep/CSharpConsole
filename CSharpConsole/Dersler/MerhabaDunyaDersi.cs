using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Dersler
{
    public class MerhabaDunyaDersi
    {
        public void Selamla()
        {
            Console.WriteLine("Adın ne senin ?");
            string Ad = Console.ReadLine();
            Console.WriteLine("SelamünAleyküm " + Ad);
            Console.ReadLine();
        }
        public void Küfret()
        {
            Console.WriteLine("Al sana küfür!");
            Console.ReadLine();
        }
    }
}
