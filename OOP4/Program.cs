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

// var people = new List<Person>

List<Person> people = [p1,p2];

Console.WriteLine(people.Count);

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

}