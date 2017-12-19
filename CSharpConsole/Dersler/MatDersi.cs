using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Dersler
{
    public class MatDersi
    {
        public int Topla()
        {

            Console.Write("a yı girin");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("b yı girin");
            int b = Convert.ToInt16(Console.ReadLine());


            return a + b;
        }
        public int Çıkar()
        {
            Console.Write("c yı girin : ");
            int c = Convert.ToInt16(Console.ReadLine());
            Console.Write("d yı girin : ");
            int d = Convert.ToInt16(Console.ReadLine());

            return c - d;
        }
        public int Çarp()
        {
             Console.Write("e yı girin : ");
            int e = Convert.ToInt16(Console.ReadLine());
            Console.Write("f yı girin : ");
            int f = Convert.ToInt16(Console.ReadLine());
            return e * f; 
        }
        public int böl()
        {
            Console.Write("g yı girin : ");
            int g = Convert.ToInt16(Console.ReadLine());
            Console.Write("h yı girin : ");
            int h = Convert.ToInt16(Console.ReadLine());
            return g / h;
        }

        public void dört_işlem()
        {
           
            böl();

            
        }
        

        

            
        }
    }

