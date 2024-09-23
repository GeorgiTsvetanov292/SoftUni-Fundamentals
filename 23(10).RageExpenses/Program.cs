int gamesLost = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());

double expenses = 0;
int keyboardBroken = 0;

for (int i = 1; i <= gamesLost; i++)
{
    if (i % 2 == 0)
    {
        expenses += headsetPrice;     
    }
    if (i % 3 == 0)
    {
        expenses += mousePrice;     
    }
    if (i % 2 == 0 && i % 3 == 0)
    {
        expenses += keyboardPrice;
        keyboardBroken++;
    }
    if (keyboardBroken == 2)
    {
        expenses += displayPrice;
        keyboardBroken = 0;
    }

}
Console.WriteLine($"Rage expenses: {expenses:f2} lv.");