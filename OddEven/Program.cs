using System;
 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");

        int limit = int.Parse(Console.ReadLine());

        int evenCount = limit / 2;
        int oddCount = (limit + 1) / 2;

        int[] evenNumbers = new int[evenCount];
        int[] oddNumbers = new int[oddCount];

        int evenIndex = 0, oddIndex = 0;


        for (int i = 1; i <= limit; i++)
        {
            if (i % 2 == 0)
            
                evenNumbers[evenIndex++] = i;

            else
            
                oddNumbers[oddIndex++] = i;                             
        }
            Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
            Console.WriteLine("Odd numbers: " + string.Join(", ", oddNumbers));
    }
}








