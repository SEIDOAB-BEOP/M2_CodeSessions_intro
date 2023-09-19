namespace _19_summera_tal_methods;

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


            tal1 = GetANumber("Ange ett tal");
            tal2 = GetANumber("Ange nästa tal");

            Random rnd = new Random();
            int tal3 = rnd.Next(0, 100);

            Console.WriteLine($"Mitt slumptal är {tal3}");
            int sum = tal1 + tal2 + tal3;

            Console.WriteLine($"Summan ar {sum}");

        } while (!ShouldITerminate("Vill du avsluta (ja/nej)"));

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


    private static bool ShouldITerminate(string question)
    {
        string cont;
        do
        {
            Console.WriteLine(question);
            cont = Console.ReadLine();

        } while (!(cont.Trim().ToLower() == "ja" || cont.Trim().ToLower() == "nej"));

        if (cont.Trim().ToLower() == "ja")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static int GetANumber(string question)
    {
        int nr;
        bool all_ok;

        do
        {
            Console.WriteLine(question);
            string s_nr = Console.ReadLine();

            all_ok = int.TryParse(s_nr, out nr);
            if (!all_ok)
            {
                Console.WriteLine("Not a number");
            }
        } while (!all_ok);
        return nr;
    }
}

