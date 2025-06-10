namespace Ucenje
{
    class E08WhilePetlja
    {
        public static void Izvedi()
        {
            Console.WriteLine("While petlja");

            // while radi s bool tipom podatka

            //beskonacna petlja

            while (true)
            {
                Console.WriteLine("Ispis iz beskonacne petlje nakon cega je break");
                break;
            }

            Console.WriteLine("********************************");

            //u while se ne mora uci

            int i = 10;
            while (i < 10)
            {
                Console.WriteLine(i++);
            }
            Console.WriteLine("********************************");

            i = 0;//resetirana jedno te ista varijabla
            while (i < 10)
            {
                Console.WriteLine(++i);
            }

            Console.WriteLine("********************************");


            i = 0;
            int j = 1;
            while(i<10 && j == 1)// mose ici i || te !
            {
                Console.WriteLine(i++);
            }

            //continue i break rade isto kao i u for
            //gnjezdjenje je isto kao u for, moze se kombinirati for i while

            while (i > 10)
            {
                while (j == 1)
                {
                    //kako prekinuti petlju while(1 > 10)?
                    goto labela;
                }
            }

        labela:
            Console.WriteLine("Gotov");





        }
    }
}
