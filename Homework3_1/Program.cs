//задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Напиши пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 10000 || a > 99999)
{
    Console.WriteLine("Ошибка, необходимо ввести пятизначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
}

int x5 = ((a / 10000) % 10);
int x4 = ((a / 1000) % 10);
int x3 = ((a / 100) % 10);
int x2 = ((a / 10) % 10);
int x1 = ((a / 1) % 10);
int b = Convert.ToInt32((x5)+(x4*10)+(x3*100)+(x2*1000)+(x1*10000));
Console.WriteLine(b);

if (a == b)
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не полиндром");
