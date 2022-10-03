/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

//Ввод данных
Console.Clear();
Console.WriteLine("Программа напишет является ли число чётным");
Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
//Алгоритм
if(userNumber %2==0) 
    Console.WriteLine ($"{userNumber} четное");
else 
    Console.WriteLine ($"{userNumber} нечетное");