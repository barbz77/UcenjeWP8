namespace Ucenje
{
    class E10ForEach
    {
        public static void Izvedi()
        {
            Console.WriteLine("foreach");

            Console.Write("Unesi ime grada: ");

            string grad = Console.ReadLine();


            //ispisi savko slovo grada jedno ispod drugog

            for(int i = 0; i < grad.Length; i++)
            {
                Console.WriteLine(grad[i]);
            }

            Console.WriteLine("********************************");

            foreach(char z in grad)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("********************************");

            int[] brojevi = { 1, 65, 56, 65, 689, 9, 8, 4, 545, 565, 65, 656, 5, };

            foreach(int i in brojevi)
            {
                Console.WriteLine(i);
            }

        }
    }
}
