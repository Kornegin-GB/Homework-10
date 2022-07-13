// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using System;
using static System.Console;
Clear();

int[,] firstArray = new int[3, 3];

FillArray(firstArray);
PrintArray(firstArray);
WriteLine();
WriteLine($"{String.Join(" ", SerchIndexMinArray(firstArray))}");
WriteLine();
int[,] secondArray = DelitRoeAndColumnArray(firstArray, SerchIndexMinArray(firstArray));
PrintArray(secondArray);

void FillArray(int[,] arrayFill)
{
   for (int i = 0; i < arrayFill.GetLength(0); i++)
   {
      for (int j = 0; j < arrayFill.GetLength(1); j++)
      {
         arrayFill[i, j] = new Random().Next(10, 100);
      }
   }
}

void PrintArray(int[,] arrayPrint)
{
   for (int i = 0; i < arrayPrint.GetLength(0); i++)
   {
      for (int j = 0; j < arrayPrint.GetLength(1); j++)
      {
         Write($"{arrayPrint[i, j]} ");
      }
      WriteLine();
   }
}

int[] SerchIndexMinArray(int[,] arraySerch)
{
   int[] minIndex = new int[2];
   int minNumber = arraySerch[0, 0];
   for (int i = 0; i < arraySerch.GetLength(0); i++)
   {
      for (int j = 0; j < arraySerch.GetLength(1); j++)
      {
         if (minNumber > arraySerch[i, j])
         {
            minNumber = arraySerch[i, j];
            minIndex[0] = i;
            minIndex[1] = j;
         }
      }
   }
   return minIndex;
}

int[,] DelitRoeAndColumnArray(int[,] firstArray, int[] indexSerch)
{
   int row = 0;
   int column = 0;
   int[,] secondArray = new int[firstArray.GetLength(0) - 1, firstArray.GetLength(1) - 1];
   for (int i = 0; i < firstArray.GetLength(0); i++)
   {
      column = 0;
      for (int j = 0; j < firstArray.GetLength(1); j++)
      {
         if (j != indexSerch[1])
         {
            secondArray[row, column] = firstArray[i, j];
            column++;
         }
      }
      if (i != indexSerch[0]) row++;
      if (row == firstArray.GetLength(1) - 1) break;
   }
   return secondArray;
}