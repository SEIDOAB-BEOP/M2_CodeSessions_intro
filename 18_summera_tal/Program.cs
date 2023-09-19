namespace _18_summera_tal;

class Program
{
    static void Main(string[] args)
    {
        string cont;
        do
        {
            bool all_ok;
            int tal1;
            int tal2;
            string s;
            do {
                Console.WriteLine("Ange ett tal");

                s = Console.ReadLine();
                all_ok = int.TryParse(s, out tal1);
            } while (!all_ok);


            do {
                Console.WriteLine("Ange nästa tal");

                s = Console.ReadLine();
                all_ok = int.TryParse(s, out tal2);
            } while (!all_ok);


            Random rnd = new Random();
            int tal3 = rnd.Next(0, 100);

            Console.WriteLine($"Mitt slumptal är {tal3}");
            int sum = tal1 + tal2 + tal3;

            Console.WriteLine($"Summan ar {sum}");

            do
            {
                Console.WriteLine("Vill du avsluta (ja/nej)");
                cont = Console.ReadLine();

            } while (!(cont.Trim().ToLower() == "ja" || cont.Trim().ToLower() == "nej"));

         

        } while (cont.Trim().ToLower() != "ja");

        /*
        börja do
            mata in ett tal från konsolen
            spara talet i en variable tal1

            mata in nästa tal från konsolen
            spara talet i en variable tal2

            ta fram ett slumtal mellan 0 och 100
            spara talet i en variable tal3

            skriv ut slumptalet till konsolen

            räkna ut summan av alla 3 tal
            skriv ut summan till konsolen

            fråga användaren om hen vill avsluta
            läs in svar från konsolen
        så länge svaret inte är nej

        */
    }
}

