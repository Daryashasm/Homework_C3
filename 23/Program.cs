Console.Write("Введите число; N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов от 1 до {N}");
for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"Куб числа {i} = {i*i*i}");
}
