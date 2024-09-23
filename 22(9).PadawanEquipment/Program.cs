using System.Xml.Linq;

double budget = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double saberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double percent = students * 10.0 / 100;
double allSabers = students + Math.Ceiling(percent);
double sabersPrice = saberPrice * allSabers;

double robesPrice = robePrice * students;

double beltsDiscount = students - Math.Ceiling((double)(students / 6));
double beltsPrice = beltPrice * beltsDiscount;


double total = sabersPrice + robesPrice + beltsPrice;

if (total <= budget)
{
    Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {total - budget:f2}lv more.");
}
