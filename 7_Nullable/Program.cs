


//bool isvalue = null;
//Console.WriteLine(isvalue);   // bool value can't be stored null value.

bool? isvalue = null;    // simply we have to use "?" symbol we can store null value.
Console.WriteLine(isvalue);   // in this case we can store null value using nullablee concept.


//int age = null;
//Console.WriteLine(age); // also can't stored null value 

//int? age = null;
//Console.WriteLine(age);

//string email = null;

//bool? status = null;

//DateTime? dob = null;

//int i = 10;
//Console.WriteLine(i);

//int? j = 10;
//Console.WriteLine(j);

// we can make values nullable explicitely.


int? i = 10;
int j = i ?? 0;

string name = "Sagar";

string nameInUpper = name.ToUpper();
Console.WriteLine($"{name} : {nameInUpper}");


name = null;

nameInUpper = name?.ToUpper(); // "?" prevents null reference exception
Console.WriteLine($"{name} : {nameInUpper}");

