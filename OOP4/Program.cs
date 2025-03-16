// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// namespace MyNamespace
// {
//     public class MyApp
//     {
//         public static void Main()
//         {
//             Console.WriteLine("hello");
//         }
//     }
// }

Console.WriteLine("hello oop");

// var p1 = new Person(){
//     firstname="Scott",
//     lastname = "Hanselman",
//     birthday = new DateOnly(1970,1,1,)};


// var p2 = new Person(){
//     firstname="David",
//     lastname = "Fowler",
//     birthday = new DateOnly(1970,1,1,)};


var p1 = new Person("Scott","Hanselman",new DateOnly(1970,1,1));
var p2 = new Person("David","Fowler",new DateOnly(1986,1,1));


p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barney"));

p2.Pets.Add(new Cat("Beyonce"));


// var people = new List<Person>

List<Person> people = [p1,p2];

Console.WriteLine(people.Count);


foreach(var person in people) // line 74
{
    Console.WriteLine($"{person}");
    foreach(var pet in person.Pets)
    {
        Console.WriteLine($"   {pet}");
    }
}


// public class Person
// {
//     public Person(string first,string last,DateOnly bd)
//     {
//         firstname = first;
//         lastname = last;
//         birthday = bd;
//     }

//     private string firstname;
//     private string lastname;

//     //public DateTime birthday; Or
//     private DateOnly birthday;
// }


public class Person(string firstname,string lastname,DateOnly birthday)
{
    public string First{ get; } = firstname;
    public string Last { get; } = lastname;

    public DateOnly Birthday { get; } = birthday;

    public List<Pet> Pets { get; } = new();


    public override string ToString()
    {
        return $"Human {First} {Last}";
    }

}





public abstract class Pet(string firstname)
{
    public string First { get; } = firstname;
    public abstract string MakeNoise();//line 91


    public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
    }
}


public class Cat(string firstname): Pet(firstname)
{
    // public string First{ get; } = firstname;

    public override string MakeNoise() => "meow";

}


public class Dog(string firstname): Pet(firstname)
{
    // public string First { get;} = firstname;
    public override string MakeNoise() =>"bark";
}