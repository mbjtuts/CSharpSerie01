using System;

namespace KlasseStruktur1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kosol Program");

            InsertCodeHere code = new InsertCodeHere();
            code.Run();

            Console.WriteLine("Tyk hvilken som helst tast for at lukke programmet");
            Console.ReadKey();
        }
    }
}
