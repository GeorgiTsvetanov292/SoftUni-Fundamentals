﻿string dayType = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int price = 0;
if (age < 0 || age > 122)
{
    Console.WriteLine($"Error!");
    return;
}

if (dayType == "Weekday")
{
    if (age >= 0 & age <= 18)
    {
        price = 12;
    }
    else if (age <= 64)
    {
        price = 18;
    }
    else
    {
        price = 12;
    }
}
if (dayType == "Weekend")
{
    if (age >= 0 & age <= 18)
    {
        price = 15;
    }
    else if (age <= 64)
    {
        price = 20;
    }
    else
    {
        price = 15;
    }
}
if (dayType == "Holiday")
{
    if (age >= 0 & age <= 18)
    {
        price = 5;
    }
    else if (age <= 64)
    {
        price = 12;
    }
    else
    {
        price = 10;
    }
}
Console.WriteLine($"{price}$" );