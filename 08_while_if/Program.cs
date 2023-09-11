// See https://aka.ms/new-console-template for more information
Console.WriteLine("Alternative 1");
int counter = 0;
while (counter <10)
{
    counter++;
    Console.Write($"{counter}, ");
}

Console.WriteLine();
while (counter < 100)
{
    counter += 10;
    Console.Write($"{counter}, ");
}

Console.WriteLine();
while (counter < 1000)
{
    counter += 100;
    Console.Write($"{counter}, ");
}


Console.WriteLine();
Console.WriteLine("Alternative 2");
counter = 0;
while (counter < 1000)
{
    if (counter < 10)
    {
        counter++;
    }
    else if (counter < 100)
    {
        if (counter == 10)
        {
            Console.WriteLine();
        }

        counter += 10;
    }
    else
    {
        if (counter == 100)
        {
            Console.WriteLine();
        }
        counter += 100;
    }
    Console.Write($"{counter}, ");

}