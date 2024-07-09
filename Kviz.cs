namespace Kviz
{
    internal class Kviz
    {
        private List<Pitanje> pitanja;
        private int brTacnihOdg;

        public Kviz()
        {
            pitanja = new List<Pitanje>();
            brTacnihOdg = 0;
        }

        public void DodajPitanje(Pitanje pitanje)
        {
            pitanja.Add(pitanje);
        }

        public void WriteSlow(string tekst, int brzina)
        {
        
        }


        public void PokreniKviz()
        {
           
                brTacnihOdg = 0;
                Console.WriteLine("Dobrodosli u kviz znanja!");
                Console.WriteLine(new string('-', 50));

                for (int i = 0; i < pitanja.Count; i++)
                {

                    Console.WriteLine($"Pitanje {i + 1} : {pitanja[i].Tekst}");

                    for (int j = 0; j < pitanja[i].Odgovori.Count; j++)
                    {
                        Console.WriteLine($"{j + 1} : {pitanja[i].Odgovori[j]}");
                    }
                    Console.WriteLine("Unesite broj odgovora: ");
                    int odgIndex = int.Parse(Console.ReadLine()) - 1;

                    if (odgIndex == pitanja[i].TacanOdgIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tacan odgovor.");
                        Console.ResetColor();
                        brTacnihOdg++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Netacan odgovor.");
                        Console.ResetColor();

                    }

                    Console.WriteLine();
                }
                if (brTacnihOdg == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cestitamo. Pobedili ste u kvizu!");
                    Console.ResetColor();
                }
                else
                {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niste pobedili u kvizu. Pokusajte ponovo!");
                Console.ResetColor();

                }
                Console.WriteLine($"Ukupno tacnih odgovora : {brTacnihOdg}");
            
        }
    }
}
