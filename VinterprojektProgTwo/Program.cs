global using System;

Hero h1 = new Hero();
Enemy e1 = new Enemy();



Console.WriteLine("What's the name of your hero?");
h1.Name = Console.ReadLine();
Console.WriteLine($"Your hero's name is {h1.Name}.");

Console.ReadLine();
