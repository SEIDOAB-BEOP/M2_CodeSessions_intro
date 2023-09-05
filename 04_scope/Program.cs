namespace _04_scope;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scope!");

        //Red scope - red plates in the pile
        int i = 3;
        string s = "Red scope";

        {
            //Blue scope - blue plates in the pile
            int j = 12;
            decimal d = 3.5M;
            string t = "Blue scope";

            {
                //Yellow scope - yellow plates in the pile
                int k = 12;
                float f = 2.85F;
                string u = "Yellow scope";

                //I can access all plates in the pile
                Console.WriteLine(k);
                Console.WriteLine(f);
                Console.WriteLine(u);

                Console.WriteLine(t);
                Console.WriteLine(d);
                Console.WriteLine(j);

                Console.WriteLine(s);
                Console.WriteLine(i);
            }

            //Yellow plates gone
            //Console.WriteLine(k);
            //Console.WriteLine(f);
            //Console.WriteLine(u);

            Console.WriteLine(t);
            Console.WriteLine(d);
            Console.WriteLine(j);

            Console.WriteLine(s);
            Console.WriteLine(i);
        }

        //Yellow plates gone
        //Console.WriteLine(k);
        //Console.WriteLine(f);
        //Console.WriteLine(u);

        //Blue plates gone
        //Console.WriteLine(t);
        //Console.WriteLine(d);
        //Console.WriteLine(j);

        Console.WriteLine(s);
        Console.WriteLine(i);
    }
}

