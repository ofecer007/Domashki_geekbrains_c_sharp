/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int[] fillArray(int arraySize)
{
    int[] userArray = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return userArray;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int countOfNumbersBiggerZero(int[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел будем вводить? ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] userArray = fillArray(arraySize);
printArray(userArray);

int countNumbers = countOfNumbersBiggerZero(userArray);
Console.WriteLine($"Количество чисел больше ноля = {countNumbers}");