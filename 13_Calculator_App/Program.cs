
Console.WriteLine("Welcome to Calculator App..!");

string isContinue = "";
do
{
    Console.WriteLine("Enter first number");
    int firstNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter second number");
    int secondNumber = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter operation");
    Console.WriteLine("Choose any one of the list : +, -, *, /, %");
    char op = char.Parse(Console.ReadLine());

    Operation(firstNumber, secondNumber, op);

    Console.WriteLine("Do you want to continue...?");
    isContinue = Console.ReadLine().ToUpper();
}
while (isContinue == "YES" || isContinue == "Y");

Console.WriteLine("***** Thank you for using App *****");



void Operation(int a, int b, char op) 
{
    switch (op)
    {
        case '+' :
            Console.WriteLine($"Addittion : {a} + {b} = {a + b}");
            break;
        case '-' :
            Console.WriteLine($"Substraction : {a} - {b} = {a - b}");
            break;
        case '*':
            Console.WriteLine($"Multiplication : {a} * {b} = {a * b}");
            break;
        case '/':
            Console.WriteLine($"Division : {a} / {b} = {a / b}");
            break;
        case '%':
            Console.WriteLine($"Remainder : {a} % {b} = {a % b}");
            break;
        default:
            Console.WriteLine("INVALID OPERATION");
            break;
    }
}

Console.ReadKey();  