// Ejemplo de uso de instrucción switch. 

//int employeeLevel = 100;
//string employeeName = "John Smith";
//
//string title = "";
//
//switch (employeeLevel)
//{
//// Patrón de casos.
//    //case 100:
//    //    title = "Junior Associate";
//    //    break;
//    // En el caso de que dos valores tengan el mismo resultado puedo evaluar dos valores
//    // al mismo tiempor de la siguiente manera.
//    case 100:
//    case 200:
//        title = "Senior Associate";
//        break; // Termina con la ejecución de bloque de código correspondiente
//               // a la instrucción switch.
//    case 300:
//        title = "Manager";
//        break;
//    case 400:
//        title = "Senior Manager";
//        break;
//    default: // Es el caso que ejecuta un bloque de código en caso de que nunguna
//             // de los casos anteriores se cumpla.
//        title = "Associate";
//        break;
//}
//
//Console.WriteLine($"{employeeName}, {title}");

// Desafío: Convertir el suguiente código if-elseif-else en una estructura switch que cumpla
// el mismo funcionamiento.

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
//string sku = "01-MN-L";
//
//string[] product = sku.Split('-'); 
//// ".Split" dividirá el string entrante en strings dentro de una lista en tanto
////  esten separados por un guíon (-). 
//
//string type = "";
//string color = "";
//string size = "";
//
//if (product[0] == "01")
//{
//    type = "Sweat shirt";
//} else if (product[0] == "02")
//{
//    type = "T-Shirt";
//} else if (product[0] == "03")
//{
//    type = "Sweat pants";
//}
//else
//{
//    type = "Other";
//}
//
//if (product[1] == "BL")
//{
//    color = "Black";
//} else if (product[1] == "MN")
//{
//    color = "Maroon";
//} else
//{
//    color = "White";
//}
//
//if (product[2] == "S")
//{
//    size = "Small";
//} else if (product[2] == "M")
//{
//    size = "Medium";
//} else if (product[2] == "L")
//{
//    size = "Large";
//} else
//{
//    size = "One Size Fits All";
//}
//
//Console.WriteLine($"Product: {size} {color} {type}");

// Código con instrucciones switch.

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>

string sku = "01-MN-L";

string[] product = sku.Split('-');
// ".Split" dividirá el string entrante en strings dentro de un array en tanto
//  esten separados por un guíon (-). 

// Inicializo las variables vácias que van a contener los valores correspondientes
//  a la prenda que indica el código
string type = "";
string color = "";
string size = "";

// Primero evaluo el primer elemento del array.
// los casos deben evaluar una variable string, no un int. Porque con ese tipo de variable
// guardó en le array.
// Tipo de prenda.
switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

//color de la prenda.
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

// Tamaño de la prenda.
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

//Imprimo la salida resultante.
Console.WriteLine($"Product: {size} {color} {type}");