// operators

bool b1 = true;
Console.WriteLine(b1); // true

b1 = !b1;
Console.WriteLine(b1); // false

int a = 10, b = 2;

int add = a + b;
Console.WriteLine($"{a} + {b} = {add}");

Console.WriteLine($"{a} - {b} = {a - b}");

Console.WriteLine($"{a} * {b} = {a * b}");

Console.WriteLine($"{a} / {b} = {a / b}"); // 5

Console.WriteLine($"{a} % {b} = {a % b}"); // 0

Console.WriteLine($"{9 % 2}"); // 1

bool b2 = a == b;
Console.WriteLine($"{a} == {b} = {b2}"); // false

b2 = a != b;
Console.WriteLine($"{a} != {b} = {b2}"); // true

b = 10;
b2 = a == b;
Console.WriteLine($"{a} == {b} = {b2}"); // true

b2 = a < b;
Console.WriteLine($"{a} < {b} = {b2}"); // false

b2 = a <= b;
Console.WriteLine($"{a} <= {b} = {b2}"); // true

// a = a + 10;
a += 10;
Console.WriteLine($"a : {a}"); // 20

a /= 2; // a = a / 2
Console.WriteLine($"a : {a}"); // 10

a++; // a = a + 1
Console.WriteLine($"a : {a}"); // 11

a--;
Console.WriteLine($"a : {a}"); // 10

// Console.WriteLine($"a++ : {a++}"); // 10
Console.WriteLine($"++a : {++a}"); // 11
Console.WriteLine($"a : {a}"); // 11

Console.WriteLine($"--a : {--a}"); // 10

int c = 20;
Console.WriteLine($"a : {a} b : {b} c : {c}");

b1 = a == b && a < c;
Console.WriteLine($"{a} == {b} && {a} < {c} : {b1}");

b1 = a == b && a > c;
Console.WriteLine($"{a} == {b} && {a} > {c} : {b1}");

b1 = a > b & a > c;
Console.WriteLine($"{a} > {b} & {a} > {c} : {b1}");

b1 = a > b && a > c;
Console.WriteLine($"{a} > {b} && {a} > {c} : {b1}");

b1 = a >= b | a > c;
Console.WriteLine($"{a} >= {b} | {a} > {c} : {b1}"); // true

b1 = a >= b || a > c;
Console.WriteLine($"{a} >= {b} || {a} > {c} : {b1}"); // true

int x = 1;
// increment its value by 1 or add 1 to this number 
// do not use +, ++, += operators

int y = x << 1;
Console.WriteLine($"x : {x} y : {y}");

Console.ReadKey(); // for screen wait