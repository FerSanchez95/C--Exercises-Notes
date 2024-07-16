using System.Runtime.CompilerServices;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay(Console.ReadLine())) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetRandom();
        var roll = GetRandom();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay(Console.ReadLine());
    }
}

bool ShouldPlay(string? response)
{
    bool rePlay = false;
    if (response is not null && response.Equals("y"))
    {
        rePlay = true;
    }
    return rePlay;
}

int GetRandom()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    string message = "You Lose!";
    if (roll > target)
    {
        message = "You win!";
    }
    return message;
}