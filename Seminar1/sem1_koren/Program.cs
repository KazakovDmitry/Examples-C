/*Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите число а:");
string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);

Console.WriteLine("Введите число b:");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

if(b*b == a){
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
}
else
{
    Console.WriteLine("Число " + a + " не является квадратом числа " + b);
}