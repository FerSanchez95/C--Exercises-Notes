
// Reto #0 - El Famoso FizzBuzz. C#

for (int numero = 1; numero < 100; numero++)
{
    if ((numero % 3) == 0 && (numero % 5) == 0)
    {
        Console.WriteLine("fizzBuzz");
    }
    else if ((numero % 5) == 0)
    {
        Console.WriteLine("buzz");
    }
    else if ((numero % 3) == 0)
    {
        Console.WriteLine("fizz");
    }
    else
    {
        Console.WriteLine(numero);
    }
}

