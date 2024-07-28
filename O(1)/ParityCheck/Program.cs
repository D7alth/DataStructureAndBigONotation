Console.WriteLine("Enter with a value: ");
var input = Int32.Parse(Console.ReadLine());
if (input < 0)
{
    Console.WriteLine("The valor not be a less to 0");
    return;
}
var isEven = IsEven(input);
Console.WriteLine(isEven ? "The number is Even" : "The number is odd");

static bool IsEven(int n) => n % 2 == 0;
