

using System;

namespace Ucenje
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {
            Console.WriteLine("Ciklična tablica");

           
            while (true)
            {
                int br, bk;

               
                while (true)
                {
                    Console.WriteLine("Unesi broj redova: ");
                    string inputRedovi = Console.ReadLine();
                    if (int.TryParse(inputRedovi, out br) && br > 0)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Niste unijeli točan broj redova! Mora biti pozitivan cijeli broj (npr. 5).");
                    }
                }

                
                while (true)
                {
                    Console.WriteLine("Unesi broj kolona: ");
                    string inputKolone = Console.ReadLine();
                    if (int.TryParse(inputKolone, out bk) && bk > 0)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Niste unijeli točan broj kolona! Mora biti pozitivan cijeli broj (npr. 5).");
                    }
                }
                

                int[,] tablica = new int[br, bk];

                int gornjiRed = 0;
                int donjiRed = br - 1;
                int lijevaKolona = 0;
                int desnaKolona = bk - 1;

             
                int trenutniBroj = 1;
            

                while (gornjiRed <= donjiRed && lijevaKolona <= desnaKolona)
                {
                    
                    for (int kol = desnaKolona; kol >= lijevaKolona; kol--)
                    {
                        tablica[donjiRed, kol] = trenutniBroj++; 
                    }
                    donjiRed--; 

                    if (gornjiRed > donjiRed) break;

                    
                    for (int red = donjiRed; red >= gornjiRed; red--)
                    {
                        tablica[red, lijevaKolona] = trenutniBroj++; 
                    }
                    lijevaKolona++; 

                    if (lijevaKolona > desnaKolona) break;

                    
                    for (int kol = lijevaKolona; kol <= desnaKolona; kol++)
                    {
                        tablica[gornjiRed, kol] = trenutniBroj++; 
                    }
                    gornjiRed++; 

                    if (gornjiRed > donjiRed) break;

                   
                    for (int red = gornjiRed; red <= donjiRed; red++)
                    {
                        tablica[red, desnaKolona] = trenutniBroj++; 
                    }
                    desnaKolona--; 

                    if (lijevaKolona > desnaKolona) break;
                }

                
               
                for (int i = 0; i < br; i++)
                {
                    for (int j = 0; j < bk; j++)
                    {
                        Console.Write($"{tablica[i, j],4}"); 
                    }
                    Console.WriteLine();
                }

               
                int userInput;
                while (true)
                {
                    Console.WriteLine("Želite li novu tablicu (1=Da, 0=Ne)?");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out userInput))
                    {
                        if (userInput == 1 || userInput == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Neispravan broj. Molimo unesite 1 za 'Da' ili 0 za 'Ne'.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Neispravan unos. Molimo unesite broj.");
                    }
                }

                if (userInput == 1)
                {
                    Console.WriteLine("Nova tablica");
                }
                else
                {
                    Console.WriteLine("Završeno.");
                    break;
                }
            }
        }
    }
}