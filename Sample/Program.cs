using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    internal class Program
    {
        public void Substraction()
        {
            int a = 30, b = 20, c;
            c = a - b;
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            Program g = new Program();
            g.Substraction();
            Console.ReadLine();
        }
    }
}
