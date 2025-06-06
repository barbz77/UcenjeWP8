namespace Ucenje
{
    internal class E03Operatori
    {
        public static void Izvodi()
        {
            Console.WriteLine("E03Operatori");

            // = dodjeljivanje vrijednosti s desne na lijevu stranu

            // + kao operator nadoljepljivanja (concate)

            string grad = "Osijek";
            string ime = "Edunova";


            Console.WriteLine(grad + " " + ime + " " + 5);

            Console.WriteLine("{0} {1} {2}", grad, ime, 5); // bolje


            // operator modulo % -> parnosti broja

            Console.WriteLine(8 % 2); //0

            int b = 9 % 2;

            Console.WriteLine(b);


            // uvećanje broja za 1
            int i = 0;

            // uvećaj za 1
            i = i + 1;

            i += 1;

            i++; // prvo se koristi pa se uveća

            ++i; // prvo se uveća pa se koristi

            // increment i decrement (++i, i++,  --i, i--);

            int k = 1, j = 0;

            k = ++k - j++; // k = 2 - 0, j = 1

            Console.WriteLine(--k + j++); // što se ispisuje 1 + 1 = 2


        }
    }
}
