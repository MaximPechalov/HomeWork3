﻿Console.Clear();

Console.WriteLine("Enter your number: ");
int N = int.Parse(Console.ReadLine());

int i = 1;

while (i <= N)
{
    Console.Write(i*i*i);
    Console.Write(" ");
    i++;
}