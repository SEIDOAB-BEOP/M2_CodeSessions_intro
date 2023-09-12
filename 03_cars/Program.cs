namespace _03_cars;

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
        Console.WriteLine("Cars!");

        Car[] cars = { new Car(), new Car(), new Car(), new Car(), new Car() };
        cars[0].Make = "Volvo";
        cars[0].Model = "V70";
        cars[0].Year = 2020;
        cars[0].RegNr = "ABC 123";

        //Extra
        cars[0].Owner = new Person();
        cars[0].Owner.Name = "Severus Snape";

        cars[1].Make = "BMW";
        cars[1].Model = "S300";
        cars[1].Year = 2018;
        cars[1].RegNr = "JTH 113";
        cars[1].Owner = new Person();
        cars[1].Owner.Name = "Albus Dumbledorn";

        cars[2].Make = "Volkswagen";
        cars[2].Model = "Polo";
        cars[2].Year = 2022;
        cars[2].RegNr = "KPQ 628";
        cars[2].Owner = new Person();
        cars[2].Owner.Name = "Harry Potter";

        cars[3].Make = "Toyota";
        cars[3].Model = "Camery";
        cars[3].Year = 2015;
        cars[3].RegNr = "JTV 223";
        cars[3].Owner = new Person();
        cars[3].Owner.Name = "Tom Ridle";

        cars[4].Make = "Volvo";
        cars[4].Model = "V40";
        cars[4].Year = 2019;
        cars[4].RegNr = "KPQ 999";
        cars[4].Owner = new Person();
        cars[4].Owner.Name = "Tim Bagger";

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"A {cars[i].Make} {cars[i].Model} with registration {cars[i].RegNr} is owned by {cars[i].Owner.Name}");
        }
    }


}

//Övning:
//1. Ändra Make och Model till enum typer.
//2. Skriv ut alla bilar av märket Volvo
//3. Skriv ut alla bilar som inte är av märket Volvo
//4. Räkna antalet bilar av model Polo och skriv ut
//5. Räkna antalet bilar som ägs av Tim Bagger

//6. Rita minnesdiagram med stack och heap
//7. Ändra struct till class och rita minnesdiagram med stack och heap

//Extra
//8. Skriv ut all bilar med ett registreringsnummer som börjar på KPQ