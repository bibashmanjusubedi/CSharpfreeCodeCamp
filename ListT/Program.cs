// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// List T and Collections of Data


// var name = "Scott";

List<string> names = ["<name>", "Ana", "Felipe"];
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}


var names2 = new List<string> {"Scott","Ana","Felipe"};
names2.Add("Charles");
names2.Add("Darwin");
for(int i=0;i<names2.Count;i++)
{
    Console.WriteLine($"Hello {names2[i].ToUpper()!}");
}

foreach(var name2 in names2)
{
    Console.WriteLine($"Hello {name2.ToUpper()!}");
}