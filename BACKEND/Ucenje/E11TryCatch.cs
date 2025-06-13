namespace Ucenje
{
    class E11TryCatch
    {
        public static void Izvedi()
        {
            Console.WriteLine("Try Catch");



            int b = 0;

            /*try blok se uvijek izvodi
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Niste unijeli broj");
            }
            
             Console.WriteLine(b+1);*/



            /*while (true)
            {

                try
                {
                    Console.Write("Unesi broj: ");
                    b = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj");
                }


            }

            Console.WriteLine(b + 1);*/






            //napisati program koji za dva unesena cijela broja ispisuje njihov zbroj

            int pb, db;

            while (true)
            {

                Console.WriteLine("Unesi prvi broj: ");
                try
                {
                    pb = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli prvi broj!");
                }
            }

            while (true)
            {
                Console.WriteLine("Unesi drugi broj: ");
                try
                {
                    db = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli drugi broj!");
                }
            }

            Console.WriteLine("Rezultat {0} + {1} = {2}", pb, db, pb+db);

            //dobro osiguranje unosa broja

            string unosniNizZnakova;
            while (true)
            {
                Console.Write("Unesi broj: ");
                unosniNizZnakova = Console.ReadLine().Trim();

                if (unosniNizZnakova.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugacak niz znakova");
                    continue;
                }

                try
                {
                    b = int.Parse(unosniNizZnakova);
                    if (b > 10000)
                    {
                        Console.WriteLine("Uneseni broj je prevelik, unesite manji broj");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj!");
                }

            }


            Console.WriteLine("Unesen je broj {0}", b);

        }


    }
}
