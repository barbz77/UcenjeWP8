using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E05UvjetovanoGrananjeSwitch
    {
        public static void Izvodi()
        {
            Console.Write("Unesi ocjenu brojem: ");
            int broj = int.Parse(Console.ReadLine());

            switch (broj)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo Dobar");
                    break;
                case 5:
                    Console.WriteLine("Izvrstan");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Pa i to bi mogle biti ocjene ali nisu");
                    break;
                default:
                    Console.WriteLine("nije ocjena");
                    break;
            }



            string opisOcjene = broj switch
            {
                1 => "Nedovoljan",
                2 => "Dovoljan",
                3 => "Dobar",
                4 => "Vrlo Dobar",
                5 => "Izvrstan",
                6 or 7 => "Pa i to bi mogle biti ocjene ali nisu",
                _ => "Nije ocjena"
            };

            Console.WriteLine(opisOcjene);

        }
    }
}
