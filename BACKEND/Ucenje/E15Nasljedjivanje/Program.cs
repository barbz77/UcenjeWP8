namespace Ucenje.E15Nasljedjivanje
{
    public class Program
    {
        public Program()
        {

            Console.WriteLine("Nasljedjivanje");


            var oso = new Osoba() { Ime = "Maria", Prezime = "Vrbesic" };

            Predavac pre = new() { Ime = "Karlo", Prezime = "Lot", IBAN = "HR14368987615" };

            Polaznik pol = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "095 / 782-493" };

            Polaznik pol1 = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "095 / 782-493" };


            //metode Equals, GetHashCode i ToString se izvode u 1. prolazu iz klase Objekt

            Console.WriteLine(pol.Equals(pol1));//False

            Console.WriteLine(pol.GetHashCode());// 43942917
            Console.WriteLine(pol1.GetHashCode());//59941933

            Console.WriteLine(pol.ToString());//Ucenje.E15Nasljedjivanje.Polaznik

            //2. prolaz, nakon pisanja prepisanih metoda
            Console.WriteLine(pol);//ovo je jednako kao pol.ToString(), Karla Sep 095 / 782-493

            Console.WriteLine(pre);




        }

    }
}
