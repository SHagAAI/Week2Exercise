// dotnet new sln --format sln -n Week2Exercise
// dotnet new console -n Foobarjazz 
// dotnet sln Week2Exercise.sln add Foobarjazz/Foobarjazz.csproj

int maxNum = 50;

var numbers = Enumerable.Range(1, maxNum);

foreach (int num in numbers)
{

    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.Write(" foobar ");
        continue;
    }

    if (num % 3 == 0)
    {
        Console.Write(" foo, ");
        continue;
    }

    if (num % 5 == 0)
    {
        Console.Write(" bar, ");
        continue;
    }

    Console.Write(num + ", ");
}