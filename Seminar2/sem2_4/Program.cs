/*Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/
int GetNumber() //Функция получения числа
{
    Console.WriteLine("Введите число: ");
    string numberStr = Console.ReadLine();
    int number = Convert.ToInt32(numberStr);
    return number;
}

int a = GetNumber();
if(a % 7 == 0 && a % 23 == 0) Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}

