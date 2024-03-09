/*

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

//Console.WriteLine(openingPosition);
//Console.WriteLine(closingPosition);

openingPosition += 1;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// >> IndexOf() function example.
/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPositions = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;

int length = closingPositions - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));

*/

// >> LastIndexOf() function example.
/*

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

/*
// Retrive parentheses content only.

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Creates a new substring from the original, begining with the 
    // last index of the generated substring.
    message = message.Substring(closingPosition + 1);
}
*/

// >> IndexOfAny function example.

/*
string message = "Help (find) the {opening symbol}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = {'[', '{', '('};
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHout using StratPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

*/

// >> Search of the maching symbol.

/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] opensymbols = {'[', '{', '('};

// closingPposiotion will change inside the while loop.
int closingPosition = 0;

while (true)
{
    // The next line will return the index value of any char of the array starting from the closingPosition.
    // In the first iteration closingPosition will be 0. Then the search will start from the index 0.
    int openingPosition = message.IndexOfAny(opensymbols, closingPosition);

    if (openingPosition == -1) break;
    
    // currentSymbol is the sub-string symbol obteined using the index of the openingPosition and the 
    // next character. It's read like (openinPosition, openingPosition + 1). The sub-string will contain
    // the opening symbol found by the function IndexOfAny. 
    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[": // Double quotes for strings.
            matchingSymbol = ']'; // Simple qoutes for char.
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To obtain the index of the closing maching symbol the search should start from the next character
    // after the symbol. 
    openingPosition += 1;
    
    // Then search for the closing matching symbol with the fucntion IndexOf.
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // now generate a new sub-string for the next iteration.
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

// >> String functions. Repalce and remove methods.

/*
// Remove method example. 
// The string method 'Remove' is used to remove part of a string. It uses two arguments:
// a start index and an end index. Those indexes represents the part of the string to be removed. 

string data = "12345John Smith          5000  3  ";
string updateData = data.Remove(5, 20);
Console.WriteLine(updateData);
*/

/*
// Repalce method example.
// The string method 'Repalce' can replace some characters in a string for anhoter ones.
// Like the 'Remove' method, it wil take two arguments: the character or the string to
// replaced and the character or string that will occupy that place. 

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/

// >> Exercise: replace and remove data from a string.

// First aproach.
/*
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// First remove the div labels.
// Obtain the idexes for the first '<' and the last '</'.
// Expression coded by me.
int[] index = new int[2];
index[0] = input.IndexOf('<');
index[1] = input.LastIndexOf("</");

// Expresion given by the code editor.
//int[] index = [input.IndexOf('<'), input.LastIndexOf("</")];

// Now we can use the indexes to remove the div labels. We know that the after the 
// expresions are four charactes. 
// 01234    012345
// <div>    </div>
// Both remove methods should have an end index equal to index[x] + 4.
output = input.Remove(index[0], index[0] + 4);
output = input.Remove(index[1], index[1] + 4);

// ERROR: Unhandled exception. System.ArgumentOutOfRangeException: count ('50') must be less
// than or equal to '6'. (Parameter 'count'). Actual value was 50. line 179.

// To see the output message so far we should pritn it in  the terminal.
Console.WriteLine(output); 

Console.WriteLine(quantity);
Console.WriteLine(output);
*/

// second aproach.
using System.ComponentModel.DataAnnotations;

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

//  -- Remove the div labels --

// For that the index of both expressions are needed.
// Define the new index variable.
int index = 0;

// Retrive the first '<' character index correspondign to teh <div>.
index = input.IndexOf('<');
// Remove the <div> label knowing there is four characters after the index position.
// 01234    So the total characters to be removed are five starting from the index.
// <div>    The Index value is before the character that the metohd 'IndexOf' search for.

output = input.Remove(index, 5);

// The output in the terminal -> <h2>Widgets &trade;</h2><span>5000</span></div>

// Now we do the same to remove the </div>. For this operation some values will change.
// Instead of 'input' we're going to use 'output' to get the index, because now that the
// <div> has been removed, all the indexes of the string changed.
// Use the 'LastIndexOf' method to get the "</" of the closing tag that is at the end of the string. 
// And to remove the label we're going to sum six instead of five to the index. This is
// because the closing tag has one more character '/'.

index = output.LastIndexOf('<');
output = output.Remove(index, 6);

// The output in the terminal -> <h2>Widgets &trade;</h2><span>5000</span>

// -- Replace the '&trade' tag --

// The 'Replace' method uses strings like arguments, so we´re going to pass the tags explicity
// to the method. Always using and modifying the 'output'.

output = output.Replace("&trade", "&reg");

// The output in the terminal -> <h2>Widgets &reg;</h2><span>5000</span>

// -- Obtain the Quantity value --

// For this part we're going to obtain the index of both: opening and closing 'span' tags.
// Wiht both indexes gnerate a sub-string that contains the value.

// Create the tag values like constant variables.
const string openTag = "<span>";
const string closeTag = "</span>";

// Now use the constant to obtain the indexes.
int startIndex = output.IndexOf(openTag);
int endIndex = output.IndexOf(closeTag);

// Modify the 'startIndex' with the sum of the characters in the 'span' tag.
// 012345
// <span>
startIndex += 6;

// The Substring method takes two arguments: the start index value of the original string (the new zero of the string)
// and the length of the new string based on the original string. So, the length is equal to the difference between
// the start index and the end index. Remember endIndex > startIndex.

int length = endIndex - startIndex;

// Generate the sub-string with the value for 'Quantity' using the 'startIndex' and 'length'.
quantity = output.Substring(startIndex, length);


Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");