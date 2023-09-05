namespace _06_if;

class Program
{
    enum enMonths { January, February, March}
    static void Main(string[] args)
    {
        Console.WriteLine("if!");

        /*
        for (int i = 0; i < 20; i++)
        {
            //check if i is exactly 10
            if (i <= 10)
            {
                //yes, i is exactly 10
                Console.WriteLine(i);
            }
        }
        */
        /*
        for (enMonths m = enMonths.January; m <= enMonths.March; m++)
        {
            if (m == enMonths.March)
            {
                Console.WriteLine(m);
            }
        }
        */

        string s = "Alina";
        if (s == "Stefan" || s == "Bino")
        {
            Console.WriteLine($"Hello {s}!");
        }
        else
        {
            Console.WriteLine($"Bye {s}"); }
    }
}

