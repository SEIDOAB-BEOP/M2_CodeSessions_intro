namespace _10_break_continue;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("break, continue in for - loop");

        for (int i = 0; i < 10; i++)
        {
            if (i == 1)
            {
                continue;
            }

            Console.WriteLine(i);
            
            if (i == 5)
            {
                break;
            }
        }

        Console.WriteLine("Done");

        Console.WriteLine("break, continue in while - loop");
        int c = 0;
        while (true)
        {
            c++;

            if (c == 3)
                continue;

            Console.WriteLine(c);

            if (c == 10)
                break;
        }
        Console.WriteLine("Done");
    }
}

