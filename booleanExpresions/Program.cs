// Ejemplos de uso de operador de igualdad.
//Console.WriteLine("a" == "a");
//Console.WriteLine("a" == "A");
//Console.WriteLine(1 == 2);
//
//string myValue = "a";
//Console.WriteLine(myValue == "a");

//string  value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.TrimEnd().ToLower());

// Ejemplos de uso de operador de desigualdad.
//Console.WriteLine("a" != "a");
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);
//
//string myValue = "a";
//Console.WriteLine( myValue != "a");

// Ejemplos de uso de operadores de mayor que y menor que.
//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

//string pangram = "The quick brown fox jumps over the lazy dog";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));
//
//Console.WriteLine(pangram.Contains("fox") == false);
//Console.WriteLine(!pangram.Contains("fox"));

// Ejemplo de uso de un operador de nagación lógica.
//string pangram = "Thequick brown fox jumps over the lazy dog";
//Console.WriteLine(!pangram.Contains("fox"));
//Console.WriteLine(!pangram.Contains("cow"));

//int a = 7;
//int b = 6;
//Console.WriteLine(a != b);
//
//string s1 = "Hello";
//string s2 = "Hello";
//Console.WriteLine( s1 != s2);

// Ejemplo de implementación de operador condicioanal.
//int saleAmount = 1002;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");

// Ejemplo de implementación de operador condicional implicito.
int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount >1000 ? 100 : 50)}");
