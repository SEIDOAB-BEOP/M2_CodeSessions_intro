namespace _12_cars_revisited;

class Program
{
    struct Car
    {
        public string Make;
        public string Model;
        public int Year;
        public string RegNr;

        //Extra
        public Person Owner;
    }
    //Extra
    struct Person
    {
        public string Name;
    }


    static void Main(string[] args)
    {
        //Create 1000 cars with random data
        Car[] cars = new Car[100_000];

        for (int i = 0; i < 100_000; i++)
        {
            cars[i] = new Car();
            cars[i].Make = GetMake();
            cars[i].Model = GetModel();
            cars[i].RegNr = GetRegNr();
            cars[i].Year = GetYear();
            cars[i].Owner = new Person();
            cars[i].Owner.Name = GetName();
        }

        Console.WriteLine(cars.Length);
        Console.WriteLine($"{cars[0].Make} {cars[0].Model} with registration {cars[0].RegNr} is owned by {cars[0].Owner.Name}");

        int lastIdx = cars.Length - 1;
        Console.WriteLine($"{cars[lastIdx].Make} {cars[lastIdx].Model} with registration {cars[lastIdx].RegNr} is owned by {cars[lastIdx].Owner.Name}");

        int cntr = CountVolvo(cars);
        Console.WriteLine(cntr);
    }

    private static int CountVolvo(Car[] cars)
    {
        int cntr = 0;
        foreach (var car in cars)
        {
            if (car.Make == "Volvo")
            {
                cntr++;
            }
        }

        return cntr;
    }

    static string GetName()
    {
        string[] s = "Joakim, Josef, Emilja, Nicole, Samir, Amin, Bashir".Split(", ");
        string[] s1 = "Emil, Eddie, Martin, Andre, Robin, Christos".Split(", ");

        Random rnd = new Random();
        int nr = rnd.Next(0, s.Length);
        int nr1 = rnd.Next(0, s1.Length);

        string name = $"{s[nr]} {s1[nr1]}";
        return name;
    }

    static string GetRegNr()
    {
        var rnd = new Random();

        char lc1 = (char)rnd.Next(65, 91);
        char lc2 = (char)rnd.Next(65, 91);
        char lc3 = (char)rnd.Next(65, 91);

        int i1 = rnd.Next(0, 10);
        int i2 = rnd.Next(0, 10);
        int i3 = rnd.Next(0, 10);

        string license = $"{lc1}{lc2}{lc3} {i1}{i2}{i3}";
        return license;
    }

    static string GetMake()
    {
        string[] s = "Volvo, BMW, Opel, Mini, VW, KIA, Toyota".Split(", ");

        Random rnd = new Random();
        int i = rnd.Next(0, s.Length);
        string make = s[i];
        return make;
    }

    static string GetModel()
    {
        string[] s = "Corolla, Golf, Rio, V70".Split(", ");

        Random rnd = new Random();
        int i = rnd.Next(0, s.Length);
        string make = s[i];
        return make;
    }

    static int GetYear()
    {
        Random rnd = new Random();
        int year = rnd.Next(1970, 2023);
      
        return year;
    }


    static string GetElementFromString(string str)
    {
        string[] s = str.Split(", ");

        Random rnd = new Random();
        int i = rnd.Next(0, s.Length);
        string item = s[i];
        return item;
    }
}

