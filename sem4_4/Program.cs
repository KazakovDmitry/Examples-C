/*Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}

int [] RandomArray(int length)
{
    Random number = new Random();
    int [] arr = new int [length];
    for (int i = 0; i < length; i++)
    {
        arr [i] = number.Next(0, 2);
        Console.Write($"{arr[i]} ");
    }
    return arr;

}

int number = GetNumber("Введите длинну массива ");
RandomArray(number);