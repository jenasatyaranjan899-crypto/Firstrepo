using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desctroctor
{
    internal class Const
    {
       static int a;
       static int b;
        static Const()
        {
            a = 10;
            b = 20;
        }
        static int add()
        {
            int add = a + b;
            Console.WriteLine("The sum of two numbers "+add);
            return add;

        }

        static void Main(string[] args)
        {
            Const.add();

        }
    }
}
