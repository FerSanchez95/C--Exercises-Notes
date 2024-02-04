/*
int first = 2;
string second = "4";
// int result = first + second;
string result = first + second;
Console.WriteLine(result);
// The compiler connot convert from 'string' to an 'int' data type becauce the string can 
// contain any character chain(letters, numbers or symbols). 
*/

/*
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
// Here are no lost information. Because of the type of data type conversion.
// there is a conversion from a less information contain data type to a
// more information data type (int -> decimal).
*/

/*
decimal  myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal; // Coercion. Declare the type of data when instance the variable.
Console.WriteLine($"int: {myInt}");
*/

/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
// reduction of information by changing the data type.
Console.WriteLine($"Decimal : {myDecimal}"); // 0.0000000009
Console.WriteLine($"Float   : {myFloat}"); // 0.000000001
*/

/*
// .ToString() method.

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

*/

/*
//.Parse() method.

string first = "5";
string second = "7";

int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

*/
/*
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

*/
/*
// Convert to an specified data type with Convert class.
int value = (int)1.5m;
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2);
*/

/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result)) 
// if the value can be converted to "int" data type then the operation returns true.
// the converted value is stored in "result".
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
if (result > 0)
    Console.WriteLine($"Measurement (w/offset): {50 + result}");
*/

/*
//  First practice challenge.
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-US");

string[] values = ["12.3", "45", "ABC", "11", "DEF"];
string message = "";
float total = 0f;
foreach (string x in values)
{
    if (float.TryParse(x, out float result))
        total += result;
    else
        message += x;
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/

// Second practice challenge.
using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("en-us");

int value = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = value / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");