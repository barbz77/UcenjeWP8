using System.Security.Cryptography;
using System.Threading.Channels;

namespace Ucenje
{
    class E12Metode
    {
        public static void Izvedi()
        {
            Console.WriteLine("Metode");

            Tip1();
            for(int i = 0; i < 10; i++)
            {
                Tip1();
            }


            Tip2(2);

            Tip2(7);

            Tip2(2, 3);//po zavrsetku metode nema povratne vrijednosti

            Tip3();// po zavrsetku metode vracena vrijednost nije nikome dodijeljena

            string s = Tip3();

            Console.WriteLine(s);

            Console.WriteLine(prim(5));
            Console.WriteLine(prim(100000));
            for (int i = 1; i <= 100; i++)
            {
                if (prim(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine(ucitajCijeliBroj("Unesi 1. broj")+ ucitajCijeliBroj("Unesi 2. broj"));

        }//kraj metode Izvedi


        //metoda 1

        static void Tip1()
        {
            Console.WriteLine("Ispis iz metode tipa 1 koja je bez nacina pristupa - vidljiva samo u klasi");
            Console.WriteLine("******");
            Console.WriteLine("Edunova");
            Console.WriteLine("******");
        }


        //Metoda 2

        private static void Tip2(int i)
        {
            Console.WriteLine("Primio sam broj {0}", i);
        }


        //popis metode:
        //nacina pristupa
        //static ili ne(prazna)
        //tip podataka(void ili neki tip)
        // -> naziv
        // -> lista parametara


        //method overloading
        private static void Tip2(int i, int j)
        {
            Console.WriteLine("Zbroj je {0}", i+j);
        }

        //Metoda tipa 3
        //ne prima parametre, vraca vrijednost

        protected static string Tip3()
        {
            Console.WriteLine("Izvodim metodu Tip3");
            return "Web programiranje";
        }




        //Metoda tipa 4
        //prima parametre, vraca vrijednost

        public static bool prim(int broj)
        {
            //matematicki princip hipoteze
            for(int i = 2; i < broj; i++)
            {
                if(broj % i == 0)
                {
                    return false;// short circuiting
                }
            }


            return true;
        }

        public static int ucitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokusajte ponovno");
                }
            }
        }


         

        














    }//kraj klase





}
