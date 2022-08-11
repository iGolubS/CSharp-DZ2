// 1. Генерируется случайное целое число n в интервале [ 20 – 99 ].
// Проверяется, делится ли оно на введенное с клавиатуры целое число d (используйте тернарный оператор).

// Console.Clear();
// Random rnd = new Random();
// int rand = rnd.Next(20, 99);
// Console.WriteLine("Случайное число: " + rand);
// Console.Write("Ведите любое целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int x=((rand*10)/num)%10;
// //Console.WriteLine(x);
// string mes = (x == 0) ? "делится" : "не делится";
// Console.WriteLine("{0} {1} на {2}", rand, mes, num);



// 2. Генерируются два случайных целых числа a и b в интервале [10 – 30].
// Если a > b, выводится их разность, eсли a < b, выводится сумма, 
// eсли a == b, выводится сообщение “числа равны”. (оператор if)

// Console.Clear();
// Random rnd = new Random();
// int a = rnd.Next(10, 30);
// int b = rnd.Next(10, 30);
// int raz = a-b;
// int sum = a+b;
// if (a>b)
//     Console.WriteLine("Разность a и b равна: " + raz);
// else if (a<b)
//     Console.WriteLine("Сумма a и b равна: " + sum);
// else
//     Console.WriteLine("Числа равны");


// 3. Генерируются два случайных целых числа c и d в интервале [-10 – 10].
// Если оба числа четные, выводится их частное, если оба нечетные - их сумма,
// если одно число четное, а другое нечетное, выводится их произведение ( if ).

Console.Clear();
Random rnd = new Random();
int c = rnd.Next(-10, 10);
int d = rnd.Next(-10, 10);
Console.WriteLine(c + " " + d);
int chas = c/d;
int summ = c+d;
int proiz = c*d;
if (c%2==0 && d%2==0)
    Console.WriteLine("Частное чисел: " + chas);
else if (c%2!=0 && d%2!=0)
    Console.WriteLine("Сумма чисел: " + summ);
else
    Console.WriteLine("Произведение чисел: " + proiz);






Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.Write("Введите координаты точки X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Y: ");
int y = int.Parse(Console.ReadLine()!);
string mes = "";

switch (x, y)
{
    case (>0, >0): mes = "1"; break;
    case (>0, <0): mes = "4"; break;
    case (<0, >0): mes = "2"; break;
    case (<0, <0): mes = "3"; break;
    default : mes = "введите отличное от 0"; break;
}
Console.WriteLine(mes);





void printQuarter(int a, int b)
{
    if (a > 0 && b > 0)
    {
        Console.WriteLine("1");
    }
    else if (a < 0 && b > 0)
    {
        Console.WriteLine("2");
    }
    else if (a < 0 && b < 0)
    {
        Console.WriteLine("3");
    }
    else if (a > 0 && b < 0)
    {
        Console.WriteLine("4");
    }
    else
    {
        Console.WriteLine("ERROR");
    }
}

Console.WriteLine("Введите координату х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());
printQuarter(x, y);






// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter=int.Parse(Console.ReadLine());

switch (quarter)
{
    case 1:
    {
        Console.WriteLine("x>0 y>0");
        break;
    }
    case 2:
    {
        Console.WriteLine("x<0 y>0");
        break;
    }
    case 3:
    {
        Console.WriteLine("x<0 y<0");
        break;
    }
    case 4:
    {
        Console.WriteLine("x>0 y<0");
        break;
    }
    
    default:
    {
        Console.WriteLine("Введена неправильная четверть");
        break;
    }
}




//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

Console.Clear();
Console.Write("Введите X1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1=int.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2=int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));

Console.WriteLine($"d={d:f2}");




