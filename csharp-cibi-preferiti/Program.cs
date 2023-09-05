// Inizializzo l'array di cibi
using System;

string[] foods = { "Banana", "Pasta", "Coconut", "Pizza", "Tofu", "Lentils", "Tomatoes", "Orange" };

// Lenght of the array
Console.WriteLine($"There are {foods.Length} foods on the array");

// Print all foods
for (int i = 0; i < foods.Length; i++)
{
    Console.WriteLine($"{i + 1}° {foods[i]}"); 
}

// Top food
Console.WriteLine($"My top food is {foods[0]}");

// Last food
Console.WriteLine($"My last top food is {foods[foods.GetUpperBound(0)]}");

// If foods array lenght is odd
if ( foods.Length % 2 != 0)
{
    string middleElement = foods[foods.Length / 2];
    Console.Write("Foods lenght is odd - ");
    Console.WriteLine($"The middle element is {middleElement}");
} else // If foods array lenght is even
{
    string middleElement1 = foods[foods.Length / 2];
    string middleElement2 = foods[foods.Length / 2 - 1];
    Console.Write("Foods lenght is even - ");
    Console.WriteLine($"The two middle elements are {middleElement1}, {middleElement2}");
}