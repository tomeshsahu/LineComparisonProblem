// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Line Comparison Computation Program");
int x1 = 4, y1 = 5, x2 = 6, y2 = 7;
double length = 0;
length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("length of the line = " + length);
int a = 0;
int b = 0; 
Console.WriteLine( a == b );
// compare both the values
// using CompareTo() method
int status = a.CompareTo(b);

// checking the status
if (status > 0)
    Console.WriteLine("{0} is greater than {1}",
                                a, b);
else if (status < 0)
    Console.WriteLine("{0} is less than {1}",
                                a, b);
else
    Console.WriteLine("{0} is equal to {1}",
                                a, b);