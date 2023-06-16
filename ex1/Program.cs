Console.Clear();

Console.WriteLine ("Enter your number: ");
int N = int.Parse(Console.ReadLine()!);

if (N < 10000 || N > 99999)
{
    Console.WriteLine("Invalid number");
    return;
}

int a = N%10;
int b = N%100/10;
int c = N/10000;
int d = N/1000%10;

if (a == c) 
{
    if (b==d) Console.WriteLine ("Number is palindrome");
} 
else Console.WriteLine ("Number is not palindrome");


