//Двумерный массив строк. Индексы меняются также от 0
/* string[,] table = new string[2, 5];
table[1, 2] = "слово"; //запись в ячейку

for (int rows = 0; rows < 2; rows++)  //цикл по строкам
{
    for (int columns = 0; columns < 5; columns++)  //цикл по столбцам
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} */

//Двумерный массив чисел.

/* void PrintArray (int [,] matr) //метод печати массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  //цикл по строкам, GetLength(0) - означает количество строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)  //цикл по столбцам, GetLength(1) - означает количество столбцов
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray (int [,] matr) //метод заполнения массива
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {
        for (int j = 0; j < matr.GetLength(1); j++)  
        {
            matr[i, j] = new Random().Next(1, 10); // [1, 10)
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray (matrix);
FillArray (matrix);
Console.WriteLine();
PrintArray (matrix); */


//Рекурсия

/* double Factorial(int n)
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
 */

double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 45; i++)
{
 Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
