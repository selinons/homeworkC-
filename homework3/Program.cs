/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


/*Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}*/


/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*double GetLens(int x1,int y1,int z1,int x2,int y2,int z2)
{
    double len = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1-z2) * (z1-z2));
    return len;
}
Console.WriteLine(GetLens(3, 6, 8, 2, 1, -7));
Console.WriteLine(Math.Round(2));*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

/*void Kyb(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i} - {i * i * i}");
    }
}
Console.WriteLine ("ВВедите чилсо N = ");
int N = Convert.ToInt32(Console.ReadLine());
Kyb(N);*/