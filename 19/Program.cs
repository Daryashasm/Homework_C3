Console.Write("Введите пятизначное число; А = ");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA > 9999 && numberA < 100000)
{
    string numberB = numberA.ToString();
    if (numberB[0] == numberB[4] && numberB[1] == numberB[3])
    {
    Console.WriteLine($"{numberA} - это число является палиндром");
    }
    else
    {
     Console.WriteLine($"{numberA} - это число не является палиндром");
    }
}
else
{
     Console.WriteLine($"{numberA} - это не пятизначное число");
}
