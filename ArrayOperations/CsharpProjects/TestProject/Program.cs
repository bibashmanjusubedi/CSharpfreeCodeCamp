// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// string[] pallets = [ "B14", "A11", "B12", "A13" ];
// Console.WriteLine("Unsorted");
// foreach(var i in pallets)
// {
//     Console.WriteLine($"{i}");
// }
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }


// Console.WriteLine("");
// Console.WriteLine("Reversed");
// Array.Reversed(pallets);
// for each(var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

 
// string[] pallets = ["B14","A11","B12","A13"];
// Console.WriteLine("");

// // Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets,0,2);
// // if (pallets[0] !=null)
// //     Console.WriteLine($"After : {pallets[0].ToLower()}");
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach( var pallet in pallets)
// {
//     Console.WriteLine($" -- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets,6);
// Console.WriteLine($"Resizing 6 ... count :{pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets,3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach(var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string pangram = "The quick brown fox jumps over the lazy dog";
// Console.WriteLine(pangram);
// // int length=pangram.Length;
// // string[] reversedPangramArr = new string[length];
// // char[] valueArray = pangram.ToCharArray();
// // Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string[] result = pangram.Split(" ");
// int length = result.Length;
// string[] revResult = new string[length];
// // string[] pamgramWordsArray = new string(result.Length);
// // Console.WriteLine($"hello :{length}");
// foreach (string s in result)
// {
//     char[] valueArray = s.ToCharArray();
//     Array.Reverse(valueArray);
//     string temp = new string(valueArray);
//     // Console.WriteLine(temp);
//     // for (int i=0;i<length;i++)
//     // {
//     //     revResult[i] = temp;
//     //     // Console.WriteLine(revResult[i]);
//     // }
//     revResult[Array.IndexOf(result, s)] = temp;

//     // Console.WriteLine(temp);
//     // Console.WriteLine(s)
// }
// // Console.WriteLine(result);
// // string final = String.Join(" ");
// // Console.WriteLine(revResult);

// // char[] revResultArray = revResult.ToArray();
// string reversed = string.Join(" ", revResult);
// Console.WriteLine(reversed);

// String of orders

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] result = orderStream.Split(",");

int length = result.Length;

Array.Sort(result);

string error = "";

foreach (string i in result)
{
    if (i.Length !=4)
    {
        error = "- Error";
    }
    else
    {
        error = "";
    }
    Console.WriteLine($"{i}\t{error}");
}