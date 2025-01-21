string name = "Onkar";

Console.WriteLine(name); // Onkar

Console.WriteLine(name.Length); // 5

Console.WriteLine(name.ToUpper()); // ONKAR

Console.WriteLine(name.ToLower()); // onkar

name = "             roshan";
Console.WriteLine(name); //              roshan

Console.WriteLine(name.TrimStart()); // roshan

name = "roshan                   ";
Console.WriteLine(name);

Console.WriteLine(name.TrimEnd());

name = "                  roshan                   ";
Console.WriteLine(name.Trim());

string name1 = "lokesh";
string name2 = "vijaya";

int i = string.Compare(name1, name2);
Console.WriteLine(i);

name2 = "lokesh";
i = string.Compare(name1, name2);
Console.WriteLine(i); // 0

string email = "vihaan@gmail.com";
Console.WriteLine(email);
Console.WriteLine(email.IndexOf('@'));
Console.WriteLine(email.IndexOf('a')); // 3
Console.WriteLine(email.LastIndexOf('a')); // 9

Console.WriteLine(email.Contains('@')); // True

Console.WriteLine(email.Contains("gmail")); // True

string newEmail = email.Replace("com", "co.in");
Console.WriteLine(newEmail); // vihaan@gmail.co.in

string username = email.Substring(0, 6);
Console.WriteLine(username);

username = email.Substring(0, email.IndexOf('@'));
Console.WriteLine(username);

string domain = email.Substring(email.IndexOf('@') + 1,
    email.Length - email.IndexOf('@') - 1);
Console.WriteLine(domain);

string fn = "onkar";
string ln = "shinde";

string fullname = fn + ln;
Console.WriteLine(fullname); // onkarshinde

fullname = fn + " " + ln;
Console.WriteLine(fullname); // onkar shinde

fullname = string.Concat(fn, " ", ln);
Console.WriteLine(fullname); // onkar shinde

fullname = string.Join(" ", fn, ln);
Console.WriteLine(fullname); // onkar shinde

string mn = "babasaheb";

fullname = string.Join(",", fn, mn, ln);
Console.WriteLine(fullname); // onkar babasaheb shinde

fullname = "Full Name : " + fn + " " + mn + " " + ln;
Console.WriteLine(fullname);

// placeholder syntax

fullname = string.Format("Full Name : {0} {1} {2}", fn, mn, ln);
Console.WriteLine(fullname);

// string interpolation
fullname = string.Format($"Full Name : {ln} {fn} {mn}");
Console.WriteLine(fullname);

Console.WriteLine($"{10 + 10}");

// escape sequence 
string name3 = "rakesh";
Console.WriteLine(name3); // rakesh
// "rakesh"

name3 = "\"rakesh\"";
Console.WriteLine(name3); // "rakesh"

name3 = "'rakesh'";
Console.WriteLine(name3);

name3 = "\\rakesh\\";
Console.WriteLine(name3); // \rakesh\

Console.WriteLine($"{fn}\n{ln}"); // onkarshinde

Console.WriteLine($"{fn}\b{ln}"); // onkashinde

Console.WriteLine($"{fn}\t{ln}"); // onkar  shinde

string filePath = "c:\\users\\user\\source\\repos";
Console.WriteLine(filePath);

filePath = @"c:\users\user\source\repos";
Console.WriteLine(filePath);

string name4 = "";
string name5 = null;

Console.WriteLine(string.IsNullOrEmpty(name4)); // true
Console.WriteLine(string.IsNullOrEmpty(name5)); // true

string name6 = " ";
Console.WriteLine(string.IsNullOrEmpty(name6)); // false

name6 = "     ";
Console.WriteLine(string.IsNullOrWhiteSpace(name6)); // true

string name7 = "sagar akuch";
Console.WriteLine(name7.Substring(0, 5));// sagar
Console.WriteLine(name7.Substring(0, 7));// sagar a
// Console.WriteLine(name7.Substring(0, 12));// error

Console.WriteLine($"{name7.Length - name7.IndexOf(' ') - 1}");

string name8 = "a";
bool isValid = string.IsNullOrWhiteSpace(name8);
Console.WriteLine(isValid); // false

name8 = "     ";
isValid = string.IsNullOrWhiteSpace(name8);
Console.WriteLine(isValid); // true

isValid = string.IsNullOrEmpty(name8);
Console.WriteLine(isValid); // false


name8 = null;
// string nameInUpper = name8.ToUpper(); // runtime error
// Console.WriteLine(nameInUpper);

string full = "vijayachikankar";
Console.WriteLine(full); // vijayachikankar

full = "vijaya\bchikankar\b ";
Console.WriteLine(full); // vijaychikanka

full = "vijaya\bchikan\bkar";
Console.WriteLine(full); // vijaychikakar

full = "vijaya \bchikankar";
Console.WriteLine(full); // vijayachikankar

string newEmailId = "seema@rediffmail.com";

int i1 = newEmailId.IndexOf('@'); // 5
string usernamenew = newEmailId.Substring(0, 5); // seema
Console.WriteLine(usernamenew);

// string domainnew = newEmailId.Substring(i1 + 1, 9); // gmail.com

Console.WriteLine($"domain number of characters : {newEmailId.Length - i1}");

string domainnew = newEmailId.Substring(i1 + 1, newEmailId.Length - i1 - 1); // gmail.com
Console.WriteLine(domainnew);

string studentname = null;
Console.WriteLine(string.IsNullOrEmpty(studentname)); // true
Console.WriteLine(string.IsNullOrWhiteSpace(studentname)); // true

// studentname = "";
studentname = string.Empty;
Console.WriteLine(string.IsNullOrEmpty(studentname)); // true
Console.WriteLine(string.IsNullOrWhiteSpace(studentname)); // true

studentname = "  ";
Console.WriteLine(string.IsNullOrEmpty(studentname)); // false
Console.WriteLine(string.IsNullOrWhiteSpace(studentname)); // true

Console.ReadKey(); // wait