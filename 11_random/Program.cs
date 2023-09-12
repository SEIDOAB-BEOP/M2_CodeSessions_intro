namespace _11_random;

class Program
{
    static void Main(string[] args)
    {

        for (int i = 0; i < 1; i++)
        {
            var name = GetName();

            Console.Write($"{name,20}, ");
            if ((i % 5) == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine("\nCharacters");
        char ch1 = (char) 65;
        Console.WriteLine(ch1);

        char ch2 = (char) 90;
        Console.WriteLine(ch2);

        var rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            char lc1 = (char)rnd.Next(65, 91);
            char lc2 = (char)rnd.Next(65, 91);
            char lc3 = (char)rnd.Next(65, 91);

            string license = $"{lc1}{lc2}{lc3} 123";
            Console.WriteLine(license);
        }

        Console.ReadKey();
    }

    static string GetName()
    {
        var s = "Joakim, Josef, Emilja, Nicole, Samir, Amin, Bashir".Split(", ");
        var s1 = "Emil, Eddie, Martin, Andre, Robin, Christos".Split(", ");

        var rnd = new Random();
        var nr = rnd.Next(0, s.Length);
        var nr1 = rnd.Next(0, s1.Length);

        var name = $"{s[nr]} {s1[nr1]}";
        return name;
    }

}

