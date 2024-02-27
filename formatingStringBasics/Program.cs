// Formating strings basics.

/*
// -> Composite format
string first = "Hello";
string second = "World";
Console.WriteLine("{0} {1}!", first, second);
// or 
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);
*/

/*
// -> Interpolation format
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
// or
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
*/

/*
// -> Format for money value
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:c} (Save: {discount:C})");
*/

/*
// -> Format for big numbers.
decimal measurement = 123456.78912m;
//Console.WriteLine($"Measurement: {measurement:N} units");
// The number with the specifier is the number of decimals showed arfter the delimeter.
Console.WriteLine($"Measurements: {measurement:N4} units");
*/

/*
// Format for porcentage.
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
*/

// Combination of formating focus.
// the variables can store chains made with format techniques.
decimal price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("yout saved {0:c2} off the regular {1:C2} price. ", (price - salePrice), price);
yourDiscount += $"A discount of {((price -salePrice)/price):P2}!"; //inserted.
Console.WriteLine(yourDiscount);