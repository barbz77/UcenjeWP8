namespace Ucenje
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {

            Console.WriteLine("LJubavni kalkulator");


            Console.WriteLine("Unesite svoje ime: ");

            string prvoIme = Console.ReadLine();

            Console.WriteLine("Unesite ime svoje simpatije: ");

            string drugoIme = Console.ReadLine();

            Console.WriteLine("Unijeli ste: {0} + {1}", (prvoIme), (drugoIme));

            string obaImena = (prvoIme + drugoIme);            

           
            var zbrojSlova = new Dictionary<char, int>();
            foreach (char c in obaImena)
            {
                if (char.IsLetter(c))
                {
                    if (zbrojSlova.ContainsKey(c))
                    {
                        zbrojSlova[c]++;
                    }
                    else
                    {
                        zbrojSlova.Add(c, 1);
                    }
                }
            }
          
            List<int> trenutniBroj = new List<int>();
            foreach (char c in obaImena)
            {
                if (char.IsLetter(c))
                {
                   
                    trenutniBroj.Add(zbrojSlova[c]);
                }
            }           

            while (trenutniBroj.Count > 2)
            {
                List<int> idućiBroj = new List<int>();
                int lijevo = 0;
                int desno = trenutniBroj.Count - 1;

                while (lijevo <= desno)
                {
                    if (lijevo == desno)
                    {
                        idućiBroj.Add(trenutniBroj[lijevo]);
                    }
                    else
                    {
                        int sum = trenutniBroj[lijevo] + trenutniBroj[desno];
                      
                        idućiBroj.Add(sum);
                    }
                    
                    lijevo++;
                    desno--;
                }
                trenutniBroj = idućiBroj; 
            }

           
            int rezultat = 0;
            if (trenutniBroj.Count == 2)
            {
              
                rezultat = int.Parse(string.Join("", trenutniBroj));
            }
            else if (trenutniBroj.Count == 1)
            {
               
                rezultat = trenutniBroj[0];
            }

            
            if (rezultat > 100)
            {
                rezultat %= 100;
                
                if (rezultat < 10) rezultat += 10;
            }

            Console.WriteLine($"Vaša kompatibilnost je: {rezultat}%");











        }
    }
}