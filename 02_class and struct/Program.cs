// See https://aka.ms/new-console-template for more information
Console.WriteLine("class and struct");

string fruit_name1 = "Banana";
double fruit_weigth1 = 1.5;
decimal fruit_price1 = 23.95M;

string fruit_name2 = "Apelsin";
double fruit_weigth2 = 2.5;
decimal fruit_price2 = 15.80M;

Console.WriteLine($"Total price for {fruit_weigth1}kg {fruit_name1} is {(decimal)fruit_weigth1 * fruit_price1}");
Console.WriteLine($"Total price for {fruit_weigth2}kg {fruit_name2} is {(decimal)fruit_weigth2 * fruit_price2}");

Console.WriteLine("\n\nFruit struct");
Fruit fruit1 = new Fruit();
fruit1.Name = "Grapes";
fruit1.Weigth = 0.4;
fruit1.Price = 12.30M;

Fruit fruit2 = new Fruit();
fruit2.Name = "Grapes";
fruit2.Weigth = 0.4;
fruit2.Price = 12.30M;

Fruit fruit3 = fruit1;
fruit1.Name = "Olives";

Console.WriteLine($"Total price for {fruit1.Weigth}kg {fruit1.Name} is {(decimal)fruit1.Weigth * fruit1.Price}");
Console.WriteLine($"Total price for {fruit2.Weigth}kg {fruit2.Name} is {(decimal)fruit2.Weigth * fruit2.Price}");
Console.WriteLine($"Total price for {fruit3.Weigth}kg {fruit3.Name} is {(decimal)fruit3.Weigth * fruit3.Price}");



Fruit[] fruits = {new Fruit(), new Fruit(), new Fruit()};
fruits[0].Name = "Grapes";
fruits[0].Weigth = 0.4;
fruits[0].Price = 12.30M;

fruits[1].Name = "Grapes";
fruits[1].Weigth = 0.4;
fruits[1].Price = 12.30M;

fruits[2] = fruits[0];
fruits[0].Name = "Olives";

for (int i = 0; i < fruits.Length; i++)
{
    Console.WriteLine($"Total price for {fruits[i].Weigth}kg {fruits[i].Name} is {(decimal)fruits[i].Weigth * fruits[i].Price}");
}

Console.ReadKey();


struct Fruit
{
    public string Name;
    public double Weigth;
    public decimal Price;
}