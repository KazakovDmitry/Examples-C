/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
string numberA = Console.ReadLine();
string numberB = String.Empty;

//numberB = numberA.Substring(numberA.Length - 1, 1);

for (int i = 0; i < numberA.Length; i++)
{
    numberB = numberB + numberA [numberA.Length - i -1];
    //numberB = numberB + numberA.Substring(numberA.Length - i -1, 1);
}

Console.WriteLine(numberB);
if(numberB == numberA) Console.WriteLine("Палиндром");
else Console.WriteLine("Не палиндром");
