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
string internalDomain = "contoso.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    GenerateInternalDomain(i);   
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    GenerateExternalDomain(i);
}


void GenerateInternalDomain(int index)
{
    // returns a substring with the first letter of the name.
    string firstLetter = corporate[index, 0].Substring(0,2).ToLower();
    string lastName = corporate[index,1].ToLower();
    Console.WriteLine($"{firstLetter}{lastName}@{internalDomain}");
}

void GenerateExternalDomain(int index)
{
    // returns a substring with the first letter of the name.
    string firstLetter = external[index, 0].Substring(0,2).ToLower();
    string lastName = external[index,1].ToLower();
    Console.WriteLine($"{firstLetter}{lastName}@{externalDomain}");
}