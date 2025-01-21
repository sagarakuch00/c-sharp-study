
int i = 10;  // value type
Console.WriteLine(i); 

object o = i; // int => object, value type => reference type == Boxing
Console.WriteLine($"o : {o}");

int j = (int)o;
Console.WriteLine($"j : {j}"); // object => int , reference type => value type = Unboxing

Console.ReadKey();
