using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    public class Osoba
    {
        //klasa se sastoji od svojstava
        //princip učahurivanja(OOP princip)
        //nazivi svojstava se pišu velikim početnim slovima

        public int Sifra { get; set; }

        public string? Ime { get; set; }
        public string Prezime { get; set; } = "";
        public DateTime? DatumRodjenja { get; set; }

        public Mjesto? Mjesto { get; set; }

        public Mjesto[]? Mjesta { get; set; }





        //klasa se sastoji od metoda
        //ova metoda nije static!

        public void IspisiImeIPrezime()
        {
            Console.WriteLine(this.Ime + " "+ Prezime);
        }


        //statične metode se pozivaju na klasi a ne statične na objektu


        public static void Primjer()
        {
            Console.WriteLine("Primjer statične metode");
        }


    }
}
