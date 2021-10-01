using System;

namespace Tutorial5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person();
            person2.Name = "Grete";
            person2.Alder = 18;
            Person.id = 1;
            Console.WriteLine($"{person.Name} er {person.Alder} år gammel");
            Console.WriteLine($"{person2.Name} er {person2.Alder} år gammel");
        }
    }

    class Person {
        public static int id = 0;
        public string Name = "Hans";
        public int Alder = 21;
    }
}
