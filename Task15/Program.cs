// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 6 || a == 7)

{
    Console.WriteLine("Weekend");
}

else if (a >= 1 && a < 6)
{
    Console.WriteLine("Weekday");
}
else
{
    Console.WriteLine("Вы ввели число не от 1 до 7");
}