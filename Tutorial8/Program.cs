using System;

namespace Tutorial8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kosol Program");

            InsertCodeHere code = new InsertCodeHere(true, 19);
            code.Run();

            Console.WriteLine("Tyk hvilken som helst tast for at lukke programmet");
            Console.ReadKey();
        }
    }
}
