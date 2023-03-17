#region Liskov Substitution Principle
using SOLID_Principles.LSP;

Apple apple = new Orange();
Console.WriteLine(apple.GetColor());

Fruit fruit = new Orange2();
Console.WriteLine(fruit.GetColor());
fruit = new Apple2();
Console.WriteLine(fruit.GetColor());
#endregion