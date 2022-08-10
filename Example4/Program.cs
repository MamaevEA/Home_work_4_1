// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

int numB = 2;

if (numA < 2)
{
    Console.Write ("Нет четных чисел");
}

while (numB <= numA)
{
    if (numB <= numA)
    {
       Console.Write(numB);
       Console.Write(", ");
       numB = numB + 2;
    }
    else
    {
        numB = numB + 2;
    }
}