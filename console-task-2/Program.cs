// Manipulate integral and floating point numbers in C#

// int
int a = 18;
int b = 6;

// Addition
int c = a + b;
Console.WriteLine($"{a} + {b} = {c}");

// Subtraction 
c = a - b;
Console.WriteLine($"{a} - {b} = {c}");

// Multiplication
c = a * b;
Console.WriteLine($"{a} * {b} = {c}");

// Division
c = a / b;
Console.WriteLine($"{a} : {b} = {c}");

// Order of operations
a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine($"{a} + {b} * {c} = {d}");

d = (a + b) * c;
Console.WriteLine($"({a} + {b}) * {c} = {d}");

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine($"({a} + {b}) - 6 * {c} + (12 * 4) / 3 + 12 = {d}");

a = 7;
b = 4;
c = 3;
d = (a + b) / c;
Console.WriteLine($"({a} + {b}) / {c} = {d}");