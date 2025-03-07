// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int[] schedule = {800,1200,1600,2000};

// void DisplayAdjustedTimes(int[] times,int currentGMT,int newGMT)
// {
//     int diff = 0;
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }

//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >=0 && currentGMT >= 0)
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     }
//     else
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }


//     for (int i = 0; i < times.Length; i++) 
//     {
//         int newTime = ((times[i] + diff)) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
// }

// DisplayAdjustedTimes(schedule,6,-6);

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};
// DisplayStudents(students);
// DisplayStudents(new string[]{"Robert","Vanya"});

// void DisplayStudents(string[] students)
// {
//     foreach (string student in students)
//     {
//         Console.Write($"{student},");
//     }

//     Console.WriteLine();
// }


// PrintCircleArea(12);
// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);


// void PrintCircleArea(int radius)
// {

//     double area = pi * (radius * radius);
//     // double circumference = 2 * pi * radius;
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumferance(int radius)
// {
//     double circumference = 2 * pi* radius;
//     Console.WriteLine($"Circumference = {circumference}");
// }

// void PrintCircleInfo(int radius)
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumferance(radius);
// }

// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }


// int[] array = {1,2,3,4,5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array)
// {
//     foreach(int a in array)
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }


// void Clear(int[] array)
// {
//     for(int i=0;i<array.Length;i++)
//     {
//         array[i]=0;
//     }
// }


// string status = "Healthy";
// Console.WriteLine($"Start: {status}");
// SetHealth(status,false);
// Console.WriteLine($"End: {status}");

// void SetHealth(string status,bool isHealthy)
// {
//     status = (isHealthy ? "Healthy": "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// string[] guestList = {"Rebecca","Nadia","Noor","Jonte"};
// string[] rsvps = new string[10];
// int count = 0;


// // RSVP("Rebecca",1,"none",true);
// RSVP("Rebecca");
// // RSVP("Nadia",2,"Nuts",true);
// RSVP("Nadia",2,"Nuts");
// // RSVP("Linh",2,"none",false);
// // RSVP(name:"Linh",partySize:2,allergies:"none",inviteOnly:false);
// RSVP(name:"Linh",partySize:2,inviteOnly:false);
// // RSVP("Tony",1,"Jackfruit",true);
// // RSVP("Tony",inviteOnly:true,allergies:"Jackfruit",partySize:1);
// RSVP("Tony",allergies:"Jackfruit",inviteOnly:true);
// // RSVP("Noor",4,"none",false);
// RSVP("Noor",4,inviteOnly:false);
// RSVP("Jonte",2,"Stone fruit",false);
// ShowRSVPs();


// void RSVP(string name,int partySize=1, string allergies= "none",bool inviteOnly=true)
// {
//     if(inviteOnly)
//     {
//         // search guestList before adding rsvp
//         bool found = false;
//         foreach(string guest in guestList)
//         {
//             if (guest.Equals(name)){
//                 found  = true;
//                 break;
//             }
//         }

//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }

//     rsvps[count] = $"Name: {name},\t Party Size:{partySize},\t{allergies}";
//     count++;

// }

// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVps:");
//     for(int i=0;i<count;i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
// Console.WriteLine(corporate.Length);
// Console.WriteLine(external.Length);
// Console.WriteLine(corporate.GetLength(0));
// Console.WriteLine(corporate.GetLength(1));

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    email(corporate[i,0],corporate[i,1],"contoso.com");
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    email(external[i,0],external[i,1],externalDomain);
}

void email(string first,string last,string domain="contoso.com")
{
   string email = first.Substring(0,2).ToLower() + last.ToLower() + domain;
   Console.WriteLine($"{email}"); 
}