// Manipulate integral and floating point numbers in C#

// int
using System;
using System.Runtime.InteropServices;

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
Console.WriteLine("int - precision and limits");
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
int maxInt = int.MaxValue;
int minInt = int.MinValue;
Console.WriteLine($"The range of integers is {minInt} to {maxInt}");

int what = maxInt + 3;
Console.WriteLine($"An example of overflow: {what} (max +3)");

//double
Console.WriteLine("-------------------------------------------");
Console.WriteLine("double - precision and limits");
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
Console.WriteLine($"Double - 1 : 3 = {third}");

// Max and min - double
Console.WriteLine("-------------------------------------------");
double maxDouble = double.MaxValue;
double minDouble = double.MinValue;
Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

// decimal
Console.WriteLine("-------------------------------------------");
Console.WriteLine("decimal - precision and limits");

decimal minDecimal = decimal.MinValue;
decimal maxDecimal = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");

decimal aaa = 1.0M;
decimal bbb = 3.0M;
decimal thirdDecimal = aaa / bbb;
Console.WriteLine($"Decimal - 1 : 3 = {thirdDecimal}");

//long
Console.WriteLine("-------------------------------------------");
Console.WriteLine("long - precision and limits");

long minLong = long.MinValue;
long maxLong = long.MaxValue;
Console.WriteLine($"The range of the long type is {minLong} to {maxLong}");

long aaaa = 1;
long bbbb = 3;
long thirdLong = aaaa / bbbb;
Console.WriteLine($"Long - 1 : 3 = {thirdLong}");

//short
Console.WriteLine("-------------------------------------------");
Console.WriteLine("short - precision and limits");

long minShort = short.MinValue;
long maxShort = short.MaxValue;
Console.WriteLine($"The range of the short type is {minShort} to {maxShort}");

long aaaaa = 1;
long bbbbb = 3;
long thirdShort = aaaaa / bbbbb;
Console.WriteLine($"Short - 1 : 3 = {thirdShort}");

// area of cirle
double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine($"PI * 2,5 * 2,5 = {area}");