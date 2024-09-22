int number = int.Parse(Console.ReadLine());

int copy = number;
int factorialSum = 0;

while (copy > 0)
{
    int digit = copy % 10;
    copy /= 10;


    int sum = 1;
    for (int i = 1; i <= digit; i++)
    {
        sum *= i;
    }
    factorialSum += sum;

}
bool isStrong = factorialSum == number;
Console.WriteLine(isStrong ? "yes" : "no");


