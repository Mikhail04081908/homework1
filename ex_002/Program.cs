// Нахождение максимального числа из 3-х

int num1 = new Random().Next(1, 100);
int num2 = new Random().Next(1, 100);
int num3 = new Random().Next(1, 100);
int max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;
Console.Write($"Максимальное число из {num1}, {num2} и {num3} - {max}");
