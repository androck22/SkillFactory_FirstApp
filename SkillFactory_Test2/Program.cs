using System;

namespace SkillFactory_Test2
{
    class Program
    {
        static void Main(string[] args)
        {
			string myName = "Andrew";
			byte myAge = 32;
			bool myPet = false;
			double myShoeSize = 41.5;

			Console.WriteLine("My name is " + myName);
			Console.WriteLine("My age is " + myAge);
			Console.WriteLine("Do I have a pet? " + myPet);
			Console.WriteLine("My shoe size is " + myShoeSize);

            Console.WriteLine("IntMin {0} ", int.MinValue);
            Console.WriteLine("IntMax {0} ", int.MaxValue);
			Console.ReadKey();
		}
    }
}
