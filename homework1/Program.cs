/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

/*Console.WriteLine("input number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number 2");
int num2 = Convert.ToInt32(Console.ReadLine());

 if (num1 > num2)
 
        {
 
            Console.WriteLine("{0} max ", num1);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} max ", num2);
 
        }
 
        Console.ReadLine();*/




       /*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
                   2, 3, 7 -> 7
                   44 5 78 -> 78
                   22 3 9 -> 22

          Console.WriteLine("Введите 3 числа:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max); */        



            


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 1)
    {
        Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
    }
        else
    {
        Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
    }
    */



    /*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
              5 -> 2, 4
              8 -> 2, 4, 6, 8*/


int N = int.Parse(Console.ReadLine());
int i = 1, k = 1;            
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
		k++;
	}
	if (k > N)
	{
		break;
	}
	i++;
}

 
            

            