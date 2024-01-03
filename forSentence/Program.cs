// Ejemplos de uso de la instrucción "for".

////Ejemplo ciclo "for".
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

////Ejemplo ciclo "for" inverso.
//for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

//// Ejemplo ciclo "for" con omisión de valores.
//for (int i = 0; i < 10; i += 3) // Sumando 3, salto dos valores por iteración.
//{
//    Console.WriteLine(i);
//}

// Ejemplo de ciclo "for" interrumpido por instrucción "break".
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//    if (i == 7)
//        break; 
//        // la instrucción "break" termina la iteración si de cumple el condicional, 
//        // permitiendo que le programa siga.
//}

//Ejemplo de iteración en una matríz de elementos.
//string[] names = { "Alex", "Eddie", "David", "Michael" };
//for (int i = names.Length - 1; i >= 0; i--) // Esta iteración será inversa.
//{
//    Console.WriteLine(names[i]);
//}

// Desafío de código: Implementación de reglas de desafío de FizzBuzz

for (int i = 1; i <= 100; i++)
{   
    if ((i % 3) == 0 && (i % 5) == 0)
        Console.WriteLine($"{i} - FizzBuzz");
    else if ((i % 3) == 0)
        Console.WriteLine($"{i} - Fizz");
    else if ((i % 5) == 0)
        Console.WriteLine($"{i} - Buzz");
    else 
        Console.WriteLine(i);
}