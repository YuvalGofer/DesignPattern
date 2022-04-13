// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void RandNumber(int rng)
{
    Random random = new Random();
    int _rng = random.Next(1, 10);
    bool isFix = false;
    //string _rng = new Random(1, 10);
    if (_rng > 5)
    {
        isFix = true;
        Console.WriteLine($"Is fix: {isFix}");
    }
    else
    {
        Console.WriteLine($"Is fix: {isFix}");
    }

}
