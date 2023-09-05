namespace _00_variables;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /*
        string[] my_strings = { "Goodbye friends", "Bashir", "Amin" };

        string my_string1 = "Goodbye friends";
        string my_string2 = "Bashir";
        string my_string3 = "Amin";

        int my_int1 = 10;
        int my_int2 = 7;

        Console.WriteLine($"{my_strings[0]} {my_strings[1]} {my_int1} {my_strings[2]} {my_int2}");

        my_strings[0] = "Hello friends";

        Console.WriteLine($"{my_strings[0]} {my_strings[1]} {my_strings[2]}");

        my_strings[0] = "Stoppa";

        Console.WriteLine($"{my_strings[0]} {my_strings[1]} {my_strings[2]}");
        */
      
        string[] countries = { "Sweden", "Norway", "Denmark", "Finland", "Tyskland", "Holland" };
        for (int i = 0; i < countries.Length; i++)
        {
            Console.WriteLine(countries[i]);
            if(countries[i] == "Denmark")
            {
                Console.WriteLine("hello");
            }
        }

        //macOs
        Console.ReadKey();
    }
}

