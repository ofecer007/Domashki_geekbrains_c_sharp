/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

//Ввод данных
Console.Clear();
Console.WriteLine("Программа напишет третью цифру 3х значного числа, которое введет пользователь");
Console.WriteLine("Введите 3х значное число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
//Алгоритм
if (userNumber >= 100)
{
    while(userNumber > 1000)
    {
        userNumber/=10;
    }
    userNumber%=10;
    Console.WriteLine($"ответ = {userNumber}");
}
else
    Console.WriteLine($"Третей цифры нет!");