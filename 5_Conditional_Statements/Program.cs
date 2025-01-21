
Console.WriteLine("Please enter a number");

int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Input number is : {input}");


if (input == 10)
{
    Console.WriteLine($"Input number is : {input}");

}
else
{
    Console.WriteLine($"{input} : The No. is not Ten ");

}


// ternary operator

string result = (input == 10) ? "Ten" : "Not Ten";
Console.WriteLine($"{input}: {result}");


string isEven = (input % 2 == 0) ? "The number is even" : "The number is odd";
Console.WriteLine($"{input} {isEven}");




Console.ReadKey();




