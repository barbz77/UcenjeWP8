namespace Ucenje
{
    class E07ForPetlja
    {
        public static void Izvedi()
        {
            Console.WriteLine("E07ForPetlja");

            //S dosadasnjim znanjem ispisi Hrvatska - Ceska 5:1 10 puta)

            //rjesenje ali nije Best practice - najbolja praksa
            Console.WriteLine("Hrvatska - Ceska 5:1");
            Console.WriteLine("Hrvatska - Ceska 5:1"); 
            Console.WriteLine("Hrvatska - Ceska 5:1"); 
            Console.WriteLine("Hrvatska - Ceska 5:1");
            Console.WriteLine("Hrvatska - Ceska 5:1");
            Console.WriteLine("Hrvatska - Ceska 5:1");
            Console.WriteLine("Hrvatska - Ceska 5:1");
            Console.WriteLine("Hrvatska - Ceska 5:1");
            Console.WriteLine("Hrvatska - Ceska 5:1");
            Console.WriteLine("Hrvatska - Ceska 5:1");

            Console.WriteLine("************************");

            for(int i = 0; i < 10; i++) //ne dolazi ;
            {
                Console.WriteLine("Hrvatska - Ceska 5:1");
            }

            Console.WriteLine("*************************");

            //ispisi prvih 100000 brojeva

            for(int i=0;i<10; i++)
            {
                Console.WriteLine("{0}.", i+1);
            }

            Console.WriteLine("***************************");

            //ispisi zbroj prvi 100 brojeva

            Console.WriteLine((100 / 2) * 100 + 100 / 2);
            Console.WriteLine(100/2*(100+1));

            int suma = 0;
            for(int i = 0; i < 100; i++)
            {
                suma = suma + (i + 1);
            }

            Console.WriteLine(suma);

            //Big O notacija

            Console.WriteLine("*************************");

            //ispisi brojeve od 10 do 1

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("**************************");

            //ispisi svaki 5 broj od 1 do 90

            for(int i = 1; i <= 90; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************");

            //ispisi sve parne brojeve od 79 do 123

            for(int i = 79; i<=123; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************");

            int odKuda = 2, doKuda = 8;

            for(int i = odKuda; i < doKuda; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************");

            string grad = "Osijek";
            for(int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }


            Console.WriteLine("*************************");

            //ugnjezdjivanje petlje
            for(int i = 1; i <= 10; i++){
                 for(int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} ",i*j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("*************************");

            //mogucnost preskakanja (nastavljanja od pocetka) i nasilnog prekida petlje

            for(int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                if (i == 7)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("*************************");

            //beskonacna petlja
            for(; ; )
            {
                Console.WriteLine("{0} {0} {0} {0} {0} {0} {0} {0} {0} "
                    , new Random().Next()
                    , new Random().Next()
                    , new Random().Next()
                    , new Random().Next()
                    , new Random().Next(), new Random().Next());
                Thread.Sleep(200);
            }


        }
    }
}
