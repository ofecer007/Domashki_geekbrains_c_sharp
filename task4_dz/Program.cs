/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
//Ввод данных
Console.WriteLine("Программа покажет максимальное число из 3х введеных пользователем чисел");
Console.WriteLine("Введите первое число:");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int userNumber3 = Convert.ToInt32(Console.ReadLine());
//Алгоритм
if(userNumber1 < userNumber2)
    Console.WriteLine ($"Число {userNumber2} больше числа {userNumber1}");
    else
        Console.WriteLine ($"Число {userNumber1} больше числа {userNumber2}");
