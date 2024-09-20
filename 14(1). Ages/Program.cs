int age = int.Parse(Console.ReadLine());

if (age >= 0 & age <= 2)
{
    Console.WriteLine($"baby");
}
else if (age < 14)
{
    Console.WriteLine($"child");
}
else if (age < 20)
{
    Console.WriteLine($"teenager");
}
else if (age < 66)
{
    Console.WriteLine($"adult");
}
else
{
    Console.WriteLine($"elder");
}