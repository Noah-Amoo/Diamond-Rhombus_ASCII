//      DIAMOND/RHOMBUS USING ASCII
//  *******************************************
//  Two different methods are presented to show how to print a diamond or rhombus
//  on the Console using nested for loops and if statements.
Console.WriteLine("METHOD 1");
Console.Write("Enter an integer width of the diamond:\t");
var input = int.Parse(Console.ReadLine());
var half = Math.Abs(input / 2) + 1;

//          METHOD ONE
//  *****************************
//  Top Part of the Diamond
for (int i = 1; i <= half; i++)
{
    for (int j = 1; j <= half - i; ++j)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; ++k)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//  Bottom Half of the Diamond
for (int i = half - 1; i >= 1; --i)
{
    for (int j = 1; j <= half - i; ++j)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= 2 * i - 1; ++k)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine();

//      METHOD TWO
//  *********************
Console.WriteLine("METHOD 2");
Console.Write("Enter an integer size of the diamond:\t");
var size = int.Parse(Console.ReadLine());
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        int middleCount = Math.Abs(size / 2 - i);
        if ((j < size - middleCount) && (j >= middleCount))
            Console.Write('#');
        else
            Console.Write(' ');
    }
    Console.WriteLine();
}