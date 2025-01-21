

//Console.WriteLine("Please enter the marks");
//int marks = int.Parse(Console.ReadLine());

//if (marks > 90)
//{
//    Console.WriteLine($"{marks} : Excellent");
//}
//else if (marks > 75)
//{
//    Console.WriteLine($"{marks} : Good");
//}
//else if (marks > 60)
//{
//    Console.WriteLine($"{marks} : Average");
//}
//else if (marks > 50)
//{
//    Console.WriteLine($"{marks} :  Poor");
//}
//else if(marks < 35)
//{ 
//    Console.WriteLine($"{marks} : Fail");
//}


//Console.WriteLine("Enter a number");

//int input = int.Parse(Console.ReadLine());

//for (int i = 10; i > 0; i--)
//{
//    Console.WriteLine(i);
//}


//Console.WriteLine("Enter the number");
//int input1 = int.Parse(Console.ReadLine());

//for (int i = 1; i < input1; i++)
//{
//    Console.WriteLine(i);
//}



using System;



    
    
        Console.Write("Enter the upper limit to find prime numbers: ");
        int limit = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime numbers up to {limit}:");
        for (int i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
        Console.WriteLine();
    

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }









Console.ReadLine();