/*  Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да                  */

//Ввод данных
Console.Clear();
Console.WriteLine("Программа напишет, является число введенное пользователем палиндромом (12821, 23432)");
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());

//Алгоритм
int reversUserNumber(int userNumber)  // Кто-то улучшил эту часть кода
{
    int reverseNumber = 0;
    while(userNumber > 0)
    {
        reverseNumber *= 10;
        reverseNumber += userNumber % 10;
        userNumber /= 10;
    }  
    return reverseNumber;
}
if(reversUserNumber(userNumber) == userNumber) 
    Console.WriteLine("ДА! Это число палиндром!");
else Console.WriteLine("НЕТ! Это число не является палиндромом!");