﻿/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double[] CoordXY(double b1, double k1, double b2, double k2)
{
  double[] arrayXY = new double[2];
  double x = (b2 - b1) / (k1 - k2);
  double y = k1 * x + b1;
  arrayXY[0] = x;
  arrayXY[1] = y;
  return arrayXY;
}

Console.Clear();
Console.Write("Введите переменную b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите переменную k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите переменную b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите переменную k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Точка пересечения 2х прямых:({String.Join(", ", CoordXY(b1, k1, b2, k2))})");
Console.WriteLine();
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({String.Join(", ", CoordXY(b1, k1, b2, k2))})");


