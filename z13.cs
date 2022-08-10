// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Ведите любое число, я выведу вам третью цифру заданного числа: ");
int num = Convert.ToInt32(Console.ReadLine());
int x = 1;
if (num>0)
{
    if (num>99)
    {
        while (num/x!=0)
            {
                x=x*10;
            }
        Console.WriteLine((num/(x/1000))%10);
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
        while (num/x!=0)
            {
                x=x*10;
            }
        Console.WriteLine(((num/(x/1000))%10)*-1);
    }
    else
    {
        System.Console.WriteLine("Третьей цифры в заданном числе нет. Что бы цифра была - введите минимум трехзначное число!");
    }
}
