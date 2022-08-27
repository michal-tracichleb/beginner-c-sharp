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
Console.WriteLine("-------------------------------------------");
a = 5;
b = 4;
c = 2;
int d = a + b * c;
Console.WriteLine($"{a} + {b} * {c} = {d}");

d = (a + b) * c;
Console.WriteLine($"({a} + {b}) * {c} = {d}");

d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine($"({a} + {b}) - 6 * {c} + (12 * 4) : 3 + 12 = {d}");

//Explore integer precision and limits
Console.WriteLine("-------------------------------------------");
// Integer division truncates the result
a = 7;
b = 4;
c = 3;
d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"int: ({a} + {b}) : {c} = {d} - the wrong answer!");
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");

// Max nad min - int
Console.WriteLine("-------------------------------------------");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what} (max +3)");

//double
Console.WriteLine("-------------------------------------------");
double aa = 5;
double bb = 4;
double cc = 2;
double dd = (aa + bb) / cc;
Console.WriteLine($"({aa} + {bb}) : {cc} = {dd}");

aa = 19;
bb = 23;
cc = 8;
dd = (aa + bb) / cc;
Console.WriteLine($"({aa} + {bb}) : {cc} = {dd}");

double third = 1.0 / 3.0;
Console.WriteLine($"1 : 3 = {third}");

// Max and min - double
Console.WriteLine("-------------------------------------------");
double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

// 
Console.WriteLine("-------------------------------------------");
