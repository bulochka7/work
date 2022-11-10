//Задача 47. Задайте двумерный массив размером m n, заполненный случайными вещественными числами.

/*
double[,] CreateArray()
{
    Console.WriteLine("input m");
    int m=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input n");
    int n=Convert.ToInt32(Console.ReadLine());
    double[,] array=new double[m,n];
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            array[i, j] = new Random().Next(-100,100); 
            array[i, j]/=10;       
        }
    }
    return array;    
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(String.Format("  {0:F02}", array[i, j]));
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}

double[,] array=CreateArray();
PrintArray(array);

*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}
void Qwer(int[,] array,int rows, int columns)
{
    Console.WriteLine("input m");
    int m=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input n");
    int n=Convert.ToInt32(Console.ReadLine());
    if(m>rows-1 || n>columns-1)
    {
        Console.WriteLine("Error");
    }
    else 
    {
        Console.WriteLine(array[m,n]);
    }
}
Console.WriteLine("input rows");
int rows1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input colums");
int columns1=Convert.ToInt32(Console.ReadLine());

int[,] array=Create2DArrayRandomInt(rows1,columns1,1,10);
PrintArray(array);
Qwer(array,rows1,columns1);
*/

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


double[,] CreateArray(int rows, int columns)
{
    double[,] array=new double[rows,columns];
    for(int i=0; i<array.GetLength(0);i++)
    {
        for(int j=0; j<array.GetLength(1);j++)
        {
            array[i, j] = new Random().Next(0,10);        
        }
    }
    return array;    
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(", ");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(",");
        else Console.WriteLine(".");
    }
}

double[] Arithmetic(double[,] array,int rows, int columns)
{
    
    double[] array1=new double[columns];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double res=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            res=res+array[i,j];
            array1[j]=res/rows; 
        }
    }
    return array1;
}
void ShowArray(double[] array)
{
    for(int i = 0; i<array.Length;i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine("input rows");
int rows=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input colums");
int columns=Convert.ToInt32(Console.ReadLine());
double[,] newArray=CreateArray(rows,columns);
PrintArray(newArray);
double[] array1=Arithmetic(newArray,rows,columns);
ShowArray(array1);