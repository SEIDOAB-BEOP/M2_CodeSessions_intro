namespace _05_enums;

class Program
{
    enum enAnimalKind { Fish, Dog, Cat }
    enum enAnimalMood { Lively, Happy, Sleepy }
    struct Animal
    {
        public enAnimalKind AnimalKind;
        public enAnimalMood AnimalMood;
        public string Name;
        public int Age;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Animals!");

        Animal[] animals = { new Animal(), new Animal(), new Animal() };

        animals[0].AnimalKind = enAnimalKind.Dog;
        animals[0].AnimalMood = enAnimalMood.Lively;
        animals[0].Name = "Wanda";
        animals[0].Age = 3;

        animals[1].AnimalKind = enAnimalKind.Cat;
        animals[1].AnimalMood = enAnimalMood.Sleepy;
        animals[1].Name = "Max";
        animals[1].Age = 2;

        animals[2].AnimalKind = enAnimalKind.Dog;
        animals[1].AnimalMood = enAnimalMood.Happy;
        animals[2].Name = "Snoop";
        animals[2].Age = 2;

        string s = enAnimalMood.Happy.ToString();
        Console.WriteLine(s);

        
        int j = (int) enAnimalMood.Happy;
        Console.WriteLine(j);

        Console.WriteLine();
        int nrDogs = 0;
        for (int i = 0; i < animals.Length; i++)
        {

            Console.WriteLine($"{animals[i].Name} the {animals[i].AnimalMood} {animals[i].AnimalKind}");
            if (animals[i].AnimalKind == enAnimalKind.Dog)
            {
                nrDogs++;
            }
        }

        Console.WriteLine(nrDogs);

    }
}

