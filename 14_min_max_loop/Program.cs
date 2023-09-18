namespace _14_min_max_loop;

class Program
{
    static void Main(string[] args)
    {
        int[] my_ints = { 7, 8, 55, -1, 0, 9, 7 };

        SayHello("Josef");

        Console.WriteLine("for - finding max val");
        int _maxVal = int.MinValue;
        for (int i = 0; i < my_ints.Length; i++)
        {
            Console.Write($"{my_ints[i]} ");
            SayHello("Alina");

            if (my_ints[i] > _maxVal)
            {
                _maxVal = my_ints[i];
            }

        }
        Console.WriteLine($"\nMax value in array: {_maxVal}");
        SayHello("Stefan");



        Console.WriteLine("\n\nMethod finding Max value");
        int myMax = MaxValue(my_ints);
        Console.WriteLine($"Max value in array: {myMax}");

        int[] my_ints2 = { 23, 7, 9, 123, 0, 65, 32 };
        myMax = MaxValue(my_ints2);
        Console.WriteLine($"Max value in array: {myMax}");

        myMax = MaxValue(new int[] {23,9,0,0,-23,-78, -100, 345});
        Console.WriteLine($"Max value in array: {myMax}");
    }





    static void SayHello(string greeting)
    {
        greeting += " and Martin";
        Console.WriteLine($"Hello {greeting}");
    }

    static int MaxValue(int[] my_array)
    {
        int _maxVal = int.MinValue;
        for (int i = 0; i < my_array.Length; i++)
        {
            if (my_array[i] > _maxVal)
            {
                _maxVal = my_array[i];
            }
        }
        return _maxVal;
    }
}

