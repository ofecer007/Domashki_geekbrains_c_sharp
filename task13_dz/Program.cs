/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine("Программа напишет вторую цифру 3х значного числа, которое введет пользователь");
Console.WriteLine("Введите 3х значное число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
//Алгоритм
int Result = 0;
if (userNumber > 100 && userNumber < 999)
{   
    Result = userNumber/10;
    while(Result > 10)
        {
            Result = Result-10;
        }
    Console.WriteLine($"ответ = {Result}");
}
else
Console.WriteLine($"Третей цифры нет!");