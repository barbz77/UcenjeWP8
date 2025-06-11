namespace Ucenje
{
    internal class CiklicnaTablica
    { public static void Izvedi()
        {
            Console.WriteLine("Ciklična tablica ");



            int[,] tablica = {
                {9,10,11,12,13},
                {8,21,22,23,14},
                {7,20,25,24,15},
                {6,19,18,17,16},
                {5,4,3,2,1},
            };

            Console.Write(" {0} ", tablica[0, 0]);
            Console.Write(" {0} ", tablica[0, 1]);
            Console.Write(" {0} ", tablica[0, 2]);
            Console.Write(" {0} ", tablica[0, 3]);
            Console.WriteLine(" {0} ", tablica[0, 4]);

            Console.Write(" {0} ", tablica[1, 0]);
            Console.Write(" {0} ", tablica[1, 1]);
            Console.Write(" {0} ", tablica[1, 2]);
            Console.Write(" {0} ", tablica[1, 3]);
            Console.WriteLine(" {0} ", tablica[1, 4]);

            Console.Write(" {0} ", tablica[2, 0]);
            Console.Write(" {0} ", tablica[2, 1]);
            Console.Write(" {0} ", tablica[2, 2]);
            Console.Write(" {0} ", tablica[2, 3]);
            Console.WriteLine(" {0} ", tablica[2, 4]);

            Console.Write(" {0} ", tablica[3, 0]);
            Console.Write(" {0} ", tablica[3, 1]);
            Console.Write(" {0} ", tablica[3, 2]);
            Console.Write(" {0} ", tablica[3, 3]);
            Console.WriteLine(" {0} ", tablica[3, 4]);


            Console.Write(" {0}  ", tablica[4, 0]);
            Console.Write(" {0}  ", tablica[4, 1]);
            Console.Write(" {0}  ", tablica[4, 2]);
            Console.Write(" {0}  ", tablica[4, 3]);
            Console.WriteLine(" {0}  ", tablica[4, 4]);

        

        }
    }
}
