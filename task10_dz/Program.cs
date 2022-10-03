/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

//Ввод данных
Console.Clear();
Console.WriteLine("Программа напишет вторую цифру 3х значного числа, которое введет пользователь");
Console.WriteLine("Введите 3х значное число:");
int userNumber = Convert.ToInt32(Console.ReadLine());
//Алгоритм
int Result = 0;
if (userNumber > 100 && userNumber < 999)
{   
    Result = userNumber/10;
    while(Result > 9)
        {
            Result = Result-10;
        }
    Console.WriteLine($"ответ = {Result}");
}
else
Console.WriteLine($"Ошибка!");