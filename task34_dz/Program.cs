/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

//Алгоритм
Console.Clear();
int[] getRandomArrey(int UserNumber)
{
    int[] UserArray = new int [UserNumber];
    var rnd = new Random();
    Console.WriteLine($"Массив длинною: {UserNumber} чисел");
    for(int i = 0 ; i < UserNumber ; i++)
    {
        UserArray[i] = rnd.Next(100, 1000);
        Console.Write($"{UserArray[i]} ");
    }
    Console.WriteLine("");
    return UserArray;
}

int getCountPositivNumbers(int[] UserArrey)
{
    int count = 0;
    for (int i = 0; i < UserArrey.Length; i++)
    {
        if(UserArrey[i] % 2 == 0)
        {
            count++;
        }        
    }    
    return count;
}

Console.WriteLine("Введите длину массива : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
int[] RR = getRandomArrey(UserNumber);
int CountPositiv = getCountPositivNumbers(RR);
Console.WriteLine($"В этом массиве {CountPositiv} четных числа");