//string with name
string aName = "Michał";
Console.WriteLine($"Hello {aName}!");

// .lenght
Console.WriteLine("----------------------------------");
string firstName = "Michał";
string secondName = "Kaja";
Console.WriteLine($"My friends are {firstName} and {secondName}");

Console.WriteLine($"The name {firstName} has {firstName.Length} letters");
Console.WriteLine($"The name {secondName} has {secondName.Length} letters");

//  .TrimStart()   .TrimEnd()   .Trim()
Console.WriteLine("----------------------------------");
string helloWorld = "    Hello World!    ";
Console.WriteLine($"[{helloWorld}]");

string trimedHelloWorld = helloWorld.TrimStart();
Console.WriteLine($"[{trimedHelloWorld}]");

trimedHelloWorld = helloWorld.TrimEnd();
Console.WriteLine($"[{trimedHelloWorld}]");

trimedHelloWorld = helloWorld.Trim();
Console.WriteLine($"[{trimedHelloWorld}]");

// .Replace(A, B)
Console.WriteLine("----------------------------------");
string sayHello = "Hello World!";
Console.WriteLine($"{sayHello}");

sayHello = sayHello.Replace("Hello", "Hi");
Console.WriteLine($"{sayHello}");

// .ToUpper()   .ToLower()
Console.WriteLine("----------------------------------");
Console.WriteLine($"{sayHello.ToUpper()}");
Console.WriteLine($"{sayHello.ToLower()}");
