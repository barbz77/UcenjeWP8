using System.Reflection.Metadata.Ecma335;

namespace Ucenje.E15Nasljedjivanje
{
    //Klasa Polaznik nasljedjuje sva javna i zasticena svojstva klase Osoba i svih drugih klasa koje Osoba nasljedjuje
    public class Polaznik : Osoba
    {
        public string Telefon { get; set; } = "";

        //prepisivanje metoda
        //method override
        public override string ToString()
        {
            return base.ToString() + " " + Telefon;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var p = obj as Polaznik;

            if (p.Ime.Equals(Ime) &&
                p.Prezime.Equals(Prezime) &&
                p.Telefon.Equals(Telefon)) return true;

            return false;



        }


    }
}
