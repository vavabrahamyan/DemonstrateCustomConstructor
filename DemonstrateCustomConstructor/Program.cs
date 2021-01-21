using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstrateCustomConstructor
{
    public class MyObject
    {
        private static MyOtherObject _staticObj = new MyOtherObject();

        private MyOtherObject _dynamicObj;

        public MyObject()
        {
            Console.WriteLine("MyObject constructor starting");
            Console.WriteLine("(Static data member constructed before " +
                              "this constructor)");
            Console.WriteLine("Now create nonstatic data member dynamically:");
            _dynamicObj = new MyOtherObject();
            Console.WriteLine("MyObject constructor ending");
        }
    }

    public class MyOtherObject
    {
        public MyOtherObject()
        {
            Console.WriteLine("MyOtherObject constructing");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main() starting");
            Console.WriteLine("Creating a local MyObject in Main():");
            MyObject localObject = new MyObject();

            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
