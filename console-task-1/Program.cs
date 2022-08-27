//string with name
string aName = "Michał";
Console.WriteLine($"Hello {aName}!");

// xyz.lenght
Console.WriteLine("----------------------------------");
string firstName = "Michał";
string secondName = "Kaja";
Console.WriteLine($"My friends are {firstName} and {secondName}");

Console.WriteLine($"The name {firstName} has {firstName.Length} letters");
Console.WriteLine($"The name {secondName} has {secondName.Length} letters");

//  xyz.TrimStart()   xyz.TrimEnd()   xyz.Trim()
Console.WriteLine("----------------------------------");
string helloWorld = "    Hello World!    ";
Console.WriteLine($"[{helloWorld}]");

string trimedHelloWorld = helloWorld.TrimStart();
Console.WriteLine($"[{trimedHelloWorld}]");

trimedHelloWorld = helloWorld.TrimEnd();
Console.WriteLine($"[{trimedHelloWorld}]");

trimedHelloWorld = helloWorld.Trim();
Console.WriteLine($"[{trimedHelloWorld}]");

// xyz.Replace(A, B)
Console.WriteLine("----------------------------------");
string sayHello = "Hello World!";
Console.WriteLine($"{sayHello}");

sayHello = sayHello.Replace("Hello", "Hi");
Console.WriteLine($"{sayHello}");

// xyz.ToUpper()   xyz.ToLower()
Console.WriteLine("----------------------------------");
Console.WriteLine($"{sayHello.ToUpper()}");
Console.WriteLine($"{sayHello.ToLower()}");

// xyz.Contains("...") - False/True
Console.WriteLine("----------------------------------");
string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

// boll - False/True   xyz.StartsWith 
Console.WriteLine("----------------------------------");
bool result = songLyrics.StartsWith("You");
Console.WriteLine(result);
result = songLyrics.EndsWith("goodbye");
Console.WriteLine(result);