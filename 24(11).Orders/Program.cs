int orders = int.Parse(Console.ReadLine());

double total = 0;

for (int i = 0; i < orders; i++) 
{
    double capsulePrice = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCount = int.Parse(Console.ReadLine());

    double currentOrder = (days * capsulesCount) * capsulePrice;
    total += currentOrder;

    Console.WriteLine($"The price for the coffee is: ${currentOrder:f2}");
}
Console.WriteLine($"Total: ${total:f2}");