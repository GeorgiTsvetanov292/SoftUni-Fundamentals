int maxRows = int.Parse(Console.ReadLine());

for (int row = 1; row <= maxRows; row++)
{
    for (int col = 0; col < row; col++)
    {
        Console.Write($"{row} ");

    }
    Console.WriteLine();
}