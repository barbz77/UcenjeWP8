namespace Ucenje
{
    class E13Rekurzija
    {
        public static void Izvedi()
        {
            //Izvedi();//losa rekurzija
            Console.WriteLine(zbroj(100));
        }

        private static int zbroj(int i)
        {
            if (i == 1)
            {
                return 1;
            }
            return i + zbroj(i - 1);
        }




    }
}
