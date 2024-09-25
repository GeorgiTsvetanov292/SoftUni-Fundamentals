double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());


var arr = new[] { n1, n2, n3 };
Array.Sort(arr);
Array.Reverse(arr);
Console.WriteLine("{0}", arr[0]);
Console.WriteLine("{0}", arr[1]);
Console.WriteLine("{0}", arr[2]);

