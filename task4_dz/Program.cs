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
int max = userNumber1;
if(userNumber1 > max) max = userNumber1;
if(userNumber2 > max) max = userNumber2;
if(userNumber3 > max) max = userNumber3;
Console.WriteLine ($"Число {max} максимальное");