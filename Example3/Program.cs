// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if ((numA % 2) == 0)
{
    Console.WriteLine("Числе является четным");
}

else 
{
    Console.Write("Число нечетное");
}