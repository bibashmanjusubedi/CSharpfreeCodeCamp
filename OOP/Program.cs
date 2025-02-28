// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

var bibash = new Person(26, "Bibash Acharya", "1999 Feb 7");
Console.WriteLine(bibash.name); // Output: Bibash Acharya
Console.WriteLine("Square of age: " + bibash.SquareOfAge()); // Output: Square of age: 676

class Person
{
    public int age;
    public string name;
    public string birthday;

    public Person(int umer, string naam, string janmadin)
    {
        age = umer;
        name = naam;
        birthday = janmadin;
    }

    // Method to calculate the square of age
    public int SquareOfAge()
    {
        return age * age;
    }
}