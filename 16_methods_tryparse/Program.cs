namespace _16_methods_tryparse;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        string s_nr = Console.ReadLine();

        int nr;
        bool all_ok;

        nr = int.Parse(s_nr);
        all_ok = int.TryParse(s_nr, out nr);

        if (all_ok)
        {
            Console.WriteLine(nr + 10);
        }
        else
        {
            Console.WriteLine("Not a number");
        }
    }
}

