// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// int length = closingPosition - openingPosition;
// // openingPosition += 1;
// // int alternative = message.Length;
// // Console.WriteLine(length);
// // Console.WriteLine(alternative);
// Console.WriteLine(message.Substring(openingPosition,length));

// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);
// openingPosition +=1;
// int length = closingPosition - openingPosition;

// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?;";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span");

// openingPosition +=6;

// int length = closingPosition - openingPosition;

// Console.WriteLine(message.Substring(openingPosition,length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";

// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition,length);

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";

// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition,length));

//     // Note the overload of the Substring to return only the remaining
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i' };

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");


// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

// string message ="(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// // The IndexOfAny() helper method requires a char array of characters.
// // You want to look for:

// char[] openSymbols = {'[','{','('};

// // You'll use a slightly different technique for iterating through
// // the characters in the string. This time, use the closing
// // position of the previous iteration as the starting index for the
// // next open symbol. So, you need to initialize the closingPosition
// // variable to zero:

// int closingPosition = 0;


// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols,closingPosition);
//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition,1);

//     // Now find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
        
//         case "{":
//             matchingSymbol = '}';
//             break;

//         case "(":
//             matchingSymbol = ')';
//             break;
//     }
//     // To find the closingPosition, use an overload of the IndexOF method to specify
//     // that the search for the matchingSymbol should start at the openingPosition in the string.

//     openingPosition +=1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition,length));

// }



// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5,20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--"," ");
// message = message.Replace("-","");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
// Console.WriteLine(input);
// Console.WriteLine("0123456789012345678901234567890123456789012345678901");
string quantity = "";
string output  = "";

// Your work here
string openSpan = "<span>";
string closeSpan ="</span>";
int openSpanIndex = input.IndexOf(openSpan);
int lastopenSpanIndex = openSpanIndex + openSpan.Length;
// Console.WriteLine(openSpanIndex);
// Console.WriteLine(lastopenSpanIndex);
int closeSpanIndex = input.IndexOf(closeSpan);
// Console.WriteLine(closeSpanIndex);
int length = closeSpanIndex - lastopenSpanIndex;

quantity = input.Substring(lastopenSpanIndex,length);
quantity = $"Quantity:  {quantity}";

string divStart = "<div>";
int divStartIndex =input.IndexOf(divStart);
int divStartLength = divStart.Length;
output = input.Remove(divStartIndex,divStartLength);//line 205
string divEnd = "</div>";
int divEndLength = divEnd.Length;
int divEndIndex = output.IndexOf(divEnd);

output = output.Remove(divEndIndex,divEndLength);// line 206
output = output.Replace("trade","reg");
output = "Output: " + output;

// output = input.Replace("trade","reg");

Console.WriteLine(quantity);
Console.WriteLine(output);
