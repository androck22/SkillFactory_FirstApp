using System;

namespace SkillFactory_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Andrew";
            Console.WriteLine(myName);

            Console.WriteLine("\tПривет, мир");
            Console.WriteLine("\tМне 32 года");
            Console.WriteLine("\tMy name is \nAndrew");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');

            Console.ReadKey();
        }
    }
}
