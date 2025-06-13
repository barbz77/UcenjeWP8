namespace Ucenje
{
    class E11Z02
    {
        public static void Izvedi()
        {
            Console.WriteLine("E11Z02");
            //program unosi ime osobe i ispisuje uneseno ime

            string ime = Pomocno.UcitajString("Unesi ime osobe: ");
            if (!Pomocno.isCijeliBroj(ime))
            {
                Console.WriteLine(ime);
            }


        }


    }
}
