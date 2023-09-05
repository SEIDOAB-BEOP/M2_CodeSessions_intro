namespace array;

class Program
{



    static void Main(string[] args)
    {
        Console.WriteLine("Arrays!");

        //discrete
        int i0 = 1;
        int i1 = 2;
        int i2 = 3;
        int i3 = 4;

        Console.WriteLine(i0);
        Console.WriteLine(i1);
        Console.WriteLine(i2);
        Console.WriteLine(i3);

        //array
        int[] i_array = { 1, 2, 3, 4 };
        Console.WriteLine(i_array[0]);
        Console.WriteLine(i_array[1]);
        Console.WriteLine(i_array[2]);
        Console.WriteLine(i_array[3]);


        int k = 3;
        Console.WriteLine(i_array[k]);

        for (int i = 0; i < i_array.Length; i++)
        {
            Console.WriteLine(i_array[i]);
        }
        Console.ReadKey();

    }
}

