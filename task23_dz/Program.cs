/* 
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125           */

//Ввод данных
Console.Clear();
Console.WriteLine("Программа напишет таблицу кубов чисел от 1 до того числа что введет пользователь");
Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

//Алгоритм
int task;
Console.Write("Решение: ");
for (int i=1; i <= userNumber; i++)
    {
        task = i;
        task = Convert.ToInt32(Math.Pow(i,3));
        Console.Write($"{task}, ");
    }
Console.Write($"конец");