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
