﻿/* Задача 21: Напишите программу, которая принимает на вход координаты
 двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

int GetNumber(string msg)
{
while(true)
{
Console.WriteLine(msg);
string valueFromConsole = Console.ReadLine();

    if(int.TryParse(valueFromConsole, out int number))
    {
        return number;  
    }
    else
    {
        Console.WriteLine("Вы ввели не число. Нужно ввести число");
    }
}
}

double GetLenghtVektor(double x1,double x2,double y1,double y2)
{
    double difx= Math.Pow((x1 - x2), 2);
    double dify= Math.Pow((y1 - y2), 2);
    double length = Math.Sqrt(difx + dify);
    return length;
}

int x1 = GetNumber("Введите координату первой точки по x");
int y1 = GetNumber("Введите координату первой точки по y");
int x2 = GetNumber("Введите координату второй точки по x");
int y2 = GetNumber("Введите координату второй точки по y");

double resault = GetLenghtVektor(x1,x2,y1,y2);
Console.WriteLine(resault); 
