//Практическая работа 1_Math Условный оператор
using static System.Console;
using static System.Math;


//Задание 1

WriteLine("Задание 1\nВведите число a:");
string s = ReadLine();
int a = Convert.ToInt32(s);
double z1, z2;
z1 = Cos(a * PI / 180) + Cos(2 * a * PI / 180) + Cos(6 * a * PI / 180) + Cos(7 * a * PI / 180);
z2 = 4 * Cos(a * 0.5 * PI / 180) * Cos(2.5 * a * PI / 180) * Cos(4 * a * PI / 180);
WriteLine($"z1 = {z1 - z1 % 0.001}\nz2 = {z2 - z2 % 0.001}");


//Задание 2
WriteLine("Задание 2");
WriteLine("Введите число a:");
string S;
int A;
S = ReadLine();
A = Convert.ToInt32(S);
WriteLine("Введите число b:");
int b;
S = ReadLine();
b = Convert.ToInt32(S);
WriteLine("Введите число x:");
int x;
S = ReadLine();
x = Convert.ToInt32(S);
double y;
if (3 * A - b > 0) y = 2 * Log(x) - Exp((A * x - b) * 0.1);
else y = Asin(x * 0.1) * 180 / PI;
if (double.IsNaN(y)) WriteLine("Число x должно лежать на [-10;10]");
else WriteLine(y);


//Задание 3
WriteLine("Задание 3");
WriteLine("Введите номинал банкноты РФ:");
string nominal = Console.ReadLine();
int nom = Convert.ToInt32(nominal);
switch (nom)
    {
       case 5: WriteLine("Великий Новгород");break;
       case 10: WriteLine("Красноярск");break;
       case 50: WriteLine("Санкт-Питербург");break;
       case 100: WriteLine("Москва");break;
       case 200: WriteLine("Севастополь");break;
       case 500: WriteLine("Архангельск");break;
       case 1000: WriteLine("Ярославль");break;
       case 2000: WriteLine("Мост на остров Русский и космодром «Восточный»");break;
       case 5000: WriteLine("Хабаровск");break;
       default : WriteLine("Купюры с таким номиналом не существует"); break;
    }