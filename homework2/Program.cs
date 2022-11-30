/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/



/*int CutNumber (int num)
{
    int des = num % 100 / 10;
    int res = des;
    return res;
}

int random = new Random().Next(100,1000);
int newNumber = CutNumber(random);
Console.WriteLine($"New version of {random} is {newNumber}");*/



/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.Write(" введите  число :");
 int num = Convert.ToInt32(Console.ReadLine());
 int num1 = Math.Abs(num);
 if (num1 < 100 )
 {
     Console.WriteLine("третьего числа нет ! ");
 }
 if (num1 <= 999 && num1 >= 100)
 {
     Console.WriteLine(num1 % 10);
 }
 if (num1 > 999)
 {
     while(num1 > 999)
    {
         num1 = num1 / 10;
         if(num1 <= 999) 
         {
             Console.WriteLine(num1 % 10);
         }

     }
 }
Console.Write("введите число :");*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

/*bool main (int num)
{
    if(num == 6 | num == 7)
    {
        return true;
    }
    else 
    {
        return false;
    }
}
Console.WriteLine($"{main(4)}");*/