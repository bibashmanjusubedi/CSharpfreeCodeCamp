// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");
// // List T and Collections of Data


// // var name = "Scott";

// List<string> names = ["<name>", "Ana", "Felipe"];
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }


// var names2 = new List<string> {"Scott","Ana","Felipe"};
// names2.Add("David"); // for adding item in a list
// names2.Add("Damian");
// names2.Add("Maria");
// for(int i=0;i<names2.Count;i++)
// {
//     Console.WriteLine($"Hello {names2[i].ToUpper()!}");
// }

// foreach(var name2 in names2)
// {
//     Console.WriteLine($"Hello {name2.ToUpper()!}");
// }

// Console.WriteLine(names2[0]);
// Console.WriteLine(names2[2]);
// Console.WriteLine(names2[1]);
// Console.WriteLine(names2[5]);
// Console.WriteLine(names2[names2.Count-1]);
// Console.WriteLine(names2[^2]);


// foreach(var name2 in names2[2..4])
// {
//     Console.WriteLine($"Hello {name2.ToUpper()!}");
// }


// var naams = new string[] {"Scott", "Ana", "Felipe"};
// naams = [..naams,"Damian"];
// foreach (var naam in naams)
// {
//     Console.WriteLine($"Hello {naam.ToUpper()}");
// }



// var numbers = new List<int> {45,56,99,48,67,78};

// Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");
// numbers.Sort();
// Console.WriteLine($"I found 99 at index {numbers.IndexOf(99)}");


// foreach(var number in numbers)
// {
//     Console.WriteLine($"{number}");
// }


// Specify the data source.
List<int> scores = [97, 92, 81, 60];


// for (int i = 0;i<scores.Count;i++)
// {
//     if(scores[i] > 80)
//     {
//         Console.WriteLine($"Found a score over 80 {scores[i]}");
//     }
// }

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81