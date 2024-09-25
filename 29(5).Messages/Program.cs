int numbers = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers; i++)
{
    string currentNumber = Console.ReadLine();
    int numberOfDigits = currentNumber.Length;


    int mainDigit = int.Parse(currentNumber) % 10;
    if (mainDigit == 0)
    {
        Console.Write(" ");
        continue;
    }
    int offSet = (mainDigit - 2) * 3;

    if (mainDigit == 8 || mainDigit == 9)
    {
        offSet++;
    }
    int letterIndex = (offSet + numberOfDigits - 1);
    char finalLetter = (char)((int)'a' + letterIndex);
    Console.Write(finalLetter);
}