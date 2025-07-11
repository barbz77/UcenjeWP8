namespace Ucenje
{
    internal class GeneratorLozinki
    {
        public static void Izvedi()
        {
            Console.Write("Unesite dužinu lozinke: ");
            int duzina;
           
            while (!int.TryParse(Console.ReadLine(), out duzina) || duzina <= 0)
            {
                Console.WriteLine("Nevažeći unos.");
                Console.Write("Unesite željenu dužinu lozinke: ");
            }

            
            Console.Write("Uključiti velika slova (DA/NE)? ");
            bool velikaSlova = (Console.ReadLine().ToUpper() == "DA"); 

            Console.Write("Uključiti mala slova (DA/NE)? ");
            bool malaSlova = (Console.ReadLine().ToUpper() == "DA");

            Console.Write("Uključiti brojeve (DA/NE)? ");
            bool brojevi = (Console.ReadLine().ToUpper() == "DA");

            Console.Write("Uključiti posebne znakove (DA/NE)? ");
            bool znakovi = (Console.ReadLine().ToUpper() == "DA");

            
            const string VelikeSlovaChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string MalaSlovaChars = "abcdefghijklmnopqrstuvwxyz";
            const string BrojeviChars = "0123456789";
            const string PosebniZnakoviChars = "!@#$%^&*()_+-=[]{}|;:,.<>?"; 

            
            string dostupniZnakovi = "";
            if (velikaSlova)
            {
                dostupniZnakovi += VelikeSlovaChars;
            }
            if (malaSlova)
            {
                dostupniZnakovi += MalaSlovaChars;
            }
            if (brojevi)
            {
                dostupniZnakovi += BrojeviChars;
            }
            if (znakovi)
            {
                dostupniZnakovi += PosebniZnakoviChars;
            }

            
            if (dostupniZnakovi.Length == 0)
            {
                Console.WriteLine("Greška");
                return; 
            }

           
            Random random = new Random();

            
            string lozinka = ""; 

            for (int i = 0; i < duzina; i++)
            {
               
                int randomIndex = random.Next(0, dostupniZnakovi.Length);

                
                char randomChar = dostupniZnakovi[randomIndex];

                
                lozinka += randomChar;
            }

            
            Console.WriteLine("\nGenerirana lozinka: " + lozinka);
        }
    }











}
    

