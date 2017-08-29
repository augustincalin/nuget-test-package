using MyNugetPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46 {
    class Program {
        static void Main(string[] args) {
            MyUsefulClass c = new MyUsefulClass();
            Console.WriteLine(c.GetMessage(".Net Framework 4.6 app"));
            string page = c.GetGoogle().Result;
            Console.ReadLine();
        }
    }
}
