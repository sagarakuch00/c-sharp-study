Console.WriteLine("Welcome to kapbhar chaha");
string input = "";
int teaQuantity = 0;
int coffeeQuantity = 0; 
int milkQuantity = 0;   
do
{
    Console.WriteLine("what would like to have..?");
    Console.WriteLine($"1: Tea 10 Rs  2: Cofee 20 Rs  3: Milk 30 Rs");

    int order = int.Parse(Console.ReadLine());


    switch (order)
    {
        case 1:
            Console.WriteLine("How much ?");
            teaQuantity += int.Parse(Console.ReadLine());            
            Console.WriteLine($"You order {teaQuantity} Tea in Total");
            break;
        case 2:
            Console.WriteLine("How much ?");
            coffeeQuantity += int.Parse(Console.ReadLine());
            Console.WriteLine($"You order {coffeeQuantity} Cofee in Total");
            break;
        case 3:
            Console.WriteLine("How much ?");
            milkQuantity += int.Parse(Console.ReadLine());             
            Console.WriteLine($"You order {milkQuantity} Milk in Total");
            break;
        default:
            Console.WriteLine($"Invalid order");
            break;
    }
    Console.WriteLine("Do you want to place any other order");
    input = Console.ReadLine().ToUpper();  

}while (input == "YES" || input == "Y");



if (teaQuantity > 0 || coffeeQuantity > 0 || milkQuantity > 0)
{
    Console.WriteLine("**** Your Bill *****");
    int totalBill = 0;

    if (teaQuantity > 0)
    {
        Console.WriteLine($"TEA : {teaQuantity} * 10 = {teaQuantity * 10} RS ");
        totalBill += teaQuantity * 10;
    }
    if (coffeeQuantity > 0)
    {
        Console.WriteLine($"COFFEE : {coffeeQuantity} * 30 = {coffeeQuantity * 30} RS");
        totalBill += coffeeQuantity * 30;
    }
    if (milkQuantity > 0)
    {
        Console.WriteLine($"MILK : {milkQuantity} * 20 = {milkQuantity * 20} RS");
        totalBill += milkQuantity * 20;
    }
    Console.WriteLine($" Your total bill = {totalBill} RS");
    
}
Console.WriteLine("***** Thank you visit again *****");



Console.ReadKey();
