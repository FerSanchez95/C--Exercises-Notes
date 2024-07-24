﻿using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

// Llamada al método principal.
PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

/*
   El siguiente método actua como el método principal
   del programa (main). 
   El mismo posee dos parametros:
    - schoolName: Este parámetro se ingresa como argumetno
                  al llamar al método.
    - groups: Este es un parámetro inicializado, el cuál
              actua como un parámetro opcional.
  Si se ingresa un argumento del tipo 'int' en la posición
  del parámetro opcional, este argumento va a sobreescribir 
  el valor por defecto del parámetro inicializado en el método.
  Si no se desea respetar la posición de los parámetros al 
  ingresar los argumentos, estos últimos deben ingresarse 
  precedidos por el nombre del parámetro escrito en la firma del 
  método.
*/   
void PlanSchoolVisit(string schoolName, int groups = 6)
{
  RandomizeAnimals();
  string[,] group = AssignGroup(groups);
  Console.WriteLine(schoolName);
  PrintGroup(group);
}

// Métodos

void RandomizeAnimals()
{
  Random random = new Random();

  for (int i = 0; i < pettingZoo.Length; i++)
  {
    int r = random.Next(i, pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
  }

}

/*
En este ejercicio utilizo varias matrices 2D (matrices de 
dos dimensiones). Por lo tanto para trabajar con ellas voy a 
tener que íterar dos veces por cada elemento dentro de otro 
elemento.
*/

string[,] AssignGroup( int groups = 6)
{
  string[,] result = new string[groups, pettingZoo.Length/groups];
  int start = 0;
  
  for (int i = 0; i < groups; i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      result[i,j] = pettingZoo[start++];
    }
  }
  return result;
}

void PrintGroup(string[,] group)
{
  for (int i = 0; i < group.GetLength(0); i++)
  {
    Console.Write($"Group {i + 1}: ");
    for (int j = 0; j < group.GetLength(1); j++)
    {
      Console.Write($"{group[i,j]} ");
    }
    Console.WriteLine();
  }
}
