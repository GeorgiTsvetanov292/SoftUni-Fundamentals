int people = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day = Console.ReadLine();

double ticketPrice = 0;

if (type == "Students")
{
    switch (day)
    {
        case "Friday":
            ticketPrice = 8.45;
            break;
        case "Saturday":
            ticketPrice = 9.80;
            break;
        case "Sunday":
            ticketPrice = 10.46;
            break;
    }
}
if (type == "Business")
{
    switch (day)
    {
        case "Friday":
            ticketPrice = 10.90;
            break;
        case "Saturday":
            ticketPrice = 15.60;
            break;
        case "Sunday":
            ticketPrice = 16.00;
            break;
    }
}
if (type == "Regular")
{
    switch (day)
    {
        case "Friday":
            ticketPrice = 15.00;
            break;
        case "Saturday":
            ticketPrice = 20.00;
            break;
        case "Sunday":
            ticketPrice = 22.50;
            break;
    }
}

double totalPrice = ticketPrice * people;

if (type == "Students" && people >= 30) 
{
    totalPrice *= 0.85;
}
if (type == "Business" && people >= 100) 
{
    totalPrice = totalPrice - (ticketPrice * 10);
}
if (type == "Regular" && (people >= 10 && people <= 20)) 
{
    totalPrice *= 0.95;
}
Console.WriteLine( $"Total price: {totalPrice:f2}");
    


