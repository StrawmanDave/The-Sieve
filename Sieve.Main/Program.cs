using TheSieve;

string Question = @"
The class Sieve would just be abstract and the three other methods would just be new classes that override the isGood method. 
I am more familiar with inheritance and just got used to liking it. The Delegates are way cool though and save a lot of typing and thinking.
";
Console.WriteLine("Welcome to the Sieve enter a number and you will know if it is good or bad");
Console.WriteLine("Would you like to see (even numbers), (positive numbers) or (multiples of ten)?");
string? getProgram = Console.ReadLine();

Sieve sieve = getProgram switch
{
    "even numbers" => new Sieve(IsEven),
    "positive numbers" => new Sieve(IsPositive),
    "multiples of ten" => new (IsMultipleOfTen)
};

while (true)
{
    
    try
    {
        Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());
        string goodOrEvil = sieve.IsGood(number) ? "good" : "evil";
        Console.WriteLine($"That number is {goodOrEvil}");
    }catch(FormatException e)
    {
        Console.WriteLine(e.Message);
    }
}
// for the question at the end of the challenge if you want to read it you can just read the string or comment out the while loop then run the program.
Console.WriteLine(Question);

bool IsEven(int numbers)
{
    if(numbers % 2 == 0)
    {
        return true;
    }else
    {
        return false;
    }
}

bool IsPositive(int numbers)
{
    if( numbers > 0)
    {
        return true;
    }else
    {
        return false;
    }
}

bool IsMultipleOfTen(int numbers)
{
    if( numbers / 10 >= 1)
    {
        return true;
    }else
    {
        return false;
    }
}