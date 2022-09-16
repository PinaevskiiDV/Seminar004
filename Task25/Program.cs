Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
int i;
for(i = 0; i < b; i += 1)
{
    result = result * a;
}
Console.WriteLine($"Число {a} в степени {b} равно {result}");