namespace Kviz
{
    internal class Program
    {
                

        static void Main(string[] args)
        {

           Kviz kviz = new Kviz();
          

           Pitanje p1 = new Pitanje("Koje godine se odigrao boj na Kosovu?", new List<string> { "1603.", "1905", "1389." }, 2);  
           Pitanje p2 = new Pitanje("Koji je glavni grad Italije?", new List<string> { "Rim", "Pariz", "Sicilija" }, 0);
           Pitanje p3 = new Pitanje("Koja je najvaznija komponenta racunara?", new List<string> { "Mis", "Procesor", "RAM" }, 1);
           Pitanje p4 = new Pitanje("Koliko je 1 GB u MB? ", new List<string> { "1000", "1200", "1024" }, 2);
           Pitanje p5 = new Pitanje("Koliko postoji planeta na svetu?", new List<string> { "1","20","8"}, 2);


            kviz.DodajPitanje(p1);
            kviz.DodajPitanje(p2);
            kviz.DodajPitanje(p3);
            kviz.DodajPitanje(p4);
            kviz.DodajPitanje(p5);

            kviz.PokreniKviz();

        }
    }
}
