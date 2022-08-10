// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Ведите любую цифру от 1 до 7 (день недели где 1-пн и далее по порядку), я выведу вам является ли это день выходным: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0 && num<6)
{
    System.Console.WriteLine("Нет, это не выходной!");
}
else if (num>5 && num<8)
{
    System.Console.WriteLine("Да, это выходной!");
}
else
{
    System.Console.WriteLine("Вы ввели неподходящее число!");
}
