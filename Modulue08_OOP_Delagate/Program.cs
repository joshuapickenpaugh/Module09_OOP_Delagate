//Joshua Pickenpaugh, IN2017, Adv.C#
//October 7th, 2015 (Delagtes)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Del(string message);

namespace Modulue08_OOP_Delagate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
