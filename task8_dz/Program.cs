/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

//Ввод данных
Console.Clear();
Console.WriteLine("Программа напишет все четные числа от 2 до введеного пользователем числа");
Console.WriteLine("Введите число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
int whileNumber;
//Алгоритм
whileNumber = 2;
while (userNumber >= whileNumber)
{
    Console.WriteLine ($"{whileNumber}");
    whileNumber = whileNumber + 2;
}