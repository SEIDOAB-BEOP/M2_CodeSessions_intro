namespace _15_methods;

class Program
{
    static void Main(string[] args)
    {
        SayHello("Alina");
        SayHello("Samir");

        int res = AddNumbers(8, 10, 10, "123");
        Console.WriteLine(res);

        int a = 3, b = 4, c = 10;
        int o;
        int res1 = AddNumbers(a, b, out c, out o);

        Console.WriteLine(res1);

        Console.WriteLine(c);
        Console.WriteLine(o);
        
    }

    static void SayHello(string greeting)
    {
        greeting += " and Martin";
        Console.WriteLine($"Hello {greeting}");
    }

    static int AddNumbers(int n1, int n2, int n3, string s)
    {
        return n1 + n2 + n3 + int.Parse(s);
    }
    static int AddNumbers(int n1, int n2, out int c, out int o)
    {
        c = 100;
        o = 200;
        return n1 + n2 + c;
    }
}

