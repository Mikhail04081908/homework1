
// Нахождение максимального числа из 2-х
int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);
int max = num1;
if(num2 > max)max = num2;
Console.Write($"Максимальное число из {num1} и {num2} - {max}");