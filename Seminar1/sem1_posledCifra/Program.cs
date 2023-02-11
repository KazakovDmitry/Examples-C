/*Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8
*/

Console.WriteLine("Введите трехзначное число: ");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int a = number % 10;
Console.WriteLine(a);