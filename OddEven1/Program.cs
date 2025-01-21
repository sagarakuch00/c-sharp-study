


List<int> oddNumbers = new List<int>();
List<int> evenNumbers = new List<int>();

Console.WriteLine("Enter how many numbers you want to input : ");
int count = int.Parse(Console.ReadLine());


Console.WriteLine("Enter the numbers : ");

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Enter a number {i + 1} : ");

    if (int.TryParse(Console.ReadLine(), out int number))
    {
        if (number % 2 == 0)
        {
            evenNumbers.Add(number);
        }
        else
        {
            oddNumbers.Add(number);
        }
    }
    else 
    {
        Console.WriteLine("Invalid input. Please enter a valid number. ");
        i--;
    }
}

Console.WriteLine("\nOdd Numbers: " + string.Join(", ", oddNumbers));
Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));




#region using while loop

//List<int> oddNumbers = new List<int>();
//List<int> evenNumbers = new List<int>();

//Console.WriteLine("Enter numbers one by one. Type 'stop' to finish:");

//while (true)
//{
//    Console.Write("Enter a number: ");
//    string input = Console.ReadLine();


//    if (input.ToLower() == "stop")
//        break;


//    if (int.TryParse(input, out int number))
//    {

//        if (number % 2 == 0)
//            evenNumbers.Add(number);
//        else
//            oddNumbers.Add(number);
//    }
//    else
//    {
//        Console.WriteLine("Invalid input. Please enter a valid number.");
//    }
//}

//Console.WriteLine("\nOdd Numbers: " + string.Join(", ", oddNumbers));
//Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

#endregion using while loop
