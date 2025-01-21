// top level statement

byte v1 = 10;
Console.WriteLine(v1);
Console.WriteLine($"Size of byte : {sizeof(byte)} Min : {byte.MinValue} " +
    $"Max : {byte.MaxValue}");

short v2 = 10000;
Console.WriteLine(v2);
Console.WriteLine($"Size of short : {sizeof(short)} Min : {short.MinValue} " +
    $"Max : {short.MaxValue}");

int v3 = 50000;
Console.WriteLine(v3);
Console.WriteLine($"Size of int : {sizeof(int)} Min : {int.MinValue} " +
    $"Max : {int.MaxValue}");

long v4 = 9527788887;
Console.WriteLine(v4);
Console.WriteLine($"Size of long : {sizeof(long)} Min : {long.MinValue} " +
    $"Max : {long.MaxValue}");

float v5 = 10.5f;
Console.WriteLine($"float : {v5} size : {sizeof(float)} bytes");

double v6 = 10.56;
Console.WriteLine($"double : {v6} size : {sizeof(double)} bytes");

decimal v7 = 10.5678m;
Console.WriteLine($"decimal : {v7} size : {sizeof(decimal)} bytes");

bool v8 = false;
Console.WriteLine($"bool : {v8} size : {sizeof(bool)} bytes");


char v9 = '$';
Console.WriteLine($"char : {v9} size : {sizeof(char)} bytes");

string v10 = "vishal";
Console.WriteLine(v10);

Console.ReadKey(); // wait