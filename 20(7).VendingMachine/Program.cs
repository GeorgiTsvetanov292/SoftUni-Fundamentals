string command = "";
double money = 0;

while ((command = Console.ReadLine()) != "Start")
{
    double coins = double.Parse(command);

    if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
    {
        money += coins;
    }
    else
    {
        Console.WriteLine($"Cannot accept {coins}");
    }
}

while ((command = Console.ReadLine()) != "End")
{
    switch (command)
    {
        case "Nuts":
            if (money >= 2)
            {
                money -= 2;
                Console.WriteLine($"Purchased nuts");
            }
            else { Console.WriteLine("Sorry, not enough money"); }
            break;
        case "Water":
            if (money >= 0.7)
            {
                money -= 0.7;
                Console.WriteLine($"Purchased water");
            }
            else { Console.WriteLine("Sorry, not enough money"); }
            break;
        case "Crisps":
            if (money >= 1.5)
            {
                money -= 1.5;
                Console.WriteLine($"Purchased crisps");
            }
            else { Console.WriteLine("Sorry, not enough money"); }
            break;
        case "Soda":
            if (money >= 0.8)
            {
                money -= 0.8;
                Console.WriteLine($"Purchased soda");
            }
            else { Console.WriteLine("Sorry, not enough money"); }
            break;
        case "Coke":
            if (money >= 1)
            {
                money -= 1;
                Console.WriteLine($"Purchased coke");
            }
            else { Console.WriteLine("Sorry, not enough money"); }
            break;
        default:
            Console.WriteLine("Invalid product");
            break;
    }

}
Console.WriteLine($"Change: {money:f2}");