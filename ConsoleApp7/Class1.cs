using ConsoleApp7;
using System;
namespace ConsoleApp7
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee();
            person1.AddInf();
            person1.ShowInf();


            Fly fly1 = new Fly("Adam Aircraft Industries", "Airlines BB2", 2003, "passenger plane");
            fly1.ShowInf();
        }

    }
}
