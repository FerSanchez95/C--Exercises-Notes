/*
// Sorting the array.
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
// Command used to sort the array. "Sort() is a method of the class "Array".
// The sort is made alphabetically in base to the first character of the word.
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Reversing the sorted array.
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

//=======================================================

/*
// Clear elements in the array.
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

/*
 The method clear will eliminate and reaplace it with a default value
 for each type of matrix. If the matrix is a string type matrix, the elements 
 wiil be repleaced with a "null" value. With a int type matrix the default value 
 will be zero.
 For example, the next command will eliminate and replace 2 ELEMENTS of the INDEX (0)
 from the array "pallets". 
*/
/*
//Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
// In case the compiler raise nullException try to add the next command.
// And then ask for the element of the array that has been eliminated
//if (pallets[0] != null)
//    Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Add elements to the existing array with ".Resize" method.
Console.WriteLine("");
// The method ".Resize" will take the reference to the array that you want to expand (in this case)
// Making useage of the keyword "ref" to point the array. Next to the reference there is the new
// total length of the array (NO the number of elements you want to add).
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Eliminate elements to the existing array with ".Resize" method.}
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
    
}
*/

//===================================================

/*
// Code to eliminate null values from the array.

// First create an array to eliminate values later and some variables to use.
string[] pallets = { "B14", "A11", "B12", "A13", "C01", "C02" };
int countElements = 0;
int elementsRemoved = 2;

// Eliminate the 2 first elements of the array.
Array.Clear(pallets, 0, elementsRemoved);
Console.WriteLine($"Elements of the array eliminated!\n");

// Count the not null elements in the array.
foreach (var pallet in pallets)
{
    if (pallet != null)
        countElements++;
}

// Create the new array with not null elements counter.
string[] newPallets = new string[countElements];

// Copy the not null elements to the new array.
for (int i = 0; i < countElements; i++)
{
    // Index of the original array plus the number of elements removed.
    if (pallets[i + elementsRemoved] != null)
    {
        newPallets[i] = pallets[i + elementsRemoved];
    }
}
// Print the result array.
foreach (var newPallet in newPallets)
{
    Console.WriteLine($"-- {newPallet}");
}
*/

/*
//Converting a string into a char array.
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
// Use the ".Join" of the class "String" to add delimiters between the characters
// of the array.
//string result = String.Join(",", valueArray);
Console.WriteLine(result);

// The ".Split" method will pull apart the characters of the array using a "," as delimeter.
string[] items = result.Split(",");
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

/*
// Challenge 1.
string pangram = "The quick brown fox jumps over the lazy dog";


// First convert the string into a string array using th spaces as delimiter
// and create a variable that will hold the reversed pangram.
string[] pangramArray = pangram.Split(" ");
string reversedPangram = "";

// Second Coutn how many words are in the array to iterate over it.
int wordCounter = 0;
foreach (string word in pangramArray)
{   
    wordCounter++;
}

// Then create an string array using the word counter.
string[] ReversedWords = new string[wordCounter];

// Making usage of the counter (again) iterate in a for loop to split 
// each word. Create a char array with each word splited and save it in
// the reverse array as a string.
for (int i = 0; i < wordCounter; i++)
{
    char[] splitedWords = pangramArray[i].ToCharArray();
    Array.Reverse(splitedWords);
    ReversedWords[i] = new string(splitedWords);
}

// With the reversedPangram variable create an instance to join the content
// with a sapace between the reversed string array content.
reversedPangram = string.Join(" ", ReversedWords);

Console.WriteLine(reversedPangram);
*/

//Challenge 2

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// First split the string into an array.

string[] orderId = orderStream.Split(",");

// With the new array we can sort it.
Array.Sort(orderId);

// Now, with the string coverted into an array and sorted, we can
// begin to analyze it. 
for (int i = 0; i < orderId.Length; i++)
{
    // Create a char array to count the letters in each order.
    char[] characterLength = orderId[i].ToCharArray();
    // If the code lenght isn't 4 it will show an error. 
    if (characterLength.Length != 4 )
    {
        string charToString = new string(characterLength);
        Console.WriteLine($"{charToString}   - Error");
    }
    else 
        Console.WriteLine(characterLength);
}