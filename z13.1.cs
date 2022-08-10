// Новое решение! Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Ведите любое число, я выведу вам третью цифру заданного числа: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0)
{
    if (num>99)
    {
        while (num>1000)
            {
                num=num/10;
            }
        Console.WriteLine(num%10);
    }
    else
    {
        System.Console.WriteLine("Третьей цифры в заданном числе нет. Что бы цифра была - введите минимум трехзначное число!");
    }
}
if (num<0)
{
    if (num<-99)
    {
        while (num<-1000)
            {
                num=num/10;
            }
        Console.WriteLine(-num%10);
    }
    else
    {
        System.Console.WriteLine("Третьей цифры в заданном числе нет. Что бы цифра была - введите минимум трехзначное число!");
    }
}
