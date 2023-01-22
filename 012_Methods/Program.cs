﻿//Методы
// Вид 1 - Ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор Дмитрий Казаков");
}
//Method1();


//Вид 2 - Что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21("Текст сообщения", 4);
//Method21(msg: "Текст сообщения", count: 4); //Явно указываем какому аргументу что принадлежит
//Method21(count: 4, msg: "новый текст"); //в таком случае можно указывать в любом порядке


//Вид 3 - Ничего не принимают, что-то возвращают, обязательно использование оператора return
int Method3()
{
    return DateTime.Now.Year;
}
//Method3(); в такой записи на экран ничего не выводится
int year = Method3(); //записываем в переменную результат работы метода
//Console.WriteLine(year); //выводим на экран


//Вид 4 - Что-то принимают, что-то возвращают, обязательно использование оператора return
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);

//применение цикла в цикле
/* for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
} */


//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к" заменить большими “К",
// а большие “С" маленькими “с"

/* string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s [3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); */

/* Сортировка массива от мин к макс
Было: 6 8 3 2 1 4 5 7
Стало: 1 2 3 4 5 6 7 8 
*/

/* int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    } 
    Console.WriteLine();
} 

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
            
            int temp = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temp;        
    }
}

PtintArray(arr);
SelectionSort(arr);
PtintArray(arr); */

//Сортировка от макс к мин
int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    } 
    Console.WriteLine();
} 

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
            
            int temp = array[i];
            array[i] = array[maxPosition];
            array[maxPosition] = temp;        
    }
}

PtintArray(arr);
SelectionSort(arr);
PtintArray(arr);