using System;

namespace Tutorial8
{
    public class InsertCodeHere
    {
        bool _boolean;
        public bool Boolean {get { return _boolean; } set { _boolean = value; }}
        int _alder;
        public int Alder {get {return _alder;} set {_alder = value;}}

        public InsertCodeHere(bool ting, int alder){
            Boolean = ting;
            Alder = alder;
        }

        public void Run(){
            if(Boolean == true)
            {
                Console.WriteLine("Boolean er sand");
            }
            else if(Boolean == false)
            {
                Console.WriteLine("Boolean er falsk");
            }

            if(Alder == 18 || Boolean == false)
            {
                Console.WriteLine("Gammel nok til at købe sprut");
            }
            else if (Alder < 18)
            {
                Console.WriteLine("Ikke gammel nok til at købe sprut");
            }else if (Boolean == true)
            {
                Console.WriteLine("Det her giver ikke mening");
            }            
            else
            {
                Console.WriteLine("Er over 18");
            }
        }
    }
}