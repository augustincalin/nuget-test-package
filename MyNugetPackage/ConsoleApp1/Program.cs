using MyNugetPackage;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUsefulClass c = new MyUsefulClass();
            Console.WriteLine(c.GetMessage(".Net core app"));
            string page = c.GetGoogle().Result;
            Console.ReadLine();
        }
    }
}
