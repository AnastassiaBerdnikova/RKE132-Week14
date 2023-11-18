Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();



Dog myDog = new Dog(myDogName);
//myDog._name = "Good boy";
Dog neighboursDog = new Dog("Bad boy");
//neighboursDog._name = "Bad boy";

Console.WriteLine($"My dog´s name is {myDog.Name}.");
Console.WriteLine($"My neightbours dog´s name is {neighboursDog.Name}.");

myDog.Rename("Pätt");

while (myDog.LevelOfHapiness != 5)

{
    myDog.Bark();
}

myDog.WagTail();

//Console.WriteLine($"Level of happiness {myDog.LevelOfHapiness}");
//myDog.Bark();
//Console.WriteLine($"Level of happiness {myDog.LevelOfHapiness}");

class Dog
{
    private string _name; // field
    private int _levelOfHapiness;

    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to {newName}.");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof!");
        _levelOfHapiness++;
    }

    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle!");
    }
}


