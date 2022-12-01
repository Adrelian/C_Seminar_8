//Задание 1. Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//8 4 2 4
//5 9 2 3
//1 4 7 2

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)  
{                                                                           
  int[,] newArray = new int[rows, columns];  

  for (int i = 0; i < rows; i++)
  {
     for(int j = 0; j < columns; j++)
     {
       newArray[i,j] = new Random().Next(minValue,maxValue + 1);
     }
  }
  return newArray;    
}

void Show2DArray(int[,] array)
{
    for(int i = 0;i < array.GetLength(0) ;i++ ) 
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
           Console.Write(array[i,j] + " ");
        }
        Console.WriteLine(); 
    }
}

int [,] ChangeRows (int [,] array, int row1, int row2) // row1 строка 1, row2 строка2 
{
    if(row1 > array.GetLength(0) || row2 > array.GetLength(0)) // Ошибка ввода
    return array;
    // Перетасовка массива через временную переменную
    else
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
       } 
    }
    return array;
}

Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер первой строки которую хотите поменять ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер второй строки которую хотите поменять ");
int r2 = Convert.ToInt32(Console.ReadLine());

int[,] oldArray = CreateRandom2DArray(rows, colums, min, max);
Show2DArray (oldArray);
oldArray = ChangeRows(oldArray, r1, r2);
Console.WriteLine();
Show2DArray(oldArray);