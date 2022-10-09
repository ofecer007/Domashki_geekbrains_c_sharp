/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

//Ввод данных
Console.Clear();
Console.WriteLine("Программа напишет является ли день недели введеный пользователем выходным");
Console.WriteLine("Введите день недели числом (1-7):");
int userNumber = Convert.ToInt32(Console.ReadLine());
//Алгоритм
if (userNumber >= 1 && userNumber <= 7)
    if (userNumber >= 1 && userNumber <= 5)
    Console.WriteLine($"{userNumber} рабочий");
else
    Console.WriteLine($"{userNumber} выходной");
if (userNumber < 1 && userNumber > 7)
    Console.WriteLine($"Ошибка!");