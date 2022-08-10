// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

if (numA < numB)
{
    if (numB > numC)
    {
        max = numB;
    }
    else 
    {
        max = numC;
    }
}

else
{
    if (numA > numC) 
    {
        max = numA;
    }
    else
    {
        max = numC;
    }
}

Console.Write("Максимальное значение: ");
    Console.WriteLine(max);