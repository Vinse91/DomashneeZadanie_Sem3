﻿//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату A: ");
int xA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату A: ");
int yA = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату A: ");
int zA = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату B: ");
int xB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату B: ");
int yB = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату B ");
int zB = int.Parse(Console.ReadLine()!);



double result = Math.Sqrt((xA-xB)*(xA-xB) + (yA-yB)*(yA-yB) + (zA-zB)*(zA-zB));
Console.WriteLine(result);