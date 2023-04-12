﻿using AulaGenerics1;

PrintService<string> printService = new PrintService<string>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string x = Console.ReadLine();
    printService.AddValue(x);
}

int a = int.Parse(printService.First());
int b = a + 2;
Console.WriteLine(b);

printService.Print();
Console.WriteLine("First: " + printService.First());
