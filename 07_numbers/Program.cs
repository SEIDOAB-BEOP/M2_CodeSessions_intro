// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter numbers separated by ; (1; 2; 4; )");

string strInput = Console.ReadLine();
string[] arrInput = strInput.Split(";");

int sum = 0;
for (int i = 0; i < arrInput.Length-1; i++)
{
    int intVal = int.Parse(arrInput[i]);
    sum = sum + intVal;
}

Console.WriteLine($"The sum is {sum}");
