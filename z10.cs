// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Ведите любое трехзначное число, я выведу вам вторую цифру заданного числа: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0)
{
    if (num>99 && num<1000)
    {
        System.Console.WriteLine((num/10)%10);
    }
    else
    {
        System.Console.WriteLine("Вы ввели не трехзначное число!");
    }
}
if (num<0)
{
    if (num<-99 && num>-1000)
    {
        System.Console.WriteLine(-(num/10)%10);
    }
    else
    {
        System.Console.WriteLine("Вы ввели не трехзначное число!");
    }
}
