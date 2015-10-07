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

            Del handler = new Del(DelegateMethod);
            handler("Hello World");
            Program.DelegateMethod("Hello again...");

            X xObj = new X();
            xObj.HeyAlso();
            X.Hey();
            
            Console.ReadKey();
        }

        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message + " from DelagateMethod.");
        }
    }

    class X
    {
        //"static" is only for this class, not for each object...:
        public static void Hey()
        {
            Console.WriteLine("Hello from Hey");
        }

        public void HeyAlso()
        {
            Console.WriteLine("Hello from HeyAlso");
        }
    }
}
