using System;

short i = 10;

Console.WriteLine($"short i : {i}");

int j = i;

Console.WriteLine($"int j = {j}");
// implicite conversion by the compiler

float k = j;

Console.WriteLine($"float : {k}");

k = 10.5f;

// Console.WriteLine($"float : {k}");
// it Severity	Code Cannot implicitly convert type 'float' to 'int'.
// An explicit conversion exists (are you missing a cast?)

int i1 = (int)k;

Console.WriteLine($"float : {i1}");
// it converts into float but misses out numbers after decimal

string num = "10";

j = Convert.ToInt32(num);
Console.WriteLine($"int j : {j}");

num = "100";

j = Convert.ToInt32(num);
Console.WriteLine($"int j : {j}");

num = "7066397267";

long o = Convert.ToInt64(num);
Console.WriteLine($"long o : {o}");


num = "100";

j = int.Parse(num);
Console.WriteLine($"int j : {j}");

num = "100";

bool status = int.TryParse(num, out j);
Console.WriteLine($"conversion status: {status} int j : {j}");

num = "akjfdfk";

status = int.TryParse(num, out j);
Console.WriteLine($"conversion status: {status} int j : {j}");
// if it returns false value then it sets default value of datatype

Console.ReadKey();

