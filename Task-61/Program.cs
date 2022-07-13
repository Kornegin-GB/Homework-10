//Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

using System;
using static System.Console;
Clear();

int row = 15; // Высота треугольника Паскаля
int[,] arrayNew = new int[row, row];
int width = 3; // отступ между выводимыми символами

FillArray(arrayNew, row);
PrintArray(arrayNew, row, width);

void FillArray(int[,] triangleFill, int rowArrayFill)
{
   for (int i = 0; i < rowArrayFill; i++)
   {
      triangleFill[i, 0] = 1;
      triangleFill[i, i] = 1;
   }
   for (int i = 2; i < rowArrayFill; i++)
   {
      for (int j = 1; j <= i; j++)
      {
         triangleFill[i, j] = triangleFill[i - 1, j - 1] + triangleFill[i - 1, j];
      }
   }
}

void PrintArray(int[,] triangleAlignmentArray, int rowPrint, int widthPrint)
{
   int col = widthPrint * rowPrint;
   for (int i = 0; i < rowPrint; i++)
   {
      for (int j = 0; j <= i; j++)
      {
         SetCursorPosition(col, i + 1);
         if (triangleAlignmentArray[i, j] != 0) Write($"{triangleAlignmentArray[i, j]}");
         col += widthPrint * 2;
      }
      col = widthPrint * rowPrint - widthPrint * (i + 1);
      WriteLine();
   }
}

