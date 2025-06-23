namespace Ucenje.E17Vjezbanje
{
    public class Program
    {


        public Program()
        {
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("**************");
            Console.WriteLine("0. izlaz");
            Console.WriteLine("1. Zbrajanje dvaju brojeva");
            Console.WriteLine("**************************");
            OcitajOdabir();
        }

        private void OcitajOdabir()
        {
            switch(Pomocno.UcitajCijeliBroj("Unesi redni broj programa"))
            {
                case 0:
                Console.WriteLine("Doviđenja");
                    break;
                case 1:
                    //kreiranje instance klase Zadatak1
                    Console.WriteLine("1. zadatak");
                    Izbornik();
                    break;
                default:
                    Console.WriteLine("Ne postoji taj program");
                    Izbornik();
                    break;
            }
            
        }



    }
}
