/*Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
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
if(a % b == 0) Console.WriteLine("Число " + a + " кратно числу " + b);
else
{
    int ostatok = a % b;
    Console.WriteLine("Число " + a + " не кратно числу " + b + ". Остаток от деления " + ostatok);
}

