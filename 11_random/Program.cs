namespace _11_random;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            //Parameterless methods
            //var name = GetName();
            string license = GetRegNr();
            //string make = GetMake();
            //string model = GetModel();

            //Parameter Methods
            string fName = GetElementFromString("Joakim, Josef, Emilja, Nicole, Samir, Amin, Bashir");
            string lName = GetElementFromString("Emil, Eddie, Martin, Andre, Robin, Christos");
            var name = $"{fName} {lName}";

            string make = GetElementFromString("Volvo, BMW, Opel, Mini, VW, KIA, Toyota");
            string model = GetElementFromString("Corolla, Golf, Rio, V70");

            Console.WriteLine($"{name}, has a {make} {model} with license number {license} ");
         }

        Console.ReadKey();
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

    static string GetElementFromString(string str)
    {
        string[] s = str.Split(", ");

        Random rnd = new Random();
        int i = rnd.Next(0, s.Length);
        string item = s[i];
        return item;
    }
}

