#region pass by value

//string name = "Sagar";
//Console.WriteLine($"Before method call: {name}");
//printA(name);
//Console.WriteLine($"After method call : {name}");

//Console.ReadKey(); 

//void printA(string name)
//{
//    name = "Avinash";
//    Console.WriteLine(name);
//    Console.WriteLine("printA(): method Called");
//}

#endregion pass by value


#region pass by reference value / ref keyword

//string name = "Sagar";
// string name;   value initiallization is mandatory
//Console.WriteLine($"Before method call: {name}");
//printA(ref name);
//Console.WriteLine($"After method call : {name}");

//Console.ReadKey();

//void printA(ref string name)
//{
//    name = "Avinash";  value initialization is not mandatory
//    Console.WriteLine("printA(): method Called");
//}

#endregion pass by reference value / ref keyword


#region out parameter / out keyword

////string name = "Sagar";
//string name;  // value initialization is not mandatory
////Console.WriteLine($"Before method call: {name}");
//printA(out name);
//Console.WriteLine($"After method call : {name}");

//Console.ReadKey();

//void printA(out string name)
//{
//    name = "Avinash"; // value initialization is mandatory
//    Console.WriteLine("printA(): method Called");
//}

#endregion out parameter / out keyword


#region out parameter example


//int a = 10; int b = 2;  
//operation(a, b, out int add, out int sub, out int mul, out int div);

//Console.WriteLine($"Addition : {a} + {b} = {add}");
//Console.WriteLine($"Substraction : {a} - {b} = {sub}");
//Console.WriteLine($"Multiplication : {a} * {b} = {mul}");
//Console.WriteLine($"Division : {a} / {b} = {div}");

//void operation(int a, int b, out int add, out int sub, out int mul, out int div)
//{
//    add = a + b;
//    sub = a - b;
//    mul = a * b;
//    div = a / b;
//}

//Console.ReadKey();


#endregion out parameter example


#region params parameter / params keyword

//// 1st call
//int[] numbers1 = new int[] {10, 20, 30};
//AddNumbers(numbers1);

//// 2nd call
//AddNumbers(new int[] {10, 10, 10});

//// 3rd call
//int[] numbers2 = null;
//AddNumbers(numbers2);

//// 4th call
//AddNumbers(null);

//// using params keyword
//AddNumbers(1, 2, 3, 4, 5, 6); // comma seperated values

//// using keyword
//AddNumbers(); // optional parameter


//void AddNumbers(params int[] numbers)
//{
//    if (numbers != null && numbers.Length > 0)
//    {
//        int sum = 0;
//        foreach (int num in numbers)
//        {
//            sum += num;            
//        }
//        Console.WriteLine($"Addition of all numbers: {sum}");
//    }
//    else
//    {
//        Console.WriteLine("No numbers to Add in Input Array");
//    }
//}
//Console.ReadKey(); 


#endregion params parameter / params keyword


#region using default values

//Add(10, 10);
//Add(10);
//Add();


//void Add(int a = 10, int b = 5) // default parameter value should be in last
//{
//    Console.WriteLine($"{a} + {b} = {a + b}");
//}

//Console.ReadKey();
#endregion using default values


#region using optional attribute

using System.Runtime.InteropServices;

Add(10, 10);
Add(b: 10); // optional paramater should be named using specify "b: 10"
Add(b: 20);


void Add([Optional]int a, int b) // 
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

Console.ReadKey();

#endregion using optional attribute
