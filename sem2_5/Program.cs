/*Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/
int GetNumber() //Функция получения числа
{
    Console.WriteLine("Введите число: ");
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    return number;
}

int a = GetNumber();
int b = GetNumber();

if(a * a == b || b * b == a) Console.WriteLine("Да");
else Console.WriteLine("Нет");