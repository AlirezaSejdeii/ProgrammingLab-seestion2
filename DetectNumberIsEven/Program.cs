Console.WriteLine("Detect number is Even or not.");

int number = int.Parse(Console.ReadLine());

string message = (number % 2 == 1) ? "This number is first" : "Number is last";

Console.WriteLine(message);

