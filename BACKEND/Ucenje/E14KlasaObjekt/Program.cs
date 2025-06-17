using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    internal class Program
    {
        //5.vrsta metode je konstruktor
        //naziv mora biti jednak nazivu klase

        public Program()
        {
            Console.WriteLine("Klasa/objekt");

            //objekt je pojavnost (instanca) klase-> naučiti napamet
            //Osoba(primjetiti veliko slovo O) je klasa
            //osoba(primjetiti malo slovo o) je objekt(instanca, varijabla)
            Osoba osoba = new Osoba();//pozvali smo konstruktor od klase Osoba(new)

            //postavljanje vrijednosti za svojstva objekta
            osoba.Sifra = 1;//pozvao si setter(učahurivanje)
            //osoba.Ime="Pero"; namjerno ime ostavljeno null jer ono može biti null(? smo stavili)
            osoba.Prezime = "Perić";
            osoba.DatumRodjenja = new DateTime(1980, 12, 7);

            osoba.Sifra = Pomocno.UcitajCijeliBroj("Unesi šifru osobe");//usporediti s linijom 20
            osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            osoba.DatumRodjenja = new DateTime(
                Pomocno.UcitajCijeliBroj("Unesi godinu rođenja"),
                Pomocno.UcitajCijeliBroj("Unesi mjesec rođenja"),
                Pomocno.UcitajCijeliBroj("Unesi dan rođenja"));

            //korištenje vrijednosti sredstava
            Console.WriteLine(osoba.Prezime);//pozvao si getter(učahurivanje)

            Console.WriteLine(osoba.Ime ?? "nije postavljeno");//ime može biti null

            osoba.IspisiImeIPrezime();

            //osoba.Primjer(); ne možeš pozvati statičnu metodu s objekta

            Osoba.Primjer();//statičnu metodu pozivamo s klase

            //Osoba.IspisiImeIPrezime();//na klasi se ne može pozvati ne statična metoda


            Osoba[] osobe = new Osoba[3];

            //skraćeni oblik postavljanja vrijednosti svojstava
            osobe[0] = new Osoba()
            {
                Ime = "Maria",
                Prezime = "Vrbešić",
                Sifra = 2,
                DatumRodjenja = new DateTime(2000, 17, 9)
            };

            osobe[1] = new() { Ime = "Paula" };

            osobe[2] = osoba;

            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Ime);
            }

            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            osoba.Mjesto = new()
            {
                Naziv = "Valpovo",
                Zupanija = new Zupanija
                {
                    Naziv = "OBŽ",
                    Zupan = new()
                    {
                        Ime = "Paula"
                    }
                }
            };

            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije spotavljeno");


            osoba.Ime = "Maria";

            //osoba.Mjesto.Zupanija = new Zupanija() { Naziv = "OBŽ", Zupan = new() { Ime = "Paula" } };

            //Koji je smisao OOP-a
            Console.WriteLine(osoba.Mjesto?.Zupanija.Zupan.Ime);

            Console.WriteLine(osoba.Ime);

            Console.WriteLine(osoba.Mjesto?.Zupanija.Naziv);

            Console.WriteLine(osoba.Mjesto?.Naziv);

        }

            public static void AutomobilZadatak()
        {
            Automobil automobil= new Automobil();
            automobil.Sifra = 1;
            automobil.Marka = "Ford";
            automobil.Automatik = false;
            automobil.DatumProizvodnje = new DateTime(2006, 5, 20);
            automobil.Cijena=14525.20M;

            Console.WriteLine(automobil.DatumProizvodnje);
            
        }


        }
    

    }

