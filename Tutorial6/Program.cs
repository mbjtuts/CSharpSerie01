using System;

namespace Tutorial6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kosol Program");

            InsertCodeHere code = new InsertCodeHere(21, "Hans");
            InsertCodeHere code2 = new InsertCodeHere(18, "Greta");

            Console.WriteLine("Tyk hvilken som helst tast for at lukke programmet");
            Console.ReadKey();
        }
    }
}
