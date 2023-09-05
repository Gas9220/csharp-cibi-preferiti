// Inizializzo l'array di cibi
string[] foods = { "Banana", "Pasta", "Coconut", "Pizza", "Tofu", "Lentils", "Potatoes" };

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
Console.WriteLine($"My last top food is {foods[6]}");