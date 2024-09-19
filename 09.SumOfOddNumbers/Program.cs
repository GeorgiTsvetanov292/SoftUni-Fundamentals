int n = int.Parse(Console.ReadLine());

int sum = 0;
int k = 1;

for (int i = 1; i <= n; i++)
{

    sum += k ;
    Console.WriteLine(k);
    k += 2;

}
Console.WriteLine($"Sum: {sum}");