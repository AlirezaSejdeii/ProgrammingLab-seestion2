Console.WriteLine("Sort string in ascending order");
int i = 0;
List<char> list = new();
while (i < 10)
{
    Console.WriteLine("Enter charecter");
    char number = Convert.ToChar(Console.ReadLine());
    list.Add(number);
    i++;
}
var newList = list.OrderBy(a => a);
Console.WriteLine("----------------------");
foreach (var item in newList)
{
    Console.WriteLine(item);
}

