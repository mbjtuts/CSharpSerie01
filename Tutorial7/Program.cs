using System;

namespace Tutorial7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kosol Program");

            InsertCodeHere code = new InsertCodeHere();
            Console.WriteLine(code.Name);
            code.Name = "Greta";
            Console.WriteLine(code.Name);

            Console.WriteLine("Tyk hvilken som helst tast for at lukke programmet");
            Console.ReadKey();
        }
    }
}
