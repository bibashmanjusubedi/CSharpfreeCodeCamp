// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// class Car
// {
//     string color = "red";

//     static void Main(string[] args)
//     {
//         Car myObj  = new Car();
//         Car myObj1  = new Car();
//         Car myObj2 = new Car();
//         Console.WriteLine(myObj.color);
//         Console.WriteLine(myObj1.color);
//         Console.WriteLine(myObj2.color);
//     }
// }

using System;

namespace MyApplication
{
  class Car
  {
    string color = "red";

    static void Main(string[] args)
    {
      Car myObj1 = new Car();
      Car myObj2 = new Car();
      Console.WriteLine(myObj1.color);
      Console.WriteLine(myObj2.color);
    }
  }
}