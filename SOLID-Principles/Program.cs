#region Liskov Substitution Principle
using ExWithoutUsingLSP = SOLID_Principles.LSP.ExWithoutUsingLSP;
using ExWithUsingLSP = SOLID_Principles.LSP.ExWithUsingLSP;


//Without LSP
ExWithoutUsingLSP.Apple apple = new ExWithoutUsingLSP.Orange();
Console.WriteLine(apple.GetColor());

//With LSP
ExWithUsingLSP.Fruit fruit = new ExWithUsingLSP.Orange();
Console.WriteLine(fruit.GetColor());
fruit = new ExWithUsingLSP.Apple();
Console.WriteLine(fruit.GetColor());
#endregion