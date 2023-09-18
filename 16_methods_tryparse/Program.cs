namespace _16_methods_tryparse;

class Program
{
    static void Main(string[] args)
    {
        int nr;
        do
        {
            nr = GetANumber();
            Console.WriteLine($"Number is {nr}");

        } while (nr < 50);
    }

    private static int GetANumber()
    {
        int nr;
        bool all_ok;

        do
        {
            Console.WriteLine("Enter a number");
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

