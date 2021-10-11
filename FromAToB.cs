using System;  

namespace FromA2B  

{  

class Program  

{  

static void Main(string[] args)  

{  

int operations = 0;  

string line = Console.ReadLine();  

string[] aandb = line.Split();  

int a = int.Parse(aandb[0]);  

int b = int.Parse(aandb[1]);  

while (a > b)  

{  

if (a % 2 == 0)  

{  

a = a / 2;  

operations++;  

}  

else  

{  

a++;  

operations++;  

}  

}  

if (a < b)  

{  

operations += b - a;  

}  

Console.WriteLine(operations);  

}  

}  

} 
