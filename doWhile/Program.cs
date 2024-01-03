/*
// Eljemplo de uso de instrucción do-while.
 Random random = new Random();
 int current = 0;

 do
 {
    current = random.Next(1, 11);
    Console.WriteLine(current);
 }
 while ( current != 7);
*/

/*
// Ejempl de uso de instrucción while.
Random random = new Random();
int current  = random.Next(1, 11);
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last numbre: {current}");
*/

//Desafío de código: La batalla del juego de rol.
/*
primero inicializo las varaiables que voya usar: salud del heroe y le monstruo;
la salud restada por cada ataque.
*/
/*
Random random = new Random();
int herosHealth = 10;
int monstersHealth = 10;

do
{
    int herosAtk = random.Next(1, 10);
    monstersHealth -= herosAtk;
    Console.WriteLine($"Monster was damaged and lost {herosAtk} health and now has {monstersHealth} health.");
    //La solución propuesta por como posible solución presneta la siguiente instrucción como método de escape:
    // if (monstersHealth <= 0) continue;
    if (monstersHealth > 0)
    {
        int monstersAtk = random.Next(1, 10);
        herosHealth -= monstersAtk;
        Console.WriteLine($"Hero was damaged andon lost {monstersAtk} health and now has {herosHealth} health.");
    }
}
while(herosHealth > 0 && monstersHealth > 0);

// En esta sección las instruccion propuesta como posible solución es:
// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!);

if (herosHealth > 0)
    Console.WriteLine("The Hero wins!");
else if (monstersHealth > 0)
    Console.WriteLine("The Mosnter wins!");
*/

// Desafío para marcar la diferencia entre do-while y while.

//Administración de método de entrada.
/*
string? readResult;

do
{
    readResult = Console.ReadLine();
    
} while (readResult == null);
*/

// Ejemplor de admonistración de entrada avanzada. se pide que la entrada tenga más de tres caracteres.
/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three Characters: ");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3) //uso el método ".Length" para saber cuantos caracteres tiene la cadena de entada.
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
*/
// Ejemplo de método de conversión de tipo de valor.
/*
string? readResult;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Ingrese un número: ");
readResult = Console.ReadLine();

validNumber = int.TryParse(readResult, out numericValue);

Console.WriteLine($"Número ingresado: {numericValue}    ¿Es válido?: {validNumber}");
*/

// Desaío de código: escritura de código que valida la entrada de enteros.

