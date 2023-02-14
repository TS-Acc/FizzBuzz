

for (int numbersOTT = 1; numbersOTT <= 30; numbersOTT++)
{
    if (numbersOTT % 3 == 0 && numbersOTT % 5 == 0)
    {
        Console.WriteLine($"{numbersOTT} is FIZZBUZZ");
        continue;
    }
    if (numbersOTT % 3 == 0)
    {
        Console.WriteLine($"{numbersOTT} is FIZZ");
        continue;
    }
    if (numbersOTT % 5 == 0)
    {
        Console.WriteLine($"{numbersOTT} is BUZZ");
        continue;
    }

    Console.WriteLine(numbersOTT);
}

/* for (int idx = 1; idx <= 30; idx++)
{
    bool isDivBy3 = (idx % 3 == 0) ? true : false;

    bool isDivBy5 = (idx % 5 == 0) ? true : false;

    bool isBoth = (isDivBy5 && isDivBy3) ? true : false;

    if (isBoth)
    {
        Console.WriteLine(" FIZZBUZZ ");
        continue;
    }
    if (isDivBy3)
    {
        Console.Write(" FIZZ ");
        continue;
    }
    if (isDivBy5)
    {
        Console.Write(" BUZZ ");
        continue;
    }

    Console.Write($" {idx} ");


} */






