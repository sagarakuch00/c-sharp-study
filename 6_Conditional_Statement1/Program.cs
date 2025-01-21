
//Console.WriteLine("Please enter first number");
//int first = int.Parse(Console.ReadLine());

//Console.WriteLine("Please enter second number");
//int second = int.Parse(Console.ReadLine());

//Console.WriteLine("Please enter third number");
//int third = int.Parse(Console.ReadLine());


#region nested if

//if (first > second)
//{
//    if (first > third)
//    {
//        Console.WriteLine($"{first} is greater than {second} and {third}");
//    }
//    else
//    {
//        Console.WriteLine($"{third} is greater than {first} and {second}");
//    }
//}
//else
//{
//    if (second > third)
//    {
//        Console.WriteLine($"{second} is greater than {first} and {third}");
//    }
//    else 
//    { 
//        Console.WriteLine($"{third} is greater than {first} and {second}");
//    }
//}

#endregion nested if

#region ternary operator

//int result = (first > second) ? ((first > third) ? first : third) :
//    ((second > third) ? second : third);

//Console.WriteLine($"{result} is greater number ");

#endregion ternary operator

#region if elseif


//Console.WriteLine("Please enter number");

//int input = int.Parse(Console.ReadLine());

//if (input == 10)
//{
//    Console.WriteLine($"{input} : TEN");
//}
//else if (input == 20) 
//{
//    Console.WriteLine($"{input} : TWENTY");
//}
//else if (input == 30)
//{
//    Console.WriteLine($"{input} : THIRTY");
//}
//else
//{
//    Console.WriteLine($"{input} : is not TEN, TWENTY OR THIRTY");
//}

#endregion if elseif


#region switch case

Console.WriteLine("Please enter number");
int input = int.Parse(Console.ReadLine());

switch (input)
{
    case 10:
        Console.WriteLine($"{input} : TEN");
        break;
    case 20:
        Console.WriteLine($"{input} : Twenty");
        break;
    case 30:
        Console.WriteLine($"{input} : thirty");
        break;
    default:
        Console.WriteLine($"{input} : not 10, 20 and 30");
        break;
}

#endregion switch case


Console.ReadKey();