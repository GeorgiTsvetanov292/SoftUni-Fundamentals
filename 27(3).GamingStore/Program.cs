double budget = double.Parse(Console.ReadLine());

string command;
double totalSpend = 0;

while ((command = Console.ReadLine()) != "Game Time")
{
    switch (command)
    {
        case "OutFall 4":
            if (budget >= 39.99)
            {
                budget -= 39.99;
                totalSpend += 39.99;
                Console.WriteLine($"Bought OutFall 4");
            }
            else Console.WriteLine("Too Expensive");
            break;
        case "CS: OG":
            if (budget >= 15.99)
            {
                budget -= 15.99;
                totalSpend += 15.99;
                Console.WriteLine("Bought CS: OG");
            }
            else Console.WriteLine("Too Expensive");
            break;
        case "Zplinter Zell":
            if (budget >= 19.99)
            {
                budget -= 19.99;
                totalSpend += 19.99;
                Console.WriteLine("Bought Zplinter Zell");
            }
            else Console.WriteLine("Too Expensive");
            break;
        case "Honored 2":
            if (budget >= 59.99)
            {
                budget -= 59.99;
                totalSpend += 59.99;
                Console.WriteLine("Bought Honored 2");

            }
            else Console.WriteLine("Too Expensive");
            break;
        case "RoverWatch":
            if (budget >= 29.99)
            {
                budget -= 29.99;
                totalSpend += 29.99;
                Console.WriteLine("Bought RoverWatch");
            }
            else Console.WriteLine("Too Expensive");
            break;
        case "RoverWatch Origins Edition":
            if (budget >= 39.99)
            {
                budget -= 39.99;
                totalSpend += 39.99;
                Console.WriteLine("Bought RoverWatch Origins Edition");
            }
            else Console.WriteLine("Too Expensive");
            break;
        default:
            Console.WriteLine("Not Found");
            break;

    }
    if (budget == 0)
    {
        Console.WriteLine($"Out of money!");
        return;
    }

}
Console.WriteLine($"Total spent: ${totalSpend:f2}. Remaining: ${budget:f2} ");