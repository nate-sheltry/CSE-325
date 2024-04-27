// See https://aka.ms/new-console-template for more information

string name = "Nathaniel";
string location = "Arizona";

Console.WriteLine($"My name is {name}.");
Console.WriteLine($"I'm from {location}");

DateTime currentDate = DateTime.Now;
DateTime christmas = DateTime.Parse($"12/25/{currentDate.Year}");
int days = (int)(christmas - currentDate).TotalDays;

Console.WriteLine($"Date: ",DateTime.Now.ToShortDateString());
Console.WriteLine($"Days until Christmas: {days}");

static void Main()
{
    double width, height, woodLength, glassArea;
    string widthString, heightString;

    Console.Write("Enter a Width value:");
    widthString = Console.ReadLine();
    width = double.Parse(widthString);

    Console.Write("Enter a Height value:");
    heightString = Console.ReadLine();
    height = double.Parse(heightString);

    woodLength = 2 * (width + height) * 3.25;
    glassArea = 2 * (width * height);

    Console.WriteLine("The length of the wood is " +
    woodLength + " feet");

    Console.WriteLine("The area of the glass is " +
    glassArea + " square metres");

    Console.ReadKey();
}

Main();
