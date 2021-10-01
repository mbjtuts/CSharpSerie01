using System;

namespace Tutorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst = "Hans";
            int helTal = 12;
            double kommaTal = 24.5;
            Console.WriteLine($"{tekst} har {helTal} penge i banken og {kommaTal} penge i sin pung");
            Console.WriteLine(tekst + " har " + helTal + " penge i banken og " + kommaTal + " penge i sin pung");
            Console.WriteLine("{0} har {1} penge i banken og {2} penge i sin pung", tekst, helTal, kommaTal);
        }
    }
}
