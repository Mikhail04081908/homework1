// Нахождение чисел которые делятся на 2 до (N)

int num = new Random().Next(1, 10);
int max = 1;
Console.WriteLine($"{num} - число которое было вязто");
while(max <= num)
{
    if(max % 2 == 0 )
    {
        Console.Write($"{max},");
    }
    max = max + 1;
}
Console.Write($"числа делящиеся на 2 до числа {num}.");
