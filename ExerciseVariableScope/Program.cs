//// Ejemplo de uso de varaibles dentro y fuera del de ámbito local.
//bool flag = true;
//int value = 0; 
//// "value" se inicializa como una variable global que puede ser usada dentro y 
//// fuera del bloque de código.
//
//if (flag)
//{
//    // En este caso "value" se inicializa dentro del bloque de código
//    // como una variable local.
//    // int value = 10;
//    // En el caso de que "value" haya sido inicializada de manera global 
//    // puedo cambiar su valor dentro de un bloque de código.
//    value = 10;
//    Console.WriteLine($"Inside of code block: {value}");
//}
//// Esta instrucción no funcionaría si "value" fuera una variable local.
//Console.WriteLine($"Outside of the code block: {value}");

//// Ejemplo de como usar el condicional if con una sola línea de código.
//// A este tipo de escritura se le llama "Formulario de una sola línea".
//// Es posible NO utilizar las llaves de apertura y de cierre para una sola línea de 
//// código.
//bool flag = true;
//if (flag)
//    Console.WriteLine(flag);

//// Ejemplo de uso incorrecto de formularios de una sola línea.
//// Si bien el compilador lo lee y lo ejecuta correctamente es de dificil comprension
//// para la persona que lee el código.
//// Esto es considerado una mala práctica.
//string name = "Steve";
//if (name == "Bob") Console.WriteLine("Found Bob");
//else if (name == "Steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chuck");

//// Ejemplo de uso correcto de formulario de una sola línea.
//// En comparación con el ejemplo anterior este es mucho más legible para una persona
//// que lee el código.
//string name = "Steve";
//
//if (name == "Bob")
//    Console.WriteLine("Found Bob");
//else if (name == "Steve")
//    Console.WriteLine("Found Steve");
//else 
//    Console.WriteLine("Found Chuck");


//// Desafio: Mejorar el siguiente código en base a los conceptos anteriores.

//int[] numbers = { 4, 8, 15, 16, 23, 42 };
//
//foreach (int number in numbers)
//{
//    int total;
//
//    total += number;
//
//    if (number == 42)
//    {
//       bool found = true;
//
//    }
//
//}
//
//if (found) 
//{
//    Console.WriteLine("Set contains 42");
//
//}
//
//Console.WriteLine($"Total: {total}");

//// Código mejorado:

int[] numbers = {4, 8, 15, 16, 23, 42};
int total = 0;
bool found = false;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
