// int heroTotal = 10;
// int monsterTotal = 10;

// string turn1 = "Hero";
// string turn2 = "Monster";

// string gameturn = turn1;

// Random no = new Random();
 
// do
// {   
//     int attack = no.Next(1,11);
//     if ( (gameturn == turn1))
//     {
//         if (heroTotal > 0)
//         {
//             monsterTotal -= attack;
//             Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterTotal} health.");
//             if (monsterTotal <=0) break;
//             gameturn = turn2;  
//         } 
        
//     }
//     else if ( (gameturn == turn2) )
//     {
//         if (monsterTotal > 0)
//         {
//             heroTotal -= attack;
//             Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroTotal} health.");
//             if (heroTotal <=0) break;
//             gameturn = turn1;
//         } 
    
//     }
// } while ( (heroTotal > 0) || (monsterTotal > 0) );

// if ( (heroTotal > monsterTotal) )
// {
//     Console.WriteLine("Hero Wins!");
// }
// else
// {
//     Console.WriteLine("Monster Wins!");
// }


// Project 1: Using Do-While
// string? value;

// int numericValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");
// do
// {   

//     value = Console.ReadLine();


//     {
//         validNumber = int.TryParse(value,out numericValue);
//         if (!validNumber)
//         { 
//             Console.WriteLine("Please enter a valid number");
//         }
//         else 
//         {
//             if (!((numericValue >= 5) && (numericValue <=10)))
//             {
//                 validNumber = false;
//                 Console.WriteLine("Please Enter an integer value between 5 and 10");
//             }
//             else
//             {
//                 break;
//             }
//         }

//     }
// } while( validNumber == false );

// if ((numericValue >=5) && (numericValue <=10)) Console.WriteLine($"Your input {numericValue} has been accepted");

// Project 2
// Using While
/* Console.WriteLine("Enter one of the Role Names: Administrator,Manager or User");
string? role;
while (true)
{
    role = Console.ReadLine();
    if (!(role.Trim().ToLower().Equals("administrator") || (role.Trim().ToLower().Equals("manager")) || (role.Trim().ToLower().Equals("user"))))
    {
        Console.WriteLine("Please at least enter one role:Administrator, Manager or User");
        continue;
    }
    else
    {
        break;
    }
}

string? roleTrimLower = role.Trim().ToLower(); //line95
if ((roleTrimLower.Equals("administrator")) || (roleTrimLower.Equals("manager")) || (roleTrimLower.Equals("user"))) Console.WriteLine($"The input {roleTrimLower} has been accepted as input"); */


// Code Project 3
// Processing the Content of String Array
string[] myStrings = new string[2]{"I like pizza. I like roast chicken. I like salad","I like all three of the menu choices"};
int periodLocation;
foreach (string myString in myStrings)
{
    string tempString = myString;
    periodLocation = tempString.IndexOf('.');
    // Console.WriteLine(periodLocation);
    string mySentence;

    while (periodLocation !=-1)
    {
        mySentence = tempString.Remove(periodLocation);
        tempString = tempString.Substring(periodLocation + 1);
        tempString = tempString.TrimStart();
        periodLocation = tempString.IndexOf('.');
    }

    mySentence = tempString.Trim();
    Console.WriteLine(mySentence);
}
