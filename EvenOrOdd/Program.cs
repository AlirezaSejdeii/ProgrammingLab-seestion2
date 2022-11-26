Console.WriteLine("Detect number is even or odd");
List<int> list = new List<int>();
int i = 0;
while (i < 20)
{
    Console.WriteLine("Enter number");
    int number = Convert.ToInt32(Console.ReadLine());
    list.Add(number);
    i++;
}
Console.WriteLine("Poccessing ...");
foreach (var item in list)
{
    if (item % 2 == 0)
    {
        Console.WriteLine(item + " is even");
    }
    else
    {
        Console.WriteLine(item + " is odd");
    }
}