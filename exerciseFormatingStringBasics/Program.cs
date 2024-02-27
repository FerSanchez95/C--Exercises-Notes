/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subTotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;
Console.WriteLine($"");
Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3} Product");
Console.WriteLine($"        Sub Total: {subTotal:C}");
Console.WriteLine($"            Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");
Console.WriteLine($"");
*/

/*
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
*/

/*
string paymentID = "769c";
string payeeName = " Mr. Stephen Ortega";
string paymentAmount = "$5.000,00";

var formatedLine = paymentID.PadRight(6);
formatedLine += payeeName.PadRight(24);
formatedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formatedLine);
*/

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
string initialMessage = $"\nDear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.";
Console.WriteLine(initialMessage);
string currentStatus = $"\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P2}";
Console.WriteLine(currentStatus);
string newProductPresentation = $"\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}\n";
Console.WriteLine(newProductPresentation);

Console.WriteLine("Here's a quick comparison:\n");

// My solution
//string comparisonMessage = $"{currentProduct.PadRight(15)}\t\t{currentReturn:P2}\t\t{currentProfit:C2}\n{newProduct}\t\t{newReturn:P2}\t\t{newProfit:C2}\n";

// Example solution.
string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);