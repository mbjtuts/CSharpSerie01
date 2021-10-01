using System;

namespace Tutorial6
{
    public class InsertCodeHere
    {
        string _navn = "";
        int _alder = 0;
        public InsertCodeHere(int alder, string navn){
            _alder = alder;
            _navn = navn;
            Console.WriteLine($"{_navn} er {_alder} år gammel");
        }
    }
}