string username = Console.ReadLine();
string user = username;

char[] stringArray = username.ToCharArray();
Array.Reverse(stringArray);
string password = new string(stringArray);

int fails = 0;

while (true)
{
    username = Console.ReadLine();


    if (username == password)
    {
        Console.WriteLine($"User {user} logged in.");
        break;
    }
    fails++;

    if (fails == 4)
    {
        Console.WriteLine($"User {user} blocked!");
        break;
    }
    if (username != password)
    {
        Console.WriteLine($"Incorrect password. Try again.");
    }
}