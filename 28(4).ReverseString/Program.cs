string word = Console.ReadLine();

char[] stringArray = word.ToCharArray();
Array.Reverse(stringArray);
string reverseWord = new string(stringArray);

Console.WriteLine(reverseWord);