// Esta parte del código  corresponde a la primer evaluación.
//Random random = new Random();
//int value = random.Next(10);
//Console.WriteLine($"{(value >= 5 ? "heads": "tails")}");

// Esta parte del código corresponde a la segunda evaluación.

string permission = "pepeito";
int level = 0;
if (permission.Contains("Admin"))
{
    Console.WriteLine((level >55 ? "Welcome, Super Aadmin user.": "Welcome, Admin user."));
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine((level > 20 ? "Contact an Admin fo access.": "You do not have sufficient privileges."));
}
else
{ 
    Console.WriteLine("You do not ahve sufficient privileges.");
}