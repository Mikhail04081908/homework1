// Нахождение чётности числа

int num = new Random().Next(1, 100);
int del = num % 2;

if (del == 0)
{
    Console.WriteLine($"Число: {num} - Чётное");
}
else 
{
    Console.WriteLine($"Число: {num} - Не чётное");
}