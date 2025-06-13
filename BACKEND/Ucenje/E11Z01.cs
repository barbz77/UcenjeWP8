namespace Ucenje
{
    class E11Z01
    {
        public static void Izvedi()
        {
            int b;
            for(; ; )
            {
                Console.WriteLine("Unesi cijeli broj: ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Pokusajte ponovno.");
                }
              

            }
            
            if (b % 2 == 0)
            {
                Console.WriteLine("Uneseni broj {0} je paran");
            }
            else
            {
                Console.WriteLine("Uneseni broj {0} je neparan");
            }




        }
    }
}
