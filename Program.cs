using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sValue = "15";
            if (sValue.ToInt())
            {
                Console.WriteLine("Valid Integer");
            }
            else
            {
                Console.WriteLine("Not a valid Integer");
            }

            Console.ReadLine();
        }
    }
}
