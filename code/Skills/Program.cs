// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, its Leonid!");

void CalculateAverage(double a, double b, double c)
{
    double average = (a + b + c) / 3;
    Console.WriteLine($"Среднее арифметическое: {average}");
}

CalculateAverage(10, 20, 30);