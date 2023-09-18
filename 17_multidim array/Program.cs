namespace _17_multidim_array;

class Program
{
    static void Main(string[] args)
    {
        //three dimesions, a rubriks cube
                           //front layer of rubriks cube
        int[,,] matrix2 =  {{{0,23,-35},         
                           {3,45,52},
                           {6,71,84}},

                           //middle layer of rubriks cube
                           {{10,3,-35},         
                           {3,45,7},
                           {6,-1000,84}},

                           //back layer of rubriks cube
                           {{10,3,-35},
                           {3,45,7},
                           {6,1000,84}}};


        int maxVal = int.MinValue;
        int minVal = int.MaxValue;
        for (int row = 0; row < matrix2.GetLength(0); row++)
        {
            for (int column = 0; column < matrix2.GetLength(1); column++)
            {
                for (int depth = 0; depth < matrix2.GetLength(2); depth++)
                {

                    if (matrix2[row, column, depth] > maxVal)
                    {
                        maxVal = matrix2[row, column, depth];
                    }
                    if (matrix2[row, column, depth] < minVal)
                    {
                        minVal = matrix2[row, column, depth];
                    }
                }
            }
        }

        Console.WriteLine($"Max: {maxVal}");
        Console.WriteLine($"Min: {minVal}");
    }
}

//Exercise:
//Write code that finds the largest and smallest number in the two dimesional array
//Add a third dimension and find the largest and smallest number in the three dimesional array

